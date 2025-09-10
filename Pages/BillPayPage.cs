using NUnitWebAutomationCSharp.Framework.Fields;

namespace NUnitWebAutomationCSharp.Pages
{
    public class BillPayPage : MenuPage
    {
        public TextField PayeeNameTxt { get; }
        public TextField AddressTxt { get; }
        public TextField CityTxt { get; }
        public TextField StateTxt { get; }
        public TextField ZipCodeTxt { get; }
        public TextField PhoneNumberTxt { get; }
        public TextField AccountNumberTxt { get; }
        public TextField VerifyAccountNumberTxt { get; }
        public TextField AmountNumberTxt { get; }
        public TextField FromAccountNumberDD { get; }

        public BillPayPage()
        {
            
        }
        
        public BillPayPage NavigateTo()
        {
            BillPayLnk.Click();
            return this;       
        }
    }
}

