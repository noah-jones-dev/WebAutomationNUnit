using NUnitWebAutomationCSharp.Configuration;
using NUnitWebAutomationCSharp.Framework.Fields;

namespace NUnitWebAutomationCSharp.Pages
{
    public class HomePage : MenuPage
    {
        //ATM Services Panel Fields
        public LinkField WithdrawFundsLnk { get; }
        public LinkField CheckBalancesLnk { get; }
        public LinkField MakeDepositsLnk { get; }
        
        //Online Services Panel Fields
        public override LinkField BillPayLnk { get; }
        public LinkField AccountHistoryLnk { get; }
        public override LinkField TransferFundsLnk { get; }
        
        //News Panel Fields
        public LinkField LatestNewsLnk { get; }
        public LinkField ReadMoreLnk { get; }

        public HomePage()
        {
            //ATM Services Panel Fields
            WithdrawFundsLnk = new LinkField(Driver, MenuTypes.MiddleRight, "Withdraw Funds");
            CheckBalancesLnk = new LinkField(Driver, MenuTypes.MiddleRight, "Check Balances");
            MakeDepositsLnk = new LinkField(Driver, MenuTypes.MiddleRight, "Make Deposits");

            //Online Services Panel Fields
            BillPayLnk = new  LinkField(Driver, MenuTypes.MiddleRight, "Bill Pay");
            AccountHistoryLnk = new LinkField(Driver, MenuTypes.MiddleRight, "Account History");
            TransferFundsLnk = new  LinkField(Driver, MenuTypes.MiddleRight, "Transfer Funds");
            
            //News Panel Fields
            LatestNewsLnk = new LinkField(Driver, MenuTypes.MiddleRight, "New");
            ReadMoreLnk =  new  LinkField(Driver, MenuTypes.MiddleRight, "Read More");
        }
        
        public HomePage NavigateTo()
        {
            HomeLnk.Click();
            return this;       
        }
    }
}

