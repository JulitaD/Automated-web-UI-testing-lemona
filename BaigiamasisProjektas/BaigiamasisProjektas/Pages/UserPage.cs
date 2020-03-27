using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BaigiamasisProjektas.Pages
{
    public class UserPage : BasePage
    {
        public UserPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement LogoutElement => Driver.FindElement(By.CssSelector("input[value='Atsijungti']"));
        
        public UserPage AssertLogoutIsVisible()
        {
            Assert.IsNotNull(LogoutElement);
            return this;
        }
        public void ClickLogout()
        {
            LogoutElement.Click();
        }
    }
}
