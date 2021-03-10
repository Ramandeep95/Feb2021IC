using feb2021.utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace feb2021.Pages
{
    class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Create new Time and Material test


            // Click create new button 
            IWebElement CreateNew = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNew.Click();
            Wait.ElementPresent(driver, "XPath", "//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]");

            // Indentify Typecode Button and click on it
            IWebElement Typecode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            Typecode.Click();
            Thread.Sleep(500);

            // select time from drop down list
            IWebElement Time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            Time.Click();
            Thread.Sleep(500);

            // Enter code
            IWebElement Code = driver.FindElement(By.Id("Code"));
            Code.SendKeys("Mar2021");

            // Enter description
            IWebElement Description = driver.FindElement(By.Id("Description"));
            Description.SendKeys("Mar2021New");

            // Enter price
            IWebElement Price = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            Price.Click();
            IWebElement EnterPrice = driver.FindElement(By.Id("Price"));
            EnterPrice.SendKeys("700");

            // Upload attachment 




            // Click save
            IWebElement Save = driver.FindElement(By.Id("SaveButton"));
            Save.Click();
            Thread.Sleep(3000);

            // Go to last page
            IWebElement LastPage = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            LastPage.Click();
            Thread.Sleep(3000);

            Assert.That(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text == "Mar2021");



            ////// Validate if the record is created
            //if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text == "Mar2021")
            //{
            //    Console.WriteLine("Test Passed, time Record Created");
            //}
            //else
            //{
            //    Console.WriteLine("Test Failed, time Record Creation Failed");
            //}

        }

        public void EditTM(IWebDriver driver)
        {
            // Edit Time and Material test

            // Identify last record

            IWebElement LastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            LastRecord.Click();
            Thread.Sleep(2000);

            //Identify Edit button and click on it

            IWebElement EditButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[4]/td[5]/a[1]"));
            EditButton.Click();
            Thread.Sleep(500);

            // Identify Typecode Button and click on it

            IWebElement EditTypeCode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            EditTypeCode.Click();
            Thread.Sleep(500);

            // Select Material from drop down list

            IWebElement UpdateTypeCode = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            UpdateTypeCode.Click();
            Thread.Sleep(500);

            // Edit Code

            IWebElement EditCode = driver.FindElement(By.Id("Code"));
            EditCode.SendKeys("EditCode");

            // Edit Description

            IWebElement EditDescription = driver.FindElement(By.Id("Description"));
            EditDescription.SendKeys("EditCodeDescription");

            // Edit Price

            IWebElement EditPrice = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            EditPrice.SendKeys("1250");

            // Upload Attachment


            // Save

            IWebElement SaveEditRecord = driver.FindElement(By.Id("downloadButton"));
            SaveEditRecord.Click();
            Thread.Sleep(2500);

            // Validate if record is Edited
            //if(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text == "EditCode")
            //{
            //    Assert.Pass("Test Passed, Time Record Edited");
            //}
            //else
            //{
            //    Assert.Fail("Test Failed, Time Record Updation Failed");
            //}

            // Validate if the record is edited
            if (driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]")).Text == "EditCode")
            {
                Console.WriteLine("Test Passed, time Record edited");
            }
            else
            {
                Console.WriteLine("Test Failed, time Record updation Failed");
            }



        }

        public void Delete(IWebDriver driver)
        {
            // Delete Time and Material test

            // Identify last record

            IWebElement FindLastRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            FindLastRecord.Click();
            Thread.Sleep(500);

            //Identify Delete button and click on it

            IWebElement DeleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[5]/a[2]"));
            DeleteButton.Click();
            Thread.Sleep(500);



            // Validate if record is deleted
            Assert.That(driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[1]")).Text, Is.EqualTo("march2021"));




        }
    }
}
