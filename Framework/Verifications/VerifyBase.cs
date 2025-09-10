using NUnit.Framework;
using NUnitWebAutomationCSharp.Framework.Fields;
using OpenQA.Selenium;

namespace NUnitWebAutomationCSharp.Framework.Verifications
{
    public abstract class VerifyBase<TField> where TField : BaseField<TField>
    {
        protected BaseField<TField> field;
        public VerifyBase(TField field)
        {
            this.field = field;
        }

        public void Exists()
        {
            var element = field.GetElement();
            Assert.That(element, Is.Not.Null);
        }
        
        public void NotExists()
        {
            var element = field.GetElement();
            Assert.That(element, Is.Null);
        }
    }
}

