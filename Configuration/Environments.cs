using NUnit.Framework;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Configuration
{
    [SetUpFixture]
    public class Environments
    {
        public static IWebDriver Driver { get; private set; }
    
        [OneTimeSetUp]
        public void GlobalSetup()
        {
            Driver = WebDriverFactory.CreateWebDriver(BrowserTypes.Chrome);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/overview.htm");
        }

        [OneTimeTearDown]
        public void GlobalTearDown()
        {
            Driver.Quit();
        }
    }
}


    
    


