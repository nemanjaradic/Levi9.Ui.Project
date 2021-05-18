using Levi9.Ui.Project.Common;
using OpenQA.Selenium;

namespace Levi9.Ui.Project.Pages
{
    public class HomePage
    {
        private By menuButtonElement = By.Id("react-burger-menu-btn");
        private By resetAppStateButtonElement = By.Id("reset_sidebar_link");
        private By logOutButtonElement = By.Id("logout_sidebar_link");
        private By closeMenuButtonElement = By.Id("react-burger-cross-btn");
        private By shoppingCartButtonElement = By.Id("shopping_cart_container");
        private By shoppingCartBadgeIconElement = By.XPath("//*[@id='shopping_cart_container']/a/span");
        private By addToCartBackPackElement = By.XPath("//*[@id='add-to-cart-sauce-labs-backpack']");
        private By addToCartBikeLightElement = By.XPath("//*[@id='add-to-cart-sauce-labs-bike-light']");
        private By addToCartBoltTShirtElement = By.XPath("//*[@id='add-to-cart-sauce-labs-bolt-t-shirt']");
        private By addToCartFleeceJacketElement = By.XPath("//*[@id='add-to-cart-sauce-labs-fleece-jacket']");
        private By addToCartOnesieShirtElement = By.XPath("//*[@id='add-to-cart-sauce-labs-onesie']");
        private By addToCartTestAllTShirtElement = By.Id("add-to-cart-test.allthethings()-t-shirt-(red)");
        private By sortDropdownSelectElement = By.ClassName("product_sort_container");

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement MenuButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, menuButtonElement, 5);
                return driver.FindElement(menuButtonElement);
            }
        }

        public IWebElement ResetAppStateButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, resetAppStateButtonElement, 5);
                return driver.FindElement(resetAppStateButtonElement);
            }
        }

        public IWebElement LogOutButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, logOutButtonElement, 5);
                return driver.FindElement(logOutButtonElement);
            }
        }

        public IWebElement CloseMenuButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, closeMenuButtonElement, 5);
                return driver.FindElement(closeMenuButtonElement);
            }
        }

        public IWebElement ShoppingCartButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, shoppingCartButtonElement, 5);
                return driver.FindElement(shoppingCartButtonElement);
            }
        }

        public IWebElement ShoppingCartBadgeIcon
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, shoppingCartBadgeIconElement, 5);
                return driver.FindElement(shoppingCartBadgeIconElement);
            }
        }

        public IWebElement AddToCartBackPack
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, addToCartBackPackElement, 5);
                return driver.FindElement(addToCartBackPackElement);
            }
        }

        public IWebElement AddToCartBikeLight
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, addToCartBikeLightElement, 5);
                return driver.FindElement(addToCartBikeLightElement);
            }
        }

        public IWebElement AddToCartBoltTShirt
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, addToCartBoltTShirtElement, 5);
                return driver.FindElement(addToCartBoltTShirtElement);
            }
        }

        public IWebElement AddToCartFleeceJacket
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, addToCartFleeceJacketElement, 5);
                return driver.FindElement(addToCartFleeceJacketElement);
            }
        }

        public IWebElement GetaddToCartOnesieShirt()
        {
            WaitHelper.WaitUntilElementIsVisible(driver, addToCartOnesieShirtElement, 5);
            return driver.FindElement(addToCartOnesieShirtElement);
        }

        public IWebElement AddToCartTestAllTShirt
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, addToCartTestAllTShirtElement, 5);
                return driver.FindElement(addToCartTestAllTShirtElement);
            }
        }

        public IWebElement SortDropdownSelect
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, sortDropdownSelectElement, 5);
                return driver.FindElement(sortDropdownSelectElement);
            }
        }
    }
}