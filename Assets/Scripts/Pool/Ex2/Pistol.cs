namespace Pool.Ex2
{
    public class Pistol
    {
        private string _bulletId;

        private void Fire()
        {
            var bullet = ObjectPool.Instance.GetObjects(_bulletId);
        }
    }
}