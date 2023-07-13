using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTOtesting.PageObjects
{
    public class RegistrationPage
    {
        private IWebDriver driver;

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Using Page Object Factory

        //emailControl text field
        [FindsBy(How = How.Id, Using = "emailControl")]
        private IWebElement emailControl;

        public IWebElement getEmailControl()
        {
            return emailControl;
        }

        //passwordControl text field
        [FindsBy(How = How.Id, Using = "passwordControl")]
        private IWebElement passwordControl;

        public IWebElement getPasswordControl()
        {
            return passwordControl;
        }

        //repeatPasswordControl text field
        [FindsBy(How = How.Id, Using = "repeatPasswordControl")]
        private IWebElement repeatPasswordControl;

        public IWebElement getRepeatPassword()
        {
            return passwordControl;
        }

        //Security Question Dropdown
        [FindsBy(How = How.XPath, Using = "//span[contains(@class, \"mat-select-placeholder\")]")]
        private IWebElement securityQuestion;

        public IWebElement getSecurityQuestion()
        {
            return securityQuestion;
        }

        //Security Answer text field
        [FindsBy(How = How.Id, Using = "securityAnswerControl")]
        private IWebElement securityAnswer;

        public IWebElement getSecurityAnswerControl()
        {
            return securityAnswer;
        }

        //Register button
        [FindsBy(How = How.Id, Using = "registerButton")]
        private IWebElement registerButton;

        public IWebElement getRegisterButton()
        {
            return registerButton;
        }

    }
}
