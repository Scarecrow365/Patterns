namespace Prototype.Ex1
{
    public class Spawner
    {
        public ICopyable Copy;

        public Enemy SpawnEnemy(Enemy prototype)
        {
            Copy = prototype.Copy();
            return (Enemy)Copy;
        }
    }
}