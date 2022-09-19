public interface II2cAddress<T> where T: II2cAddress<T>
{
    static abstract int DefaultI2cAddress { get; }
}