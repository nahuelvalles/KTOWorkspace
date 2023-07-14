using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System.Configuration;
using System.Diagnostics.Contracts;

namespace KTOtesting.Utilities
{
    public class RegisterBase
    {
       
        public IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            String browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            driver.Url = "https://juice-shop.herokuapp.com/#/register";
        }

        public IWebDriver getDriver()
        {
            return driver;
        }

        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox" :
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
                    driver = new FirefoxDriver();
                    break;

                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
                    driver = new ChromeDriver();
                    break;
            }
        }

        public static jsonReader getDataParser()
        {
            return new jsonReader();
        }

        [TearDown]
        public void StopBrowser()
        {
            driver.Quit();
        }
      
    }
}
