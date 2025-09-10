using NUnitWebAutomationCSharp.Configuration;
using NUnitWebAutomationCSharp.Framework.Fields;

namespace NUnitWebAutomationCSharp.Pages
{
    public class MenuPage : BasePage
    {
        //Top Panel
        public LinkField SolutionsLnk { get; }
        public LinkField AboutUsLnk { get; }
        public LinkField ServicesLnk { get; }
        public LinkField ProductsLnk { get; }
        public LinkField LocationsLnk { get; }
        public LinkField AdminPageLnk { get; }
        
        //Left Panel
        public LinkField OpenNewAccountLnk { get; }
        public LinkField AccountsOverviewLnk { get; }
        public virtual LinkField TransferFundsLnk { get; }
        public virtual LinkField BillPayLnk { get; }
        public LinkField FindTransactionsLnk { get; }
        public LinkField UpdateContactInfoLnk { get; }
        public LinkField RequestLoanLnk { get; }
        public LinkField LogOutLnk { get; }
        
        //Bottom Panel
        public LinkField HomeLnk { get; }
        public LinkField ForumLnk { get; }
        public LinkField SiteMapLnk { get; }
        public LinkField ContactUsLnk { get; }

            
        public MenuPage()
        {
            //Top Panel
            SolutionsLnk = new LinkField(Driver, MenuTypes.Top, "Solutions");
            AboutUsLnk = new LinkField(Driver, MenuTypes.Top, "About Us");
            ServicesLnk = new LinkField(Driver, MenuTypes.Top, "Services");
            ProductsLnk = new LinkField(Driver, MenuTypes.Top, "Products");
            LocationsLnk = new LinkField(Driver, MenuTypes.Top, "Locations");
            AdminPageLnk = new LinkField(Driver, MenuTypes.Top, "Admin Page");
            
            //Left Panel
            OpenNewAccountLnk =  new LinkField(Driver, MenuTypes.MiddleLeft, "Open New Account");
            AccountsOverviewLnk =  new LinkField(Driver, MenuTypes.MiddleLeft, "Accounts Overview");
            TransferFundsLnk =  new LinkField(Driver, MenuTypes.MiddleLeft, "Transfer Funds");
            BillPayLnk =  new LinkField(Driver, MenuTypes.MiddleLeft, "Bill Pay");
            FindTransactionsLnk =  new LinkField(Driver, MenuTypes.MiddleLeft, "Find Transactions");
            UpdateContactInfoLnk =  new LinkField(Driver, MenuTypes.MiddleLeft, "Update Contact Info");
            RequestLoanLnk =  new LinkField(Driver, MenuTypes.MiddleLeft, "Request Loan");
            LogOutLnk =  new LinkField(Driver, MenuTypes.MiddleLeft, "Log Out");
            
            //Bottom Panel
            HomeLnk = new LinkField(Driver, MenuTypes.Bottom, "Home");
            ForumLnk = new LinkField(Driver, MenuTypes.Bottom, "Forum");
            SiteMapLnk = new LinkField(Driver, MenuTypes.Bottom, "Site Map");
            ContactUsLnk = new LinkField(Driver, MenuTypes.Bottom, "Contact Us");
        }
        
    }
}
