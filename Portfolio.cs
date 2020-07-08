using System;
using WeStock.ViewModels;

namespace WeStock.Models
{
    public class Portfolio: ViewModelBase
    {
        private double? _acctMV;
        private double? _cash;
        private double? _positionMV;
        private double? _acctDailyAmt;
        private double? _cashWTDAmt;
        private double? _cashMTDAmt;
        private double? _algoCash;
        private double? _orderCash;
        private double? _adjustedCash;
        private double? _buyPower;
        private double? _margin;
        private double? _qTDAmt;
        private double? _yTDAmt;




        public double? AcctMV { get => _acctMV; set => _acctMV = value; }
        public double? Cash { get => _cash; set => _cash = value; }
        public double? PositionMV { get => _positionMV; set => _positionMV = value; }
        public double? AcctDailyAmt { get => _acctDailyAmt; set => _acctDailyAmt = value; }
        public double? CashWTDAmt { get => _cashWTDAmt; set => _cashWTDAmt = value; }
        public double? CashMTDAmt { get => _cashMTDAmt; set => _cashMTDAmt = value; }
        public double? AlgoCash { get => _algoCash; set => _algoCash = value; }
        public double? OrderCash { get => _orderCash; set => _orderCash = value; }
        public double? AdjustedCash { get => _adjustedCash; set => _adjustedCash = value; }
        public double? BuyPower { get => _buyPower; set => _buyPower = value; }
        public double? Margin { get => _margin; set => _margin = value; }
        public double? QTDAmt { get => _qTDAmt; set => _qTDAmt = value; }
        public double? YTDAmt { get => _yTDAmt; set => _yTDAmt = value; }
    }
}
