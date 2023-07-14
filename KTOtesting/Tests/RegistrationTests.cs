using KTOtesting.PageObjects;
using KTOtesting.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace KTOtesting.Tests
{
    public class RegistrationTests : RegisterBase
    {
        [Test, Category("Register"), TestCaseSource(nameof(AddTestDataConfig))]
        public void RegistrationAction(String email, String password, String repPass, String optionText, String Answer)
        {
            //Initialize driver and all locators from RegistrationPage class
            LoginPage loginPage = new LoginPage(getDriver());
            RegistrationPage registrationPage = new RegistrationPage(getDriver());

            //Time for the alert to appear
            Thread.Sleep(3000);

            registrationPage.getDismissButton().Click();
            Thread.Sleep(3000);
            registrationPage.getEmailControl().SendKeys(email);
            Thread.Sleep(3000);
            registrationPage.getPasswordControl().SendKeys(password);
            Thread.Sleep(3000);
            registrationPage.getRepeatPassword().SendKeys(repPass);
            Thread.Sleep(3000);
            
            registrationPage.getSecurityQuestion().Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("mat-option")));

            //This kinda break my Page Object Model format, I tried to have the locator within the RegistrationPage.cs like it should
            //but I strugleed a bit having the optionText variable within the locator.

            IWebElement optionElement = driver.FindElement(By.XPath($"//mat-option[normalize-space()='{optionText}']"));
            optionElement.Click();

            registrationPage.getSecurityAnswerControl().SendKeys(Answer);
            Thread.Sleep(3000);

            registrationPage.getRegisterButton().Click();
            Thread.Sleep(10000);

           
        }

        //Here we can have another individual tests in order to just check if a button or link works, is not needed to have the E2E process all the time.

        public static IEnumerable<TestCaseData> AddTestDataConfig()
        {
            yield return new TestCaseData(getDataParser().extractData("validEmail"), getDataParser().extractData("validPassword"), getDataParser().extractData("validRepPass"), getDataParser().extractData("optionText"), getDataParser().extractData("validAnswer"));
            yield return new TestCaseData(getDataParser().extractData("invalidEmail"), getDataParser().extractData("validPassword"), getDataParser().extractData("invalidRepPass"), getDataParser().extractData("optionText"), getDataParser().extractData("validAnswer"));

        }
    }
}
