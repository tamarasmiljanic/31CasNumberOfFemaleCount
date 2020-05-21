using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using EC = SeleniumExtras.WaitHelpers.ExpectedConditions;


namespace Cas31Primer2.PageObjects
{
    class HomePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public void GoToPage()
        {
            this.driver.Navigate().GoToUrl("http://test.qa.rs/");
        }

        public IWebElement ListLink
        {
            get
            {
                IWebElement list;
                try
                {
                    list = this.driver.FindElement(By.LinkText("Izlistaj sve korisnike"));
                } catch (Exception)
                {
                    list = null;
                }
                return list;
            }
        }

        public void ClickOnLink()
        {
            ListLink?.Click();
        }
    }
}
