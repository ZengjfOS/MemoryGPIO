# Win32GPIO

* 解决高端内存访问溢出导致无法访问；
* 主要是因为默认采用了有符号整型指针，修改参数传递为无符号整形指针；
* 经测试运行正常，并且能够访问高端内存地址。

## Download

[WinIo](https://www.softpedia.com/get/Programming/Components-Libraries/WinIo.shtml)
