using System.Collections.ObjectModel;
using NUnitWebAutomationCSharp.Configuration;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Framework.Helpers
{
    public class WindowUtilities
    {
        public WindowUtilities()
        {
        }

        public string GetCurrentWindow()
        {
            return Environments.Driver.CurrentWindowHandle;
        }

        public ReadOnlyCollection<string> GetWindows()
        {
            return Environments.Driver.WindowHandles;
        }
        
        public void SwitchToNewWindow(IWebDriver driver)
        {
            string currentWindow = GetCurrentWindow();
            var wait = Waits.GetWait(driver, TimeSpan.FromSeconds(10));
            string newWindow = wait.Until(d =>
            {
                var windowHandles = GetWindows();
                return windowHandles.Count > 1 ? windowHandles.First( h => h != currentWindow) : null;
            });
            driver.SwitchTo().Window(newWindow);
        }

        public void SwitchToWindow(IWebDriver driver, string windowHandle)
        {
            driver.SwitchTo().Window(windowHandle);       
        }
    }
}
