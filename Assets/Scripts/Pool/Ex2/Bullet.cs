namespace Pool.Ex2
{
    public class Bullet : BaseAmmo
    {
        private int _bulletsCount = 50;
        private string _poolId = "Bullet1";

        public override string PoolId { get => _poolId; }
        public override int ObjCount { get => _bulletsCount; }
    }
}