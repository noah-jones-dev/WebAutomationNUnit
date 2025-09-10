using NUnit.Framework;
using NUnitWebAutomationCSharp.Configuration;
using NUnitWebAutomationCSharp.Pages;

namespace NUnitWebAutomationCSharp.Tests.LoginFeature
{
   [TestFixture]
    public class RegisterNewUser : Environments
    {
        [TestCase(Description = "Verify that a new user can successfully register and login to their new account.")]
        public void RegisterNewUserTest()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.RegisterUser();
            WelcomePage welcomePage = new WelcomePage();
            welcomePage.WelcomeE.Verify.TextIs("Your account was created successfully. You are now logged in.");
        }
    } 
}
