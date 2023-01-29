using System.Collections.Generic;
using UnityEngine;

namespace Mediator.Ex2
{
    public class StockMediator : IMediator
    {
        private readonly List<Colleague> colleagues;
        private readonly List<StockOffer> buyOffers;
        private readonly List<StockOffer> sellOffers;

        private int colleagueCodes;

        public StockMediator()
        {
            buyOffers = new List<StockOffer>();
            colleagues = new List<Colleague>();
            sellOffers = new List<StockOffer>();
        }

        public void AddColleague(Colleague colleague)
        {
            colleagues.Add(colleague);
            colleagueCodes++;
            colleague.SetCode(colleagueCodes);
        }

        public void BuyOffer(Stock stock, int shares, int code) => 
            UpdateOffers(stock, shares, code, StockType.Buy);
        public void SaleOffer(Stock stock, int shares, int code) => 
            UpdateOffers(stock, shares, code, StockType.Sell);

        public void PrintStockOfferings()
        {
            Debug.Log("For Sale: " + sellOffers.Count);
            foreach (StockOffer offer in sellOffers)
            {
                Debug.Log(offer.Stock + " - " + offer.StockShares + " - " + offer.ColleagueCode);
            }

            Debug.Log("For Buy: " + buyOffers.Count);
            foreach (StockOffer offer in buyOffers)
            {
                Debug.Log(offer.Stock + " - " + offer.StockShares + " - " + offer.ColleagueCode);
            }
        }

        private void UpdateOffers(Stock stock, int shares, int code, StockType type)
        {
            bool stockState = false;

            string stockType = type == StockType.Buy ? "bought" : "sold";

            string log1 = $"{shares} shares of {stock} stocks {stockType} to colleague with code {code}";
            string log2 = $"{shares} shares of {stock} stocks added to inventory";

            var mainOffers = type == StockType.Buy ? buyOffers : sellOffers;
            var secondaryOffers = type == StockType.Buy ? sellOffers : buyOffers;

            for (int i = 0; i < mainOffers.Count; i++)
            {
                StockOffer offer = mainOffers[i];
                if (offer.Stock == stock && offer.StockShares == shares)
                {
                    Debug.Log(log1);

                    mainOffers.Remove(offer);
                    stockState = true;
                }

                if (stockState)
                    break;
            }

            if (!stockState)
            {
                Debug.Log(log2);
                StockOffer offer = new(shares, stock, code);
                secondaryOffers.Add(offer);
            }
        }

        private enum StockType
        {
            Sell,
            Buy
        }
    }
}