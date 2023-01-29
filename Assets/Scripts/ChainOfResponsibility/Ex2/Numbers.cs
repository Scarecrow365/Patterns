namespace ChainOfResponsibility.Ex2
{
    public class Numbers
    {
        public int number1 { get; protected set; }
        public int number2 { get; protected set; }

        public CalculationType calculationWanted { get; protected set; }

        public Numbers(int num1, int num2, CalculationType calcWanted)
        {
            this.number1 = num1;
            this.number2 = num2;
            this.calculationWanted = calcWanted;
        }
    }
}