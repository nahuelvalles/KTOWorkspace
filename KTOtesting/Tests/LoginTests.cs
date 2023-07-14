using AngleSharp.Dom;
using KTOtesting.PageObjects;
using KTOtesting.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTOtesting.Tests
{
    public class LoginTests : LoginBase
    {
        [Test,Category("InvalidLogin"), TestCaseSource("AddTestDataConfig")]
        public void LoginInvalidCredentials(String email, String password)
        {
            //Initialize driver and all locators from LoginPage class
           LoginPage loginPage = new LoginPage(getDriver());

            //Thread sleep to let alert appears
            Thread.Sleep(3000);

            loginPage.getDismissButton().Click();
            loginPage.getEmail().SendKeys(email);
            Thread.Sleep(3000);
            loginPage.getPassword().SendKeys(password);
            Thread.Sleep(3000);
            loginPage.getLoginButton().Click();
            Thread.Sleep(3000);

            //Assert that when entering invalid credentials the page shows an error message.
            String expectedMessage = "Invalid email or password.";
            Assert.AreEqual(expectedMessage, loginPage.getErrorMessage().Text);
        }

        [Test,Category("ValidLogin"), TestCaseSource("ValidDataConfig")]
        public void LoginValidCredentials(String email, String password)
        {
            HomePage homePage = new HomePage(getDriver());
            LoginPage loginPage = new LoginPage(getDriver());

            //Thread sleep to let alert appears
            Thread.Sleep(3000);

            loginPage.getDismissButton().Click();
            loginPage.getEmail().SendKeys(email);
            Thread.Sleep(3000);
            loginPage.getPassword().SendKeys(password);
            Thread.Sleep(3000);
            loginPage.getLoginButton().Click();
            Thread.Sleep(3000);

            
            bool isDisplayed = homePage.getAllProductsText().Displayed;

            Assert.IsTrue(isDisplayed);
        }

        public static IEnumerable<TestCaseData> AddTestDataConfig() 
        {
            yield return new TestCaseData(getDataParser().extractData("validEmail"), getDataParser().extractData("invalidPassword"));
            yield return new TestCaseData(getDataParser().extractData("invalidEmail"), getDataParser().extractData("validPassword"));
            yield return new TestCaseData(getDataParser().extractData("invalidEmail"), getDataParser().extractData("invalidPassword"));

        }

        public static IEnumerable <TestCaseData> ValidDataConfig()
        {
            yield return new TestCaseData(getDataParser().extractData("validEmail"), getDataParser().extractData("validPassword"));

        }
    }
}
