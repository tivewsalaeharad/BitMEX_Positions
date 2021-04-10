using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitMEX_Positions
{
    class PositionItem
    {
        public int account { get; set; }
        public string symbol { get; set; }
        public string currency { get; set; }
        public string underlying { get; set; }
        public string quoteCurrency { get; set; }
        public double commission { get; set; }
        public double initMarginReq { get; set; }
        public double maintMarginReq { get; set; }
        public object riskLimit { get; set; }
        public int leverage { get; set; }
        public bool crossMargin { get; set; }
        public double deleveragePercentile { get; set; }
        public int rebalancedPnl { get; set; }
        public int prevRealisedPnl { get; set; }
        public int prevUnrealisedPnl { get; set; }
        public double prevClosePrice { get; set; }
        public DateTime openingTimestamp { get; set; }
        public int openingQty { get; set; }
        public int openingCost { get; set; }
        public int openingComm { get; set; }
        public int openOrderBuyQty { get; set; }
        public int openOrderBuyCost { get; set; }
        public int openOrderBuyPremium { get; set; }
        public int openOrderSellQty { get; set; }
        public int openOrderSellCost { get; set; }
        public int openOrderSellPremium { get; set; }
        public int execBuyQty { get; set; }
        public int execBuyCost { get; set; }
        public int execSellQty { get; set; }
        public int execSellCost { get; set; }
        public int execQty { get; set; }
        public int execCost { get; set; }
        public int execComm { get; set; }
        public DateTime currentTimestamp { get; set; }
        public int currentQty { get; set; }
        public int currentCost { get; set; }
        public int currentComm { get; set; }
        public int realisedCost { get; set; }
        public int unrealisedCost { get; set; }
        public int grossOpenCost { get; set; }
        public int grossOpenPremium { get; set; }
        public int grossExecCost { get; set; }
        public bool isOpen { get; set; }
        public double markPrice { get; set; }
        public int markValue { get; set; }
        public int riskValue { get; set; }
        public double homeNotional { get; set; }
        public double foreignNotional { get; set; }
        public string posState { get; set; }
        public int posCost { get; set; }
        public int posCost2 { get; set; }
        public int posCross { get; set; }
        public int posInit { get; set; }
        public int posComm { get; set; }
        public int posLoss { get; set; }
        public int posMargin { get; set; }
        public int posMaint { get; set; }
        public int posAllowance { get; set; }
        public int taxableMargin { get; set; }
        public int initMargin { get; set; }
        public int maintMargin { get; set; }
        public int sessionMargin { get; set; }
        public int targetExcessMargin { get; set; }
        public int varMargin { get; set; }
        public int realisedGrossPnl { get; set; }
        public int realisedTax { get; set; }
        public int realisedPnl { get; set; }
        public int unrealisedGrossPnl { get; set; }
        public int longBankrupt { get; set; }
        public int shortBankrupt { get; set; }
        public int taxBase { get; set; }
        public object indicativeTaxRate { get; set; }
        public int indicativeTax { get; set; }
        public int unrealisedTax { get; set; }
        public int unrealisedPnl { get; set; }
        public double unrealisedPnlPcnt { get; set; }
        public double unrealisedRoePcnt { get; set; }
        public object simpleQty { get; set; }
        public object simpleCost { get; set; }
        public object simpleValue { get; set; }
        public object simplePnl { get; set; }
        public object simplePnlPcnt { get; set; }
        public double avgCostPrice { get; set; }
        public double avgEntryPrice { get; set; }
        public double breakEvenPrice { get; set; }
        public double marginCallPrice { get; set; }
        public double liquidationPrice { get; set; }
        public double bankruptPrice { get; set; }
        public DateTime timestamp { get; set; }
        public double lastPrice { get; set; }
        public int lastValue { get; set; }

    }
}
