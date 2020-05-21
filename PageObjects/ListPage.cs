using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    class ListPage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public ListPage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        public ReadOnlyCollection<IWebElement> GenderList
        {
            get
            {
                ReadOnlyCollection<IWebElement> gender;
                try
                {
                    IWebElement table = wait.Until(EC.ElementIsVisible(By.XPath("//table")));
                    gender = table.FindElements(By.XPath("//td[@class='gender']"));
                }catch (Exception)
                {
                    gender = null;
                }
                return gender;
            }
        }

        public int NumOfFemale()
        {
            int num = 0;
            foreach(IWebElement gen in this.GenderList)
            {
                if (gen.Text=="Z")
                {
                    num++;
                }
            }
            return num;
        }
    }
}
