using NUnit.Framework;
using NUnitWebAutomationCSharp.Configuration;
using NUnitWebAutomationCSharp.Pages;

namespace NUnitWebAutomationCSharp.Tests.TransferFundsFeature
{
    [TestFixture]
    public class TransferFundsWithNewAccount : Environments
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            LoginPage loginPage = new LoginPage();
            loginPage.RegisterUser();
        }

        [TestCase(Description = "Verify that a new user can successfully open a new account and transfer funds to it.")]
        public void NewUserTransferFundsTest()
        {
            OpenNewAccountPage openNewAccountPage = new OpenNewAccountPage().NavigateTo();
            openNewAccountPage.TypeOfAccountDD.SelectOptionByIndex(1);
            openNewAccountPage.OpenNewAccountBtn.Click();
            TransferFundsPage transferFundsPage = new TransferFundsPage().NavigateTo();
            string transferAmount = "100";
            transferFundsPage.AmountTxt.Enter(transferAmount);
            transferFundsPage.FromAccountDD.SelectOptionByIndex(0);
            transferFundsPage.ToAccountDD.SelectOptionByIndex(1);
            string fromAccountNum = transferFundsPage.FromAccountDD.GetSelectedOption();
            string toAccountNum = transferFundsPage.ToAccountDD.GetSelectedOption();
            transferFundsPage.TransferBtn.Click();
            TransferCompletePage transferCompletePage = new TransferCompletePage();
            Assert.Multiple(() =>
            {
                transferCompletePage.CompletionMessageE.Verify.TextIs("Transfer Complete!");
                transferCompletePage.TransferMessageE.Verify
                    .TextIs($"${transferAmount}.00 has been transferred from account #{fromAccountNum} to account #{toAccountNum}.");
                transferCompletePage.AdditionalDetailsMessageE.Verify
                    .TextIs("See Account Activity for more details.");
            });
        }
    }
}

