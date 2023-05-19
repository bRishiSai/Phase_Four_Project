using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Drawing;
using System.Threading.Tasks;

namespace TestCases
{
    internal abstract class BaseTestRegister
    {
        IWebDriver driver;
        protected IWebDriver GetDriver()
        {
            return driver;
        }

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            TestContext.Progress.WriteLine("One Time Setup Invoked.");
        }

        [SetUp]
        public void Setup()
        {
            driver = CreateDriver("chrome");
            driver.Manage().Window.Size = new Size(1134, 824);
            driver.Navigate().GoToUrl("https://localhost:7195/Account/Register/");

        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            TestContext.Progress.WriteLine("One Time Tear Down Invoked.");
        }
        private IWebDriver CreateDriver(string browserName)
        {
            switch (browserName.ToLowerInvariant())
            {
                case "chrome":
                    return new ChromeDriver();
                case "firefox":
                    return new FirefoxDriver();
                case "edge":
                    return new EdgeDriver();
                default:
                    throw new Exception("Provided browser is not suppoeted");
            }
        }
    }
}
