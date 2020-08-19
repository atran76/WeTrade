using System;
using System.Collections.Generic;
using System.Text;

namespace StoxTrader.Web.Shared
{
    public class Ticker
    {
        public int? Level { get; set; }
        public double? Qty { get; set; }
        public double? Price { get; set; }
        public double? StartPrice { get; set; }
        public double? StartQty { get; set; }
        public double? ExecutePrice { get; set; }
        public double? ExecuteQty { get; set; }
        public double? SellPrice { get; set; }
        public double? SellQty { get; set; }
        public double? AlgoPrice { get; set; }
        public double? AlgoQty { get; set; }
        public string Symbol { get; set; }
        public string Status { get; set; }
        public string Action { get; set; }
        public double? MarketValue { get; set; }
        public double? GainLossRealized { get; set; }
        public double? GainLossUnrealized { get; set; }
        public double? GainLossTotal { get; set; }
        public string ParentId { get; set; }
        public string ChildId { get; set; }
        public string BuyOrSell { get; set; }
        public string Fill { get; set; }
        public string Partial { get; set; }
        public string Side { get; set; }
        public string Time { get; set; }



    }
}
