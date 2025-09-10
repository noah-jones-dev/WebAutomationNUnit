using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitWebAutomationCSharp.Framework.Helpers;

public static class Waits
{
    public static WebDriverWait GetWait(IWebDriver driver, TimeSpan timeout)
    {
        return new WebDriverWait(driver, timeout);
    }
    
    
}