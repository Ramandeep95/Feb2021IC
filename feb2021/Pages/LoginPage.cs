using feb2021.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace feb2021.Pages
{
    class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            // launch turn up portal
            
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            driver.Manage().Window.Maximize();

            try
            {
                // identify username textbox and input username
                //Wait.ElementPresent(driver, "Id", "UserName");
                IWebElement username = driver.FindElement(By.Id("UserName"));
                username.SendKeys("hari");

                //identify password and input password
                //Wait.ElementPresent(driver, "Id", "Password");
                IWebElement password = driver.FindElement(By.Id("Password"));
                password.SendKeys("123123");

                //identify login button and click on the login button
                //Wait.ElementPresent(driver, "XPath", "//*[@id='loginForm']/form/div[3]/input[1]");
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
            }catch(Exception ex)
            {
                Assert.Fail("Test failed at login page", ex.Message);
            }
           

            // verify home page
            IWebElement hellohari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (hellohari.Text == "Hello hari!")
            {
                Console.WriteLine("Test Passed, Logged-in Successfully");
            }
            else
            {
                Console.WriteLine("Test Failed, Login Failed");
            }
        }
    }
}
