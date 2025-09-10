using NUnit.Framework;
using NUnitWebAutomationCSharp.Configuration;
using NUnitWebAutomationCSharp.Pages;

namespace NUnitWebAutomationCSharp.Tests.LoginFeature
{
    [TestFixture]
    public class LoginExistingUser : Environments
    {
        [TestCase(Description = "Verify that an existing user can successfully login to their existing account.")]
        public void LoginExistingUserTest()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.LoginUser("JimmyF123", "PASSWORD###");
            AccountsOverviewPage accountsOverview = new AccountsOverviewPage();
            accountsOverview.TitleE.Verify.TextIs("Accounts Overview");
        }
    }
}
