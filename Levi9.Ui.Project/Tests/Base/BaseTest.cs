﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Levi9.Ui.Project.Common;

namespace Levi9.Ui.Project.Tests.Base
{
    public class BaseTest
    {
        public TestContext TestContext { get; set; }
        protected IWebDriver driver;

        [TestInitialize]
        public void SetUp()
        {   //nessary settings in order to keep all web elements visible
            var options = new ChromeOptions();
            options.AddArgument("window-size=1920,1080");
            options.AddArgument("force-device-scale-factor=1");
            options.AddArgument("high-dpi-support=1");
            options.AddArguments("enable-automation");
            options.AddArgument("--browser.helperApps.neverAsk.saveToDisk");
            options.AddArguments("--no-sandbox");

            options.PageLoadStrategy = PageLoadStrategy.Eager;
            driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Constants.baseUrl);
        }

        [TestCleanup]
        public void CleanUp()
        {
            if (TestContext.CurrentTestOutcome != UnitTestOutcome.Passed)
            {
                var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
                var dateTime = DateTime.Now.ToFileTimeUtc();
                screenshot.SaveAsFile($@"C:\Users\n.radic\source\repos\Levi9.Ui.Project\Levi9.Ui.Project\FailedTestsSS\Screenshot{dateTime}.png", ScreenshotImageFormat.Png);
            }
            driver.Dispose();
            driver.Quit();
        }
    }
}