using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace BaigiamasisProjektas
{
    public class LoginTest : BaseTest
    {
        [Test]
        public void TestLogin()
        {
            homePage
                .EnterUsername(User.DeafaultUser.Username)
                .EnterPassword(User.DeafaultUser.Password)
                .ClickLogin()
                .AssertLogoutIsVisible()
                .ClickLogout();
        }
        //[TearDown]
        //public void Logout()
        //{
        //    userPage.ClickLogout();
        //}

    }
}
