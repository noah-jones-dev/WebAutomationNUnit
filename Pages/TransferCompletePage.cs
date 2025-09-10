using NUnitWebAutomationCSharp.Framework.Fields;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Pages
{
    public class TransferCompletePage : BasePage
    {
        public StaticField CompletionMessageE { get; }
        public StaticField TransferMessageE { get; }
        public StaticField AdditionalDetailsMessageE { get; }

        public TransferCompletePage()
        {
            CompletionMessageE = new StaticField(Driver, new List<By> { By.XPath("//div[@id='showResult']/h1[@class='title']") });
            TransferMessageE = new StaticField(Driver, new List<By> { By.XPath("//div[@id='showResult']/p[./span]") });
            AdditionalDetailsMessageE = new StaticField(Driver, new List<By> { By.XPath("//div[@id='showResult']/p[not(./span)]") });       
        }
    }
}

