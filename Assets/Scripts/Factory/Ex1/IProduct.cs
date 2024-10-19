namespace Factory.Ex1
{
    public interface IProduct
    {
        public string ProductName { get; set; }

        public void Initialize();
    }
}