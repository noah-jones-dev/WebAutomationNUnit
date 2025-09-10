using NUnitWebAutomationCSharp.Configuration;
using NUnitWebAutomationCSharp.Framework.Fields;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Pages
{
    public class AccountsOverviewPage : MenuPage
    {
        public StaticField TitleE { get; }
        public LinkField AccountLnk { get; }
        public StaticField BalanceE { get; }
        public StaticField AvailableAmountE { get; }
        public TableField AccountsOverviewTbl { get; }
        public AccountsOverviewPage()
        {
            TitleE = new StaticField(Driver, new List<By>{By.XPath("//div[@id='showOverview']/h1[@class='title']")});
            AccountLnk = new LinkField(Driver, MenuTypes.MiddleRight, "activity");
            BalanceE = new StaticField(Driver, new List<By>{By.XPath("")});
            AvailableAmountE = new StaticField(Driver, new List<By>{By.XPath("")});
            AccountsOverviewTbl = new TableField(Driver, "accountTable");
        }
        
        public AccountsOverviewPage NavigateTo()
        {
            AccountsOverviewLnk.Click();
            return this;       
        }
        
    }
}
