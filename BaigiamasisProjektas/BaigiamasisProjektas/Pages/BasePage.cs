using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace BaigiamasisProjektas.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
