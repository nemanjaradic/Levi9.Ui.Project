﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Levi9.Ui.Project.Common
{
    public static class WaitHelper
    {
        public static bool WaitUntilElementIsVisible(IWebDriver driver, By locator, long timeOutInSeconds)
        {
            WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            try
            {
                driverWait.Until(ExpectedConditions.ElementIsVisible(locator));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //for buttons
        public static bool WaitUntilElementIsClickable(IWebDriver driver, By locator, long timeOutInSeconds)
        {
            WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            try
            {
                driverWait.Until(ExpectedConditions.ElementToBeClickable(locator));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        //for dropdown and for all inputs
        public static bool WaitOnlyUntilElementExists(IWebDriver driver, By locator, long timeOutInSeconds)
        {
            WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            try
            {
                driverWait.Until(ExpectedConditions.ElementExists(locator));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // when need to something dissaper
        public static bool WaitUntilElementIsStale(IWebDriver driver, IWebElement element, long timeOutInSeconds)
        {
            WebDriverWait driverWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutInSeconds));
            try
            {
                driverWait.Until(ExpectedConditions.StalenessOf(element));
                return true;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    };
}