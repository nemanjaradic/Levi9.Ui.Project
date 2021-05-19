using Levi9.Ui.Project.Common;
using Levi9.Ui.Project.Pages;
using Levi9.Ui.Project.Tests.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Levi9.Ui.Project.Tests
{
    [TestClass]
    public class LoginTests : BaseTest
    {
        private LoginPage loginPage;
        private HomePage homePage;

        [TestMethod]
        public void StandardUserIsAbleToLoginAndLogOut()
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);

            driver.Navigate().GoToUrl(Constants.baseUrl);
            //login
            loginPage.PerformLogin(Constants.standardUser, Constants.password);
            Assert.IsTrue(homePage.ShoppingCartButton.Displayed);
            //logout
            homePage.MenuButton.Click();
            homePage.LogOutButton.Click();
            Assert.IsTrue(loginPage.UserNameTextBox.Displayed);
            Assert.IsTrue(loginPage.PasswordTextBox.Displayed);
            Assert.IsTrue(loginPage.LoginButton.Displayed);
        }

        [TestMethod]
        public void NonExistingUsernameThrowsErrorMessage()
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);

            driver.Navigate().GoToUrl(Constants.baseUrl);
            loginPage.PerformLogin("pogresni password", Constants.password);

            Assert.IsTrue(loginPage.ErrorTextMessage.Displayed);
            Assert.AreEqual(loginPage.ErrorTextMessage.Text, "Epic sadface: Username and password do not match any user in this service");
        }

        [TestMethod]
        public void ThisTestWillFailAndCreateScreenShot()
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);

            driver.Navigate().GoToUrl(Constants.baseUrl);
            loginPage.PerformLogin("pogresni password", Constants.password);

            Assert.IsTrue(homePage.ShoppingCartButton.Displayed);
            Assert.IsTrue(homePage.AddToCartBackPack.Displayed);
            Assert.IsTrue(homePage.AddToCartBikeLight.Displayed);
        }
    }
}