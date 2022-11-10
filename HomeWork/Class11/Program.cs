// See https://aka.ms/new-console-template for more information
using Class11;

Console.WriteLine("Hello, World!");

Laptop laptop = new Laptop();
laptop.AddUsbDeviceInPort1(new Pendrive());
Console.WriteLine(laptop.TransferDataFromPort1());

laptop.AddUsbDeviceInPort2(new Keyboard());
Console.WriteLine(laptop.TransferDataFromPort2());