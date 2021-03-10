using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace feb2021.Pages
{
    class HomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {
            // Goto Administration and click on it
            Thread.Sleep(500);
            IWebElement Admin = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Admin.Click();
            Thread.Sleep(500);

            // Navigate to Time and Material page
            IWebElement TnM = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            TnM.Click();
            Thread.Sleep(500);
        }
    }
}
