using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BaigiamasisProjektas.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
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
        //shoppingCart

        //private IWebElement AddToCartElement => Driver.FindElements(By.ClassName("monoid-rec-product-order"))[0];

        private IList<IWebElement> AddToCartElementList => Driver.FindElements(By.ClassName("monoid-rec-product-order"));
        //private IWebElement AddtoCartElement => AddToCartElementList[0];

        private IWebElement BuyButton => Driver.FindElement(By.CssSelector(".green_button1.center"));

    //login
    public HomePage EnterUsername(string username)
        {
            UsernameElement.SendKeys(username);
            return this;
        }
        public HomePage EnterPassword(String password)
        {
            PasswordElement.SendKeys(password);
            return this;
        }
        public UserPage ClickLogin()
        {
            LoginButton.Click();
            return new UserPage(Driver);
        }
        //search
        public HomePage EnterSearch(string text)
        {
            SearchElement.SendKeys(text);
            return this;
        }
        public HomePage ClickSearch()
        {
            SearchButton.Click();
            return this;
        }
        public void AssertSearch(string text)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Assert.IsTrue((SearchResultsElement.Text).Contains(text));
        }
        //cart
        public HomePage ClickAddToCart()
        {
            AddToCartElementList[0].Click();
            return this;
        }
        public HomePage AssertBuyButtonIsPresent()
        {
            Assert.IsNotNull(BuyButton);
            return this;
        }
        public CartPage ClickBuyButton()
        {
            BuyButton.Click();
            return new CartPage(Driver);
        }
        public void AssertBuyButtonIsNotPresent()
        {
            Assert.IsNull(BuyButton);
        }
    }
}
