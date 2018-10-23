// ---------------------------------------------------- //
//                      WinIo v3.0                      //
//          Direct Hardware Access Under Windows        //
//           Copyright 1998-2010 Yariv Kaplan           //
//               http://www.internals.com               //
// ---------------------------------------------------- //

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace DumpPhys
{
    public unsafe partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            GPIO7111.GPIOInit();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            GPIO7111.FreeGPIO();
        }

        private void OutputWrite_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(OutputIndex.Text);
            int val = ((OutputValue.Text == "Low") ? 0 : 1);

            GPIO7111.setGPO(index, val);
        }

        private void InputRead_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(InputIndex.Text);
            int val = GPIO7111.getGPI(index);

            if (val == 0)
            {
                InputValue.Text = "Low";
            }
            else
            {
                InputValue.Text = "High";
            }
        }
    }
}