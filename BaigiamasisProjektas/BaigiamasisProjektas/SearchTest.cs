using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace BaigiamasisProjektas
{
    public class SearchTest : BaseTest
    {
        [Test]
        public void TestSearch()
        {
            var searchText = "Jungtis";
            homePage
                .EnterSearch(searchText)
                .ClickSearch()
                .AssertSearch(searchText);
        }
    }
}
