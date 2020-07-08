using System;
using Telerik.XamarinForms.Common.DataAnnotations;
using WeStock.ViewModels;

namespace WeStock.Models
{
    public class Ticker : ViewModelBase
    {

        private string _symbol;
        private string _companyName;
        private int? _maxScale;
        private double? _price;
        private double? _sellPercent;
        private bool _buyBack;
        private int? _buySellIndex;
        private string _action;
        private double? _nextBuyPrice;
        private double? _nextSellPrice;
        private string _nextBuyPriceOption;
        private string _nextSellPriceOption;
        private double? _qty;
        private string _qtyOption;
        private double? _nextBuyQty;
        private string _nextBuyQtyOption;
        private double? _nextSellQty;
        private string _nextSellQtyOption;
        private double? _gain;
        private string _gainOption;
        private int? _levelIndex;
        private double? _salePrice;
        private double? _saleDate;
        private double? _saleQty;
        private double? _algoPrice;
        private double? _algoQty;
        private string _status;
        private bool? _isRemoveFromLevel;
        private string _parentId;
        private string _algo;
        private double? _realizedGainLoss;
        private double? _unRealizedGainLoss;
        private double? _totalGainLoss;
        private DateTime? _startDate;
        private string _fill;
        private string _partial;
        private string _stop;
        private double? _pPrice;
        private double? _pQty;
        private string _childId;
        private DateTime? _orderedDate;
        private string _side;
        private double? _gainLossAmt;
        private double? _gainLossPercent;
        private double? _marketValue;
        private double? _cost;
        private double? _avgPrice;
        private double? _startPrice;
        private double? _executedPrice;
        private double? _executedQty;

        public string Symbol { get => _symbol; set { _symbol = value; RaisePropertyChanged("Symbol"); } }

        public string Status { get => _status; set { _status = value; RaisePropertyChanged("Status"); } }

        public int? LevelIndex { get => _levelIndex; set { _levelIndex = value; RaisePropertyChanged("LevelIndex"); } }

        public string CompanyName { get => _companyName; set { _companyName = value; RaisePropertyChanged("CompanyName"); } }

        public int? MaxScale { get => _maxScale; set { _maxScale = value; RaisePropertyChanged("MaxScale"); } }

        public double? Price { get => _price; set { _price = value; RaisePropertyChanged("Price"); } }

        public double? Qty { get => _qty; set { _qty = value; RaisePropertyChanged("Qty"); } }

        public string QtyOption { get => _qtyOption; set { _qtyOption = value; RaisePropertyChanged("QtyOption"); } }

        public double? NextBuyQty { get => _nextBuyQty; set { _nextBuyQty = value; RaisePropertyChanged("NextBuyQty"); } }

        
        public string NextBuyQtyOption { get => _nextBuyQtyOption; set { _nextBuyQtyOption = value; RaisePropertyChanged("NextBuyQtyOption"); } }

        
        public double? NextSellQty { get => _nextSellQty; set { _nextSellQty = value; RaisePropertyChanged("NextSellQty"); } }

        
        public string NextSellQtyOption { get => _nextSellQtyOption; set { _nextSellQtyOption = value; RaisePropertyChanged("NextSellQtyOption"); } }

        
        public double? Gain { get => _gain; set { _gain = value; RaisePropertyChanged("Gain"); } }

        
        public string GainOption { get => _gainOption; set { _gainOption = value; RaisePropertyChanged("GainOption"); } }

        
        public double? SellPercent { get => _sellPercent; set { _sellPercent = value; RaisePropertyChanged("SellPercent"); } }

        
        public bool BuyBack { get => _buyBack; set { _buyBack = value; RaisePropertyChanged("BuyBack"); } }

        
        public int? BuySellIndex { get => _buySellIndex; set { _buySellIndex = value; RaisePropertyChanged("BuySellIndex"); } }

        
        public double? NextBuyPrice { get => _nextBuyPrice; set { _nextBuyPrice = value; RaisePropertyChanged("NextBuyPrice"); } }

        
        public double? NextSellPrice { get => _nextSellPrice; set { _nextSellPrice = value; RaisePropertyChanged("NextSellPrice"); } }

        
        public string NextBuyPriceOption { get => _nextBuyPriceOption; set { _nextBuyPriceOption = value; RaisePropertyChanged("NextBuyPriceOption"); } }

        
        public string NextSellPriceOption { get => _nextSellPriceOption; set { _nextSellPriceOption = value; RaisePropertyChanged("NextSellPriceOption"); } }

        
        public double? SalePrice { get => _salePrice; set { _salePrice = value; RaisePropertyChanged("SalePrice"); } }

        
        public double? SaleDate { get => _saleDate; set { _saleDate = value; RaisePropertyChanged("SaleDate"); } }

        
        public double? SaleQty { get => _saleQty; set { _saleQty = value; RaisePropertyChanged("SaleQty"); } }

        
        public double? AlgoPrice { get => _algoPrice; set { _algoPrice = value; RaisePropertyChanged("AlgoPrice"); } }

        public double? AlgoQty { get => _algoQty; set { _algoQty = value; RaisePropertyChanged("AlgoQty"); } }

        
        public bool? IsRemoveFromLevel { get => _isRemoveFromLevel; set { _isRemoveFromLevel = value; RaisePropertyChanged("IsRemoveFromLevel"); } }

        
        public string ParentId { get => _parentId; set { _parentId = value; RaisePropertyChanged("ParentId"); } }

        public string Algo { get => _algo; set { _algo = value; RaisePropertyChanged("Algo"); } }

        public double? RealizedGainLoss { get => _realizedGainLoss; set { _realizedGainLoss = value; RaisePropertyChanged("RealizedGainLoss"); } }

        public double? UnRealizedGainLoss { get => _unRealizedGainLoss; set { _unRealizedGainLoss = value; RaisePropertyChanged("UnRealizedGainLoss"); } }

        public double? TotalGainLoss { get { return RealizedGainLoss + UnRealizedGainLoss; } set { _totalGainLoss = value; RaisePropertyChanged("TotalGainLoss"); } }

        public DateTime? StartDate { get => _startDate; set { _startDate = value; RaisePropertyChanged("StartDate"); } }

        
        public string Action { get => _action; set { _action = value; RaisePropertyChanged("Action"); } }

        
        public string Fill { get => _fill; set { _fill = value; RaisePropertyChanged("Fill"); } }

        
        public string Partial { get => _partial; set { _partial = value; RaisePropertyChanged("Partial"); } }

        
        public string Stop { get => _stop; set { _stop = value; RaisePropertyChanged("Stop"); } }

        
        public double? PartialPrice { get => _pPrice; set { _pPrice = value; RaisePropertyChanged("PartialPrice"); } }

        
        public double? PartialQty { get => _pQty; set { _pQty = value; RaisePropertyChanged("PartialQty"); } }

        
        public string ChildId { get => _childId; set { _childId = value; RaisePropertyChanged("ChildId"); } }

        
        public DateTime? OrderedDate { get => _orderedDate; set { _orderedDate = value; RaisePropertyChanged("OrderedDate"); } }

        
        public string Side { get => _side; set { _side = value; RaisePropertyChanged("Side"); } }

        
        public double? GainLossAmt { get => _gainLossAmt; set { _gainLossAmt = value; RaisePropertyChanged("GainLossAmt"); } }

        
        public double? GainLossPercent { get => _gainLossPercent; set { _gainLossPercent = value; RaisePropertyChanged("GainLossPercent"); } }


        public double? MarketValue { get => _marketValue; set { _marketValue = value; RaisePropertyChanged("MarketValue"); } }

        
        public double? Cost { get => _cost; set { _cost = value; RaisePropertyChanged("Cost"); } }

        
        public double? AvgPrice { get => _avgPrice; set { _avgPrice = value; RaisePropertyChanged("AvgPrice"); } }

        public double? StartPrice { get => _startPrice; set { _startPrice = value; RaisePropertyChanged("StartPrice"); } }

        public double? ExecutedPrice { get => _executedPrice; set { _executedPrice = value; RaisePropertyChanged("ExecutedPrice"); } }

        
        public double? ExecutedQty { get => _executedQty; set { _executedQty = value; RaisePropertyChanged("ExecutedQty"); } }

        
        public string BuyOrSell
        {
            get
            {
                if (BuySellIndex == 1)
                    return "S";

                return "B";
            }
        }

        
        public string SendTo { get; set; }





    }

}
