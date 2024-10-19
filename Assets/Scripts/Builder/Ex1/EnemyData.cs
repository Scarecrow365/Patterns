namespace Builder.Ex1
{
    public class EnemyData
    {
        public string Name { get; private set; } = "Enemy";
        public int Health { get; private set; } = 100;
        public float Speed { get; private set; } = 1;
        public int Damage { get; private set; } = 1;
        public bool IsBoss { get; private set; }

        public class Builder
        {
            private string name;
            private int health;
            private float speed;
            private int damage;
            private bool isBoss;

            public Builder WithName(string name)
            {
                this.name = name;
                return this;
            }

            public Builder WithHealth(int health)
            {
                this.health = health;
                return this;
            }

            public Builder WithSpeed(float speed)
            {
                this.speed = speed;
                return this;
            }

            public Builder WithDamage(int damage)
            {
                this.damage = damage;
                return this;
            }

            public Builder IsBoss(bool isBoss)
            {
                this.isBoss = isBoss;
                return this;
            }

            public EnemyData Build()
            {
                EnemyData enemyData = new()
                {
                    Name = name,
                    Health = health,
                    Speed = speed,
                    Damage = damage,
                    IsBoss = isBoss
                };
                
                return enemyData;
            }
        }
    }
}