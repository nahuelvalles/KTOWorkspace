using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KTOtesting.PageObjects
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Using Page Object Factory

        [FindsBy(How = How.CssSelector , Using = "h1._ngcontent-lfh-c48")]
        private IWebElement loginTitle;

        public IWebElement getLoginTitle()
        {
            return loginTitle;
        }

        //Dismiss button from the alert
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Close Welcome Banner']")]
        private IWebElement dismissButton;

        public IWebElement getDismissButton()
        {
            return dismissButton;
        }

        //Email text field
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement email;

        public IWebElement getEmail()
        {
            return email;
        }

        //Password text field
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;

        public IWebElement getPassword()
        {
            return password;
        }

        //loginButton
        [FindsBy(How = How.Id, Using = "loginButton")]
        private IWebElement loginButton;

        public IWebElement getLoginButton()
        {
            return loginButton;
        }

        //rememberMe checkbox
        [FindsBy(How = How.Id, Using = "rememberMe")]
        private IWebElement rememberMe;

        public IWebElement getRememberMe()
        {
            return rememberMe;
        }

        //newCustomerLink text link
        [FindsBy(How = How.Id, Using = "newCustomerLink")]
        private IWebElement newCustomerLink;

        public IWebElement getNewCustomerLink()
        {
            return newCustomerLink;
        }

        //errorMessage text
        [FindsBy(How = How.CssSelector, Using = "div.error.ng-star-inserted")]
        private IWebElement errorMessage;
        public IWebElement getErrorMessage() { return  errorMessage;}

        //General methods

        //Action of Login
        public void loginAction(String StrEmail, String StrPassword)
        {
            email.SendKeys(StrEmail);
            password.SendKeys(StrPassword);
            loginButton.Click();
        }
    }
}
