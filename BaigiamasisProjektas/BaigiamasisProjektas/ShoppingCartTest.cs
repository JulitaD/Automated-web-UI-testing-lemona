using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace BaigiamasisProjektas
{
    public class ShoppingCartTest : BaseTest
    {
        [Test]
        public void TestShoppingCart()
        {
            homePage
                .ClickAddToCart()
                .AssertBuyButtonIsPresent()
                .ClickBuyButton()
                .ClickRemoveButton()
                .ClickHome()
                .AssertBuyButtonIsNotPresent();
        }
    }
}
