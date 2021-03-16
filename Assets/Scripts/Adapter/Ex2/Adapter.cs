namespace Adapter.Ex2
{
    public class Adapter : IEnemyAttacker
    {
        private readonly Robot _robot;

        public Adapter(Robot newRobot)
        {
            _robot = newRobot;
        }

        public void Fire()
        {
            _robot.HandAttack();
        }

        public void DriveForward()
        {
            _robot.MoveForward();
        }

        public void AssignDriver(string driver)
        {
            _robot.SetDriver(driver);
        }
    }
}