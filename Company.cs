using System;
using System.Collections.Generic;
using System.Text;

namespace StoxTrader.Web.Shared
{
    public class Company
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public bool IsEnabled { get; set; }
        public string Type { get; set; }
        public object IexId { get; set; }
    }
}
