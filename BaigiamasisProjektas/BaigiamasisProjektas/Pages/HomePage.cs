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

        private IWebElement LogoutElement => Driver.FindElement(By.CssSelector("input[value='Atsijungti']"));
        
        public HomePage AssertLogoutIsVisible()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Assert.IsNotNull(LogoutElement);
            return this;
        }
        public void ClickLogout()
        {
            LogoutElement.Click();
        }
    }
}
