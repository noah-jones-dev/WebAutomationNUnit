using NUnitWebAutomationCSharp.Framework.Fields;

namespace NUnitWebAutomationCSharp.Pages
{
    public class OpenNewAccountPage : MenuPage
    {
        public SelectField TypeOfAccountDD { get; }
        public SelectField TransferFromAccountDD { get; }
        public ButtonField OpenNewAccountBtn { get; }

        public OpenNewAccountPage()
        {
            TypeOfAccountDD = new SelectField(Driver, "type");
            TransferFromAccountDD  = new SelectField(Driver, "fromAccount");
            OpenNewAccountBtn = new ButtonField(Driver, "Open New Account");
        }
        
        public OpenNewAccountPage NavigateTo()
        {
            OpenNewAccountLnk.Click();
            return this;       
        }
    }
}

