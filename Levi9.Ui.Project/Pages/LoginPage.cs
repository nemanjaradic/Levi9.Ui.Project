using Levi9.Ui.Project.Common;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levi9.Ui.Project.Pages
{
    public class LoginPage
    {
        private By userNameTextBoxElement = By.Id("user-name");
        private By passwordTextBoxElement = By.Id("password");
        private By loginButtonElement = By.Id("login-button");
        private By errorTextMessageElement = By.XPath("//*[@id='login_button_container']/div/form/div[3]/h3");

        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement UserNameTextBox
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, userNameTextBoxElement, 5);
                return driver.FindElement(userNameTextBoxElement);
            }
        }

        public IWebElement PasswordTextBox
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, passwordTextBoxElement, 5);
                return driver.FindElement(passwordTextBoxElement);
            }
        }

        public IWebElement LoginButton
        {
            get
            {
                WaitHelper.WaitUntilElementIsClickable(driver, loginButtonElement, 5);
                return driver.FindElement(loginButtonElement);
            }
        }

        public IWebElement ErrorTextMessage
        {
            get
            {
                WaitHelper.WaitUntilElementIsVisible(driver, errorTextMessageElement, 5);
                return driver.FindElement(errorTextMessageElement);
            }
        }

        public void PerformLogin(string username, string password)
        {
            UserNameTextBox.SendKeys(username);
            PasswordTextBox.SendKeys(password);
            LoginButton.Click();
        }
    }
}