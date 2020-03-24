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
        protected LoginPage loginPage;
        protected HomePage homePage;

        [SetUp]
        public void InitDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.lemona.lt/";

            InitPages();
        }
        private void InitPages()
        {
            loginPage = new LoginPage(driver);
        }

        [TearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}
