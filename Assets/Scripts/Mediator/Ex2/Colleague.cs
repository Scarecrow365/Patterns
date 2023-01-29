namespace Mediator.Ex2
{
    public abstract class Colleague
    {
        private int _colleagueCode;

        private readonly IMediator _mediator;
        
        protected Colleague(IMediator mediator) => _mediator = mediator;
        public void SetCode(int code) => _colleagueCode = code;
        public void SaleOffer(Stock stock, int shares) =>
            _mediator.SaleOffer(stock, shares, _colleagueCode);
        public void BuyOffer(Stock stock, int shares) =>
            _mediator.BuyOffer(stock, shares, _colleagueCode);
    }
}