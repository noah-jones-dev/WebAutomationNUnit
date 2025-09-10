using NUnit.Framework;
using NUnitWebAutomationCSharp.Configuration;
using NUnitWebAutomationCSharp.Pages;

namespace NUnitWebAutomationCSharp.Tests.AccountsOverviewFeature
{
    [TestFixture]
    public class ViewAccountsOverview : Environments
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.RegisterUser();
        }

        [TestCase(Description = "Verify that a new user can successfully register their new account " +
                                "and then view their account details in Account Overview.")]
        public void NewUserViewingAccountsOverviewTest()
        {
            AccountsOverviewPage accountsOverviewPage = new AccountsOverviewPage().NavigateTo();
            accountsOverviewPage.AccountsOverviewTbl[1][1].Click();
            AccountDetailsPage accountDetailsPage = new AccountDetailsPage();
            accountDetailsPage.TitleE.Verify.TextIs("Account Details");
            accountDetailsPage.AccountNumberE.Verify.Exists();
            accountDetailsPage.AccountTypeE.Verify.Exists();
            accountDetailsPage.BalanceE.Verify.Exists();
            accountDetailsPage.AvailableE.Verify.Exists();
        }
    }
}

