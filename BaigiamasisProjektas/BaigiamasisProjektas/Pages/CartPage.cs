using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BaigiamasisProjektas.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }
        //private IWebElement CartItemTitleElement => Driver.FindElement(By.CssSelector("td:nth-child(3) a"));
        private IWebElement CartItemTitleElement => Driver.FindElement(By.Id("main_wrapper_in"));

        public void AssertCartItemTitle(string text)
        {
            Assert.IsTrue((CartItemTitleElement.Text).Contains(text));
        }
    }
}
