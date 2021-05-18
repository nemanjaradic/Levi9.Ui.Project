using Levi9.Ui.Project.Common;
using Levi9.Ui.Project.Pages;
using Levi9.Ui.Project.Tests.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace Levi9.Ui.Project.Tests
{
    [TestClass]
    public class CreateOrderTests : BaseTest
    {
        private LoginPage loginPage;
        private HomePage homePage;
        private ShopingCartPage shopingCart;
        private WebDriverWait wait;

        [TestMethod]
        public void StandardUserIsAbleToCreateOrder()
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            shopingCart = new ShopingCartPage(driver);

            //Navigate and login
            driver.Navigate().GoToUrl(Constants.baseUrl);
            loginPage.PerformLogin(Constants.username, Constants.password);
            //reset app state
            homePage.MenuButton.Click();
            homePage.ResetAppStateButton.Click();
            homePage.CloseMenuButton.Click();
            //add items to shopping cart
            homePage.AddToCartBackPack.Click();
            homePage.AddToCartBikeLight.Click();
            homePage.AddToCartBoltTShirt.Click();
            homePage.AddToCartFleeceJacket.Click();
            Assert.AreEqual("4", homePage.ShoppingCartBadgeIcon.Text);

            homePage.ShoppingCartButton.Click();
            shopingCart.RemoveFromCartBackPack.Click();
            Assert.AreEqual("3", homePage.ShoppingCartBadgeIcon.Text);

            shopingCart.CheckoutOrderButton.Click();
            shopingCart.FirstNameTexBox.SendKeys("Nemanja");
            shopingCart.LastNameTexBox.SendKeys("Radic");
            shopingCart.PostalCodeTexBox.SendKeys("23000");

            shopingCart.ContinueCheckoutButton.Click();
            shopingCart.FinishOrdertButton.Click();
            Assert.AreEqual("THANK YOU FOR YOUR ORDER", shopingCart.ThankYouMessage.Text);
            Assert.IsTrue(shopingCart.BackToHomeButton.Displayed);

            homePage.MenuButton.Click();
            homePage.LogOutButton.Click();
            Assert.IsTrue(loginPage.UserNameTextBox.Displayed);
            Assert.IsTrue(loginPage.PasswordTextBox.Displayed);
            Assert.IsTrue(loginPage.LoginButton.Displayed);
        }

        [TestMethod]
        public void SortingOfProductsIsEnabledByName()
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            shopingCart = new ShopingCartPage(driver);

            //Navigate and login
            driver.Navigate().GoToUrl(Constants.baseUrl);
            loginPage.PerformLogin(Constants.username, Constants.password);

            var select = new SelectElement(homePage.SortDropdownSelect);
            select.SelectByValue("za");  //Name (Z to A)

            homePage.MenuButton.Click();
            homePage.LogOutButton.Click();
            Assert.IsTrue(loginPage.UserNameTextBox.Displayed);
            Assert.IsTrue(loginPage.PasswordTextBox.Displayed);
            Assert.IsTrue(loginPage.LoginButton.Displayed);
        }

        [TestMethod]
        public void SortingOfProductsIsEnabledByPrice()
        {
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            shopingCart = new ShopingCartPage(driver);

            //Navigate and login
            driver.Navigate().GoToUrl(Constants.baseUrl);
            loginPage.PerformLogin(Constants.username, Constants.password);

            var select = new SelectElement(homePage.SortDropdownSelect);
            select.SelectByValue("lohi");  //Price (low to high)

            homePage.MenuButton.Click();
            homePage.LogOutButton.Click();
            Assert.IsTrue(loginPage.UserNameTextBox.Displayed);
            Assert.IsTrue(loginPage.PasswordTextBox.Displayed);
            Assert.IsTrue(loginPage.LoginButton.Displayed);
        }
    }
}