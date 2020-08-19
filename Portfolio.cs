using System;
using System.Collections.Generic;
using System.Text;

namespace StoxTrader.Web.Shared
{
    public class Portfolio
    {
        public string AcctMV { get; set; }
        public string PositionMV { get; set; }
        public string Cash { get; set; }
        public string AlgoCash { get; set; }
        public string OrderCash { get; set; }
        public string AdjustedCash { get; set; }
        public string Daily { get; set; }
        public string WTD { get; set; }
        public string MTD { get; set; }
        public string QTD { get; set; }
        public string YTD { get; set; }
        public string Margin { get; set; }
        public string BuyPower { get; set; }
    }
}
