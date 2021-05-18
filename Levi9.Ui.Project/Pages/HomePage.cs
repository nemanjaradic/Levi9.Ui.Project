using Levi9.Ui.Project.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levi9.Ui.Project.Pages
{
    public class HomePage
    {
        private static By menuButtonElement = By.Id("react-burger-menu-btn");
        private static By logOutButtonElement = By.Id("logout_sidebar_link");
        private static By closeMenuButtonElement = By.Id("react-burger-cross-btn");
        private static By shoppingCartButtonElement = By.Id("shopping_cart_container");
        private static By addToCartBackPackElement = By.XPath("//*[@id='add-to-cart-sauce-labs-backpack']");
        private static By addToCartBikeLightElement = By.XPath("//*[@id='add-to-cart-sauce-labs-bike-light']");
        private static By addToCartBoltTShirtElement = By.XPath("//*[@id='add-to-cart-sauce-labs-bolt-t-shirt']");
        private static By addToCartFleeceJacketElement = By.XPath("//*[@id='add-to-cart-sauce-labs-fleece-jacket']");
        private static By addToCartOnesieShirtElement = By.XPath("//*[@id='add-to-cart-sauce-labs-onesie']");
        private static By addToCartTestAllTShirtElement = By.Id("add-to-cart-test.allthethings()-t-shirt-(red)");

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
    }
}