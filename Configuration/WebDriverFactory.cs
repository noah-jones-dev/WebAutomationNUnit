using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace NUnitWebAutomationCSharp.Configuration
{
    public static class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver(BrowserTypes browser)
        {
            IWebDriver driver;
            switch (browser)
            {
                case BrowserTypes.Firefox:
                    var firefoxOptions = new FirefoxOptions();
                    var firefoxService = FirefoxDriverService.CreateDefaultService();
                    driver =  new FirefoxDriver(firefoxService, firefoxOptions);
                    break;
                case BrowserTypes.Edge:
                    var edgeOptions = new EdgeOptions();
                    var edgeService = EdgeDriverService.CreateDefaultService();
                    driver = new EdgeDriver(edgeService, edgeOptions);
                    break;
                default:
                    var chromeOptions = new ChromeOptions();
                    var chromeService = ChromeDriverService.CreateDefaultService();
                    driver = new ChromeDriver(chromeService, chromeOptions);
                    break;
            }
            return driver;
        }
    }
}

