using Levi9.Ui.Project.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levi9.Ui.Project.Pages
{
    public class ShopingCartPage
    {
        private By removeFromCartBackPackElement = By.Id("remove-sauce-labs-backpack");
        private By removeFromCartBikeLightElement = By.Id("remove-sauce-labs-bike-light");
        private By removeFromCartBoltTShirtElement = By.Id("remove-sauce-labs-bolt-t-shirt");
        private By removeFromCartFleeceJacketElement = By.Id("remove-sauce-labs-fleece-jacket");
        private By removeFromCartOnesieShirtElement = By.Id("remove-sauce-labs-onesie");
        private By removeFromCartTestAllTShirtElement = By.Id("remove-test.allthethings()-t-shirt-(red)");

        private By checkoutOrderButtonElement = By.Id("checkout");
        private By continueShoppingButtonElement = By.Id("continue-shopping"); //first-name

        private By firstNameTexBoxElement = By.Id("first-name");
        private By lastNameTexBoxElement = By.Id("last-name");
        private By postalCodeTexBoxElement = By.Id("postal-code");

        private By cancelCheckoutButtonElement = By.Id("cancel");
        private By continueCheckoutButtonElement = By.Id("continue");
        private By finishOrdertButtonElement = By.Id("finish");

        private By thankYouMessageElement = By.XPath("//*[@id='checkout_complete_container']/h2");
        private By backToHomeButtonElement = By.Id("back-to-products");

        //cancel continue
        private IWebDriver driver;

        public ShopingCartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement RemoveFromCartBackPack
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, removeFromCartBackPackElement, 5);
                return driver.FindElement(removeFromCartBackPackElement);
            }
        }

        public IWebElement RemoveFromCartBikeLight
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, removeFromCartBikeLightElement, 5);
                return driver.FindElement(removeFromCartBikeLightElement);
            }
        }

        public IWebElement RemoveFromCartBoltTShirt
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, removeFromCartBoltTShirtElement, 5);
                return driver.FindElement(removeFromCartBoltTShirtElement);
            }
        }

        public IWebElement RemoveFromCartFleeceJacket
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, removeFromCartFleeceJacketElement, 5);
                return driver.FindElement(removeFromCartFleeceJacketElement);
            }
        }

        public IWebElement RemoveFromCartOnesieShirt
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, removeFromCartOnesieShirtElement, 5);
                return driver.FindElement(removeFromCartOnesieShirtElement);
            }
        }

        public IWebElement RemoveFromCartTestAllTShirt
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, removeFromCartTestAllTShirtElement, 5);
                return driver.FindElement(removeFromCartTestAllTShirtElement);
            }
        }

        public IWebElement CheckoutOrderButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, checkoutOrderButtonElement, 5);
                return driver.FindElement(checkoutOrderButtonElement);
            }
        }

        public IWebElement ContinueShoppingButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, continueShoppingButtonElement, 5);
                return driver.FindElement(continueShoppingButtonElement);
            }
        }

        public IWebElement FirstNameTexBox
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, firstNameTexBoxElement, 5);
                return driver.FindElement(firstNameTexBoxElement);
            }
        }

        public IWebElement LastNameTexBox
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, lastNameTexBoxElement, 5);
                return driver.FindElement(lastNameTexBoxElement);
            }
        }

        public IWebElement PostalCodeTexBox
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, postalCodeTexBoxElement, 5);
                return driver.FindElement(postalCodeTexBoxElement);
            }
        }

        public IWebElement CancelCheckoutButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, cancelCheckoutButtonElement, 5);
                return driver.FindElement(cancelCheckoutButtonElement);
            }
        }

        public IWebElement ContinueCheckoutButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, continueCheckoutButtonElement, 5);
                return driver.FindElement(continueCheckoutButtonElement);
            }
        }

        public IWebElement FinishOrdertButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, finishOrdertButtonElement, 5);
                return driver.FindElement(finishOrdertButtonElement);
            }
        }

        public IWebElement ThankYouMessage
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, thankYouMessageElement, 5);
                return driver.FindElement(thankYouMessageElement);
            }
        }

        public IWebElement BackToHomeButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, backToHomeButtonElement, 5);
                return driver.FindElement(backToHomeButtonElement);
            }
        }
    }
}