
using NUnitWebAutomationCSharp.Framework.Fields;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Pages
{
    public class AccountDetailsPage : BasePage
    {
        //Title
        public StaticField TitleE { get; }
        
        //Account Detail Fields
        public StaticField AccountNumberE { get; }
        public StaticField AccountTypeE { get; }
        public StaticField BalanceE { get; }
        public StaticField AvailableE { get; }
        
        //Account Activity Fields
        public SelectField ActivityPeriodDD { get; }
        public SelectField TypeDD { get; }
        
        public AccountDetailsPage()
        {
            TitleE = new StaticField(Driver, 
                new List<By>{By.XPath("//*[@class='title'][text()='Account Details']")});
            AccountNumberE = new StaticField(Driver, new List<By>{By.XPath("//*[@id='accountId']")});
            AccountTypeE = new StaticField(Driver, new List<By>{By.XPath("//*[@id='accountType']")});
            BalanceE = new StaticField(Driver, new List<By>{By.XPath("//*[@id='balance']")});
            AvailableE = new StaticField(Driver, new List<By>{By.XPath("//*[@id='availableBalance']")});
            ActivityPeriodDD = new SelectField(Driver, "month");
            TypeDD = new SelectField(Driver, "transactionType");
        }
    }
}

