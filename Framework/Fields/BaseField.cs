using System.Collections.ObjectModel;
using NUnitWebAutomationCSharp.Framework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitWebAutomationCSharp.Framework.Fields
{
    public abstract class BaseField<TSelf> where TSelf : BaseField<TSelf>
    {
        protected IWebDriver Driver { get; }
        protected IList<By> Locators { get; set; }
        protected WebDriverWait Wait { get; }
        
        public BaseField(IWebDriver driver, IList<By> locators)
        {
            Driver = driver;
            Locators = locators;
            Wait = Waits.GetWait(Driver, TimeSpan.FromSeconds(10));
        }

        private IWebElement ElementFromDriver(By locator)
        {
            var element = Wait.Until(driver =>
            {
                try
                {
                    var element = driver.FindElement(locator);
                    return element.Displayed ? element : null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
            return element;
        }
        
        
        private IWebElement ElementFromContext(IWebElement context, By locator)
        {
            var element = Wait.Until(_ =>
            {
                try
                {
                    var element = context.FindElement(locator);
                    return element.Displayed ? element : null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
            return element;
        }

        private ReadOnlyCollection<IWebElement> ElementsFromDriver(By locator)
        {
            var elements = Wait.Until(driver =>
            {
                var elements = driver.FindElements(locator);
                if (elements.Count == 0)
                {
                    return null;
                }
                foreach (var element in elements)
                {
                    if (!element.Displayed)
                    {
                        return null;
                    }
                }
                return elements;
            });
            return elements;
        }
        
        private ReadOnlyCollection<IWebElement> ElementsFromContext(IWebElement context, By locator)
        {
            var elements = Wait.Until(_ =>
            {
                var elements = context.FindElements(locator);
                if (elements.Count == 0)
                {
                    return null;
                }
                foreach (var element in elements)
                {
                    if (!element.Displayed)
                    {
                        return null;
                    }
                }
                return elements;
            });
            return elements;
        }
        
        public IWebElement GetElement()
        {
            IWebElement contextElement = null;
            foreach (var locator in Locators)
            {
                if (contextElement is null)
                {
                    // First locator: search from the Driver (whole page context)
                    contextElement = ElementFromDriver(locator);
                }
                else
                {
                    // Subsequent locators: search relative to the previously found element
                    contextElement = ElementFromContext(contextElement, locator);
                }
            }
            return contextElement;
        }

        
        public ReadOnlyCollection<IWebElement> GetElements()
        {
            ReadOnlyCollection<IWebElement> contextElements = null;
            
            foreach (var locator in Locators)
            {
                if (contextElements is null)
                {
                    contextElements = ElementsFromDriver(locator);
                }
                else
                {
                    contextElements = ElementsFromContext(contextElements.First(), locator);
                }
            }
            return contextElements;
        }

        
        public IWebElement Expose()
        {
            if (Locators.Count > 1)
            {
                foreach (var locator in Locators)
                {
                    if (locator == Locators.Last())
                    {
                        break;
                    }
                    try
                    {
                        Wait.Until(driver =>
                        {
                            var element = driver.FindElement(locator);
                            return element != null && element.Displayed ? element : null;
                        }).Click();
                    }
                    catch (NoSuchElementException exception)
                    {
                        Console.WriteLine($"Failed to click {locator}: {exception}");
                    }
                }
            }
            return Wait.Until(driver =>
            {
                return driver.FindElement(Locators.Last());
            });
        }
        
        public TSelf ScrollTo(IWebElement element = null)
        {
            if (element == null)
            {
                element = GetElement();
            }
            ((IJavaScriptExecutor)Driver).ExecuteScript("arguments[0].scrollIntoView();", element);
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(driver =>
                (bool)((IJavaScriptExecutor)driver).ExecuteScript(@"
                var elem = arguments[0];
                var rect = elem.getBoundingClientRect();
                return (rect.top >= 0 && rect.bottom <= (window.innerHeight || document.documentElement.clientHeight));
                ", element)
                );
            return (TSelf)this;
        }

        public bool Visible()
        {
            return GetElement().Displayed;       
        }
    }
}
