namespace Mediator.Ex2
{
    public class StockOffer
    {
        public Stock Stock { get; }
        public int StockShares { get; }
        public int ColleagueCode { get; }

        public StockOffer(int numOfShares, Stock stock, int collCode)
        {
            Stock = stock;
            ColleagueCode = collCode;
            StockShares = numOfShares;
        }
    }
}