using TestCases.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestCases;

namespace TestCases
{
    [Parallelizable(ParallelScope.Children)]
    [FixtureLifeCycle(LifeCycle.SingleInstance)]
    internal class PageModelTest : BaseTest
    {
        private OrderPages orderPages;
        [SetUp]
        public new void Setup()
        {
            orderPages = new OrderPages(GetDriver());
        }
        [Test]
        public new void SimpleTest()
        {
            orderPages.ClickAddButtonRegister();
            orderPages.ClickAddButtonLogin();
            orderPages.ClickAddButtonHome();
            orderPages.ClickAddButtonPrivacy();
        }
    }
}

