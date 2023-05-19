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
    internal class PageTestRegister: BaseTestRegister
    {
        private OrderPages orderPages;
        [SetUp]
        public new void Setup()
        {
            orderPages = new OrderPages(GetDriver());
        }
        [Test]
        public new void SimpleTestRegister()
        {
            orderPages.EnterName("Somesh");
            orderPages.EnterUserName("Somesh122");
            orderPages.EnterEmail("Somesh@gmail.com");
            orderPages.EnterRole("user");
            orderPages.ClickAddButtonSave();
            orderPages.ClickAddButtonRegisterLogin();
        }
    }
}
