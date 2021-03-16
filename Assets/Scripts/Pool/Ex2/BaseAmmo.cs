namespace Pool.Ex2
{
    public abstract class BaseAmmo : IPoolable
    {
        public abstract string PoolId { get; }
        public abstract int ObjCount { get; }
    }
}