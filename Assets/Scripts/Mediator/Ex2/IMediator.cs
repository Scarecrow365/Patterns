namespace Mediator.Ex2
{
    public interface IMediator
    {
        void AddColleague(Colleague colleague);
        void BuyOffer(Stock stock, int shares, int code);
        void SaleOffer(Stock stock, int shares, int code);
    }
}