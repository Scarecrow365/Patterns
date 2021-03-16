namespace Visitor.Ex1
{
    public class Robot : IRobotPart
    {
        public IRobotPart[] RobotParts { get; }

        public Robot()
        {
            RobotParts = new IRobotPart[] {new MechanicalArm(), new ThermalImager(), new Battery()};
        }

        public void Accept(IRobotPartVisitor robotPartVisitor)
        {
            foreach (var part in RobotParts)
            {
                part.Accept(robotPartVisitor);
            }

            robotPartVisitor.Visit(this);
        }
    }
}