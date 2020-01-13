using System;
using AutomationResources.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyStoreTests
{
    [TestClass]
    public class SignInTests : BaseTest
    {
        [TestMethod]
        [Description("")]
        [TestProperty("Author", "NenadRakic")]
        public void TCID2()
        {
            HomePage homepage = new HomePage(Driver);
            homepage.GoTo();

            SignInPage signInPage = homepage.SignIn();
            Assert.IsTrue(signInPage.IsVisible, $"Sample application page was not visible. Expected => {signInPage.PageTitle}" + $"Actual=>{Driver.Title}");

            FacebookPage facebookPage = signInPage.goToFacebookPage();
            facebookPage.SwitchTabs(1);

            Assert.IsTrue(facebookPage.IsVisible, $"Sample application page was not visible. Expected => {facebookPage.PageTitle}" + $"Actual=>{Driver.Title}");

            facebookPage.SwitchTabs(0);
            Assert.IsTrue(signInPage.IsVisible, $"Sample application page was not visible. Expected => {signInPage.PageTitle}" + $"Actual=>{Driver.Title}");

        }
    }
}
