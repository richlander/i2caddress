# i2caddress -- `static virtual` interface member

The `static virtual` interface feature enables us to model specifying i2c addresses (as static methods) and to choose to specify a different value in more derived implementations (like we can do today).

The relevant code:

```csharp
public interface II2cAddress
{
    static abstract int DefaultI2cAddress { get; }
}

public class Device : II2cAddress
{
    public static int DefaultI2cAddress => 0x70;
}

public class MoreSpecializedDevice : Device, II2cAddress
{
    public static new int DefaultI2cAddress => 0x74;
}
```

This is what the app looks like:

```bash
% dotnet run
Hello, World!
I have two devices, with two specific addresses:
- Device: 070
- MoreSpecializedDevice: 074
```

The repo contains both the way we do this today, in the [net60](net60) folder and this new way, in the [net70](net70) folder.

This PoC is a breaking change on what we have today. It's more a question of whether this is a model we want to adopt as a going forward idea.
