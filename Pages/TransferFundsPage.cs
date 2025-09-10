using NUnitWebAutomationCSharp.Framework.Fields;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Pages
{
    public class TransferFundsPage : MenuPage
    {
        public TextField AmountTxt { get; } 
        public SelectField FromAccountDD { get; } 
        public SelectField ToAccountDD { get; }
        public ButtonField TransferBtn { get; }

        public TransferFundsPage()
        {
            AmountTxt = new TextField(Driver,
                new List<By> { By.XPath("//input[@id='amount']")});
            FromAccountDD = new SelectField(Driver, "fromAccount");
            ToAccountDD = new SelectField(Driver, "toAccount");
            TransferBtn = new ButtonField(Driver, "Transfer");
        }
        
        public TransferFundsPage NavigateTo()
        {
            TransferFundsLnk.Click();
            return this;       
        }
    }
}

