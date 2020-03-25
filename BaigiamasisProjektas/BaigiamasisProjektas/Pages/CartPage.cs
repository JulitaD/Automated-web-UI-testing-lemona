using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace BaigiamasisProjektas.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement RemoveItemButton => Driver.FindElement(By.Id("delete_b"));
        private IWebElement HomeButton => Driver.FindElement(By.ClassName("checkout_header_logo"));
        public CartPage ClickRemoveButton()
        {
            RemoveItemButton.Click();
            return this;
        }
        public HomePage ClickHome()
        {
            HomeButton.Click();
            return new HomePage(Driver);
        }
    }
}
