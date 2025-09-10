using NUnitWebAutomationCSharp.Configuration;
using NUnitWebAutomationCSharp.Framework.Fields;
using NUnitWebAutomationCSharp.Framework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace NUnitWebAutomationCSharp.Pages
{
    public abstract class BasePage
    {
        protected IWebDriver Driver { get; }
        protected WebDriverWait Wait { get; }
        protected Actions Actions { get; }

        protected BasePage()
        {
            Driver = Environments.Driver;
            Wait = Waits.GetWait(Driver, TimeSpan.FromSeconds(10));
            Actions = new Actions(Driver);
        }

        public void ScrollBy(string direction, int amount=1000)
        {
            switch (direction.ToLower())
            {
                case "up":
                    Driver.ExecuteJavaScript($"window.scrollBy(0, -{amount});");
                    break;
                case "down":
                    Driver.ExecuteJavaScript($"window.scrollBy(0, {amount});");
                    break;
                case "left":
                    Driver.ExecuteJavaScript($"window.scrollBy(-{amount}, 0);");
                    break;
                case "right":
                    Driver.ExecuteJavaScript($"window.scrollBy({amount}, 0);");
                    break;
            }
        }
        
    }
}

