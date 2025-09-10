using NUnitWebAutomationCSharp.Framework.Verifications;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace NUnitWebAutomationCSharp.Framework.Fields
{
    public class SelectField : BaseField<SelectField>
    {
        private const string UniversalSelectorLocatorFormat = "//select[contains(@name, '{0}')] | //select[contains(@id, '{0}')]";
        public VerifySelect Verify { get; }
        public SelectField(IWebDriver driver, IList<By> locators) : base(driver, locators)
        {
            Verify = new VerifySelect(this);
        }

        public SelectField(IWebDriver driver, string fieldName) : this(driver, 
            new List<By>{ By.XPath(string.Format(UniversalSelectorLocatorFormat, fieldName))})
        {
        }

        private SelectElement GetSelectElement()
        {
            var element = GetElement();
            var selectElement = new SelectElement(element);
            return selectElement;
        }

        public void SelectOption(string option)
        {
            var select = GetSelectElement();
            select.SelectByText(option);
        } 
        
        public void SelectOptionByIndex(int index)
        {
            var select = GetSelectElement();
            select.SelectByIndex(index);
        }

        public string GetSelectedOption()
        {
            var select = GetSelectElement();
            return select.SelectedOption.Text;
        }

    } 
}

