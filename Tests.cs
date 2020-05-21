using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cas31Primer2.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace Cas31Primer2
{
    class Tests
    {
        private IWebDriver driver;
       
        [SetUp]
        public void SetUp()
        {
            this.driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestListOfFemales()
        {
            HomePage home = new HomePage(this.driver);
            home.GoToPage();
            home.ClickOnLink();
            ListPage list = new ListPage(this.driver);
            Assert.Greater(list.NumOfFemale(), 30);
        }

        [TearDown]
        public void TearDown()
        {
            this.driver.Close();
        }
    }
}
