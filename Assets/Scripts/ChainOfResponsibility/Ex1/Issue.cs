namespace ChainOfResponsibility.Ex1
{
    internal class Issue
    {
        public int Number { get; }
        public string Purpose { get; }
        public double Amount { get; set; }
        
        public Issue(int number, double amount, string purpose)
        {
            Number = number;
            Amount = amount;
            Purpose = purpose;
        }
    }
}