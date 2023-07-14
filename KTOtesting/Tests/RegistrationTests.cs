using KTOtesting.PageObjects;
using KTOtesting.Utilities;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTOtesting.Tests
{
    public class RegistrationTests : Base
    {
        public String newUrl { get; set; }
        public void NavigateToNewUrl()
        {
            newUrl = "https://juice-shop.herokuapp.com/#/register";
        }

        [Test, Category("Register"), TestCaseSource(nameof(AddTestDataConfig))]
        public void RegistrationAction(String email, String password, String repPass, String question, string Answer)
        {
            //Initialize driver and all locators from RegistrationPage class
            RegistrationPage registrationPage = new RegistrationPage(getDriver());

            Thread.Sleep(3000);

            registrationPage.getEmailControl().SendKeys(email);
            Thread.Sleep(3000);
            registrationPage.getPasswordControl().SendKeys(password);
            Thread.Sleep(3000);
            registrationPage.getRepeatPassword().SendKeys(repPass);
            Thread.Sleep(3000);

            //Method to handle dropdown
            SelectElement select = new SelectElement(registrationPage.getSecurityQuestion());
            select.SelectByText(question);
            Thread.Sleep(3000);

            registrationPage.getSecurityAnswerControl().SendKeys(Answer);
            Thread.Sleep(3000);

            registrationPage.getRegisterButton().Click();


        }

        //Here we can have another individual tests in order to just check if a button or link works, is not needed to have the E2E process all the time.

        public static IEnumerable<TestCaseData> AddTestDataConfig()
        {
            yield return new TestCaseData(getDataParser().extractData("validEmail"), getDataParser().extractData("validPassword"), getDataParser().extractData("validPassword"), getDataParser().extractData("question"), getDataParser().extractData("validAnswer"));
            yield return new TestCaseData(getDataParser().extractData("invalidEmail"), getDataParser().extractData("validPassword"), getDataParser().extractData("validPassword"), getDataParser().extractData("question"), getDataParser().extractData("validAnswer"));

        }
    }
}
