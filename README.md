# i2caddress

The `static virtual` feature enables us to expose differing i2c addresses while also using inheritance.

This is what the app looks like:

```bash
% dotnet run
Hello, World!
I have two devices, with two specific addresses:
- Device: 070
- MoreSpecializedDevice - 074
```

The relevant code:

```csharp
public class Device : II2cAddress<Device>
{
    public static int DefaultI2cAddress = 0x70;
}

public class MoreSpecializedDevice : Device
{
    public static new int DefaultI2cAddress = 0x74;
}
```

That specialization only becomes possible with C# 11 (and .NET 7).
