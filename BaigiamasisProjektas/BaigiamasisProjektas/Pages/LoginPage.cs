using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BaigiamasisProjektas.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }
        //login
        private IWebElement UsernameElement => Driver.FindElement(By.CssSelector("input[name='user'].text_field"));
        private IWebElement PasswordElement => Driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => Driver.FindElement(By.CssSelector("span.green_button_basket1"));
        //search
        private IWebElement SearchElement => Driver.FindElement(By.Id("mc_search_field"));
        private IWebElement SearchButton => Driver.FindElement(By.CssSelector("input[value='Rasti'].button"));
        private IWebElement SearchResultsElement => Driver.FindElement(By.TagName("h1"));

        //login
        public LoginPage EnterUsername(string username)
        {
            UsernameElement.SendKeys(username);
            return this;
        }
        public LoginPage EnterPassword(String password)
        {
            PasswordElement.SendKeys(password);
            return this;
        }
        public HomePage ClickLogin()
        {
            LoginButton.Click();
            return new HomePage(Driver);
        }
        //search
        public LoginPage EnterSearch(string text)
        {
            SearchElement.SendKeys(text);
            return this;
        }
        public LoginPage ClickSearch()
        {
            SearchButton.Click();
            return this;
        }
        public void AssertSearch(string text)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Assert.IsTrue((SearchResultsElement.Text).Contains(text));
        }
    }
}
