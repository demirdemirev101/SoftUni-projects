using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        private Dictionary<string,Stock> portfolio;

        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;

            portfolio = new Dictionary<string, Stock>();
        }

        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }
        public int Count { get => portfolio.Count; }

        public void BuyStock(Stock stock)
        {
            if (stock.MarketCapitalization>10_000 && MoneyToInvest>=stock.PricePerShare)
            {
                portfolio.Add(stock.CompanyName,stock);
                MoneyToInvest -= stock.PricePerShare;
            }
        }
        public string SellStock(string companyName, decimal sellPrice)
        {
            if (!portfolio.ContainsKey(companyName))
            {
                return $"{companyName} does not exist.";
            }

            var pricePerShare=portfolio[companyName].PricePerShare;
            if (sellPrice < pricePerShare)
            {
                return $"Cannot sell {companyName}.";
            }

            portfolio.Remove(companyName);
            MoneyToInvest += sellPrice;
            return $"{companyName} was sold.";
        }
        public Stock FindStock(string companyName)
        {
            if (portfolio.ContainsKey(companyName))
            {
            var stock = portfolio[companyName];
            return stock;
            }
                return null;
        }
        public Stock FindBiggestCompany()
        {
            if (Count==0)
            {
                return null;
            }
            return portfolio.Values.OrderByDescending(s => s.MarketCapitalization).First(); 
        }
        public string InvestorInformation()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"The investor {FullName} with a broker {BrokerName} has stocks:");
            foreach (var stock in portfolio)
            {
                stringBuilder.AppendLine(stock.Value.ToString());
            }
            return stringBuilder.ToString().Trim();
        }
    }
}
