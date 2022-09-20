// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("I have two devices, with two specific addresses:");
Console.WriteLine($"- {nameof(Device)}: {Device.DefaultI2cAddress:X3}");
Console.WriteLine($"- {nameof(SpecializedDevice)}: {SpecializedDevice.DefaultI2cAddress:X3}");
Console.WriteLine($"- {nameof(MoreSpecializedDevice)}: {MoreSpecializedDevice.DefaultI2cAddress:X3}");
