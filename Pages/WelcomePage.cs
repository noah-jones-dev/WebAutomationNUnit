using NUnitWebAutomationCSharp.Framework.Fields;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Pages
{
    public class WelcomePage : BasePage
    {
        public StaticField WelcomeE { get; }
        public WelcomePage()
        {
            WelcomeE = new StaticField(Driver, 
                new List<By>{By.XPath("//div[@id='rightPanel']/h1[contains(text(), 'Welcome')]/following-sibling::p")});
        }    
    }
}

