namespace Pool.Ex2
{
    public interface IPoolable
    {
        string PoolId { get; }
        int ObjCount { get; }
    }
}
