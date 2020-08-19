using System;
using System.Collections.Generic;
using System.Text;

namespace StoxTrader.Web.Shared
{
    public class Algo
    {
        public string Symbol { get; set; }
        public string Company { get; set; }
        public bool IsBuy { get; set; }
        public string Level { get; set; }
        public string Price { get; set; }
        public string NextPriceBuyOpt { get; set; }
        public string NextPriceBuy { get; set; }
        public string NextPriceSellOpt { get; set; }
        public string NextPriceSell { get; set; }
        public string QtyOpt { get; set; }
        public string Qty { get; set; }
        public string NextQtyBuyOpt { get; set; }
        public string NextQtyBuy { get; set; }
        public string NextQtySellOpt { get; set; }
        public string NextQtySell { get; set; }
        public string LevelGainOpt { get; set; }
        public string LevelGain { get; set; }
        public string LevelSellOpt { get; set; }
        public string LevelSell { get; set; }
        public bool IsBuyBack { get; set; }

    }
}
