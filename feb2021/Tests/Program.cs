using feb2021.Pages;
using feb2021.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace feb2021
{
    [TestFixture]
    class Program : CommonDriver
    {
        
        [SetUp]
        public void Login()
        {
            // login page obj and login steps
            LoginPage LoginObj = new LoginPage();
            LoginObj.LoginSteps(driver);

            //home page obj and navigate steps
            HomePage HomeObj = new HomePage();
            HomeObj.NavigateToTM(driver);
        }

        [Test]
        public void CreateTMTest()
        {
            // TM page obj and create step
            TMPage TMObj = new TMPage();
            TMObj.CreateTM(driver);
        }

        [Test]
        public void EditTMTest()
        {
            // TM page obj and Edit step
            TMPage TMObj = new TMPage();
            TMObj.EditTM(driver);
        }

        [Test]
        public void DeleteTMTest()
        {
            // TM page obj and Delete step
            TMPage TMObj = new TMPage();
            TMObj.Delete(driver);

        }

        [TearDown]
        public void FinalSteps()
        {
            driver.Quit();
        }



    }
}
