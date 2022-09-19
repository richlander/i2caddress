public class Device : II2cAddress<Device>
{
    public static int DefaultI2cAddress
    {
        get => 0x70;
    }
}