using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace DumpPhys
{
    class GPIO7111
    {
        [DllImport("kernel32.dll")]
        private extern static IntPtr LoadLibrary(String DllName);

        [DllImport("kernel32.dll")]
        private extern static IntPtr GetProcAddress(IntPtr hModule, String ProcName);

        [DllImport("kernel32")]
        private extern static bool FreeLibrary(IntPtr hModule);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool InitializeWinIoType();

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool GetPhysLongType(UIntPtr PhysAddr, UInt32[] pPhysVal);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool SetPhysLongType(UIntPtr PhysAddr, UInt32 PhysVal);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool ShutdownWinIoType();

        private static IntPtr hMod;
        private static UInt32 OUTPUT_MODE = 0x4;
        private static UInt32 INPUT_MODE = 0x2;

        public static UInt32 GPIO_BASE_ADDR = 0xFED0C000;
        public static UInt32 GPIO_VALUE_OFFSET = 0x8;
        public static UInt32[] GPI = {
                                0xFED0E250,
                                0xFED0E120,
                                0xFED0E0A0,
                                0xFED0E160
                               };

        public static UInt32[] GPI_MUX = {
                                0x2003CC80,
                                0x2003CC80,
                                0x2003CD01,
                                0x2003CC80
                               };

        public static UInt32[] GPO = {
                                0xFED0E200,
                                0xFED0E220,
                                0xFED0E240,
                                0xFED0E260
                               };

        public static UInt32[] GPO_MUX = {
                                0x2003CC80,
                                0x2003CC80,
                                0x2003CC80,
                                0x2003CC80
                               };

        public static int GPIOInit()
        {
            // Check if this is a 32 bit or 64 bit system
            if (IntPtr.Size == 4)
            {
                hMod = LoadLibrary("WinIo32.dll");
                
            }
            else if (IntPtr.Size == 8)
            {
                hMod = LoadLibrary("WinIo64.dll");
            }

            if (hMod == IntPtr.Zero)
            {
                MessageBox.Show("Can't find WinIo dll.\nMake sure the WinIo library files are located in the same directory as your executable file.", "DumpPhys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

            IntPtr pFunc = GetProcAddress(hMod, "InitializeWinIo");

            if (pFunc != IntPtr.Zero)
            {
                InitializeWinIoType InitializeWinIo = (InitializeWinIoType)Marshal.GetDelegateForFunctionPointer(pFunc, typeof(InitializeWinIoType));
                bool Result = InitializeWinIo();

                if (!Result)
                {
                    MessageBox.Show("Error returned from InitializeWinIo.\nMake sure you are running with administrative privileges and that the WinIo library files are located in the same directory as your executable file.", "DumpPhys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FreeLibrary(hMod);
                    return -2;
                }
            }

            for (int index = 0; index < GPO.Length; index++)
            {
                setMemoryValue(GPO[index], GPO_MUX[index]);
                setMemoryValue(GPO[index] + GPIO_VALUE_OFFSET, OUTPUT_MODE);

                setMemoryValue(GPI[index], GPI_MUX[index]);
                setMemoryValue(GPI[index] + GPIO_VALUE_OFFSET, INPUT_MODE);
            }

            return 0;
        }

        public static int FreeGPIO()
        {
            IntPtr pFunc = GetProcAddress(hMod, "ShutdownWinIo");

            if (pFunc != IntPtr.Zero)
            {
                ShutdownWinIoType ShutdownWinIo = (ShutdownWinIoType)Marshal.GetDelegateForFunctionPointer(pFunc, typeof(ShutdownWinIoType));

                ShutdownWinIo();
                FreeLibrary(hMod);
            }

            return 0;
        }

        public static int setMemoryValue(UInt32 addr, UInt32 val)
        {

            IntPtr pFunc = GetProcAddress(hMod, "SetPhysLong");

            if (pFunc != IntPtr.Zero)
            {
                UInt32 PhysVal;
                UInt64 PhysAddr64;

                PhysAddr64 = addr;
                PhysVal = val;

                SetPhysLongType SetPhysLong = (SetPhysLongType)Marshal.GetDelegateForFunctionPointer(pFunc, typeof(SetPhysLongType));

                // Call WinIo to set value
                bool Result = SetPhysLong((UIntPtr)PhysAddr64, PhysVal);

                if (!Result)
                {
                    MessageBox.Show("Error returned from SetPhysLong", "DumpPhys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -2;
                }

                return 0;
            }

            return -1;
        }

        public static int getMemoryValue(UInt32 addr)
        {

            IntPtr pFunc = GetProcAddress(hMod, "GetPhysLong");

            if (pFunc != IntPtr.Zero)
            {
                UInt32[] PhysVal = { 0 };
                UInt64 PhysAddr64;

                PhysAddr64 = addr;

                GetPhysLongType GetPhysLong = (GetPhysLongType)Marshal.GetDelegateForFunctionPointer(pFunc, typeof(GetPhysLongType));

                // Call WinIo to get value
                bool Result = GetPhysLong((UIntPtr)PhysAddr64, PhysVal);

                if (Result)
                {
                    return (int)(PhysVal[0]);
                }
                else
                {
                    MessageBox.Show("Error returned from GetPhysLong", "DumpPhys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -2;
                }

            }

            return -1;
        }

        public static int setGPO(int index, int value)
        {
            if (index < GPO.Length)
            {
                int val = 0;
                val = getMemoryValue(GPO[index] + GPIO_VALUE_OFFSET);
                if (val >= 0)
                {
                    val = (val & (~0x1)) | (value & 0x1);

                    int ret = setMemoryValue(GPO[index] + GPIO_VALUE_OFFSET, (UInt32)val);

                    if (ret >= 0)
                    {
                        return 0;
                    }
                    else
                    {
                        MessageBox.Show("Error from set GPO ret: " + ret);
                        return -3;
                    }
                }
                else
                {
                    MessageBox.Show("Error from set GPO(get value): " + val);
                    return -2;
                }
            }
            else
            {
                return -1;
            }
        }

        public static int getGPI(int index)
        {
            if (index < GPO.Length)
            {
                int val = 0;
                val = getMemoryValue(GPI[index] + GPIO_VALUE_OFFSET);
                if (val >= 0)
                {
                    return val & 0x01;
                }
                else
                {
                    MessageBox.Show("Error from get GPO: " + val);
                    return -2;
                }

            }
            else
            {
                return -1;
            }
        }
    }
}