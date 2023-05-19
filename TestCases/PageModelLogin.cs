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
    internal class PageModelLogin : BaseTestLogin
    {
        private OrderPages orderPages;
        [SetUp]
        public new void Setup()
        {
            orderPages = new OrderPages(GetDriver());
        }
        [Test]
        public new void SimpleTestLogin()
        {
            orderPages.EnterUsernameLogin("Somesh122");
            orderPages.ClickAddButtonMainLogin();
        }
    }
}
