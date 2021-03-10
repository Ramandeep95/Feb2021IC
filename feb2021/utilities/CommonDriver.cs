using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace feb2021.utilities
{
    class CommonDriver
    {
        // Intiate and define Webdriver
        public static IWebDriver driver = new ChromeDriver(@"F:\feb2021\feb2021");
    }
}
