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
            var itemText = "Akumuliatorius";
            homePage
                .AssertItemTittle(itemText)
                .ClickAddToCart()
                .AssertBuyButtonIsPresent()
                .ClickBuyButton()
                .AssertCartItemTitle(itemText);
        }

        // labai gerai butu teardown isvalytu krepseli
    }
}
