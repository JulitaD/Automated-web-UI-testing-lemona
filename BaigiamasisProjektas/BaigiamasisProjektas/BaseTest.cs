using System;
using System.Collections.Generic;
using System.Text;
using BaigiamasisProjektas.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaigiamasisProjektas
{
    public class BaseTest
    {
        public IWebDriver driver;
        protected HomePage homePage;
        protected UserPage userPage;

        [SetUp]
        public void InitDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.lemona.lt/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector(".cookieinfo-close")).Click(); //kad uzdarytu coockies
            InitPages();
        }
        private void InitPages()
        {
            homePage = new HomePage(driver);
        }

        [TearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
