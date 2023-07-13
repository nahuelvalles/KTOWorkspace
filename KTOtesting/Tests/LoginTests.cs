using KTOtesting.PageObjects;
using KTOtesting.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTOtesting.Tests
{
    public class LoginTests : Base
    {
        [Test, TestCaseSource("AddTestDataConfig")]
        public void LoginCredentials(String email, String password)
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

            //Assert that for every data combination we allways get the error message
            //Im doing it this way since the page requires to be registered for real in order to login and doesn-t have a fake login.
            //It could be done registering first and then trying those credentials though.

            String expectedMessage = "Invalid email or password.";
            Assert.AreEqual(expectedMessage, loginPage.getErrorMessage().Text);
        }

        //All scenarios I could think of are covered on the scenario mapping, I believe that is not necessary to implement each one here since it would be basically the same but changing values
        public static IEnumerable<TestCaseData> AddTestDataConfig() 
        {
            yield return new TestCaseData(getDataParser().extractData("validEmail"), getDataParser().extractData("validPassword"));
            yield return new TestCaseData(getDataParser().extractData("validEmail"), getDataParser().extractData("invalidPassword"));
            yield return new TestCaseData(getDataParser().extractData("invalidEmail"), getDataParser().extractData("validPassword"));
            yield return new TestCaseData(getDataParser().extractData("invalidEmail"), getDataParser().extractData("invalidPassword"));

        }
    }
}
