using UnityEngine;

namespace Mediator.Ex2
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            IMediator mediator = new StockMediator();

            Colleague jtPoorman = new JTPoorman(mediator);
            Colleague gormanSlacks = new GormanSlacks(mediator);

            mediator.AddColleague(jtPoorman);
            mediator.AddColleague(gormanSlacks);

            gormanSlacks.SaleOffer(Stock.GOOG, 50);
            gormanSlacks.SaleOffer(Stock.MSFT, 100);

            jtPoorman.SaleOffer(Stock.NRG, 10);
            jtPoorman.BuyOffer(Stock.MSFT, 100);

            gormanSlacks.BuyOffer(Stock.NRG, 10);
            gormanSlacks.BuyOffer(Stock.NRG, 50);

            StockMediator stockMediator = (StockMediator)mediator;
            stockMediator.PrintStockOfferings();
        }
    }
}