using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases.Pages
{
    internal class OrderPages
    {
        private readonly IWebDriver driver;
        public OrderPages(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement AddButtonRegister => driver.FindElement(By.Id("register-btn"));
        private IWebElement AddButtonLogin => driver.FindElement(By.Id("login-btn"));
        private IWebElement AddButtonHome => driver.FindElement(By.Id("home-btn"));
        private IWebElement AddButtonPrivacy => driver.FindElement(By.Id("privacy-btn"));
        private IWebElement Name => driver.FindElement(By.Id("full-name"));
        private IWebElement UserName => driver.FindElement(By.Id("reguname"));
        private IWebElement Email => driver.FindElement(By.Id("email"));
        private IWebElement Role => driver.FindElement(By.Id("role"));
        private IWebElement AddButtonSave => driver.FindElement(By.Id("save"));
        private IWebElement AddButtonRegisterLogin => driver.FindElement(By.Id("login1"));
        private IWebElement LoginUserName => driver.FindElement(By.Id("uname"));
        private IWebElement AddButtonMainLogin => driver.FindElement(By.Id("login2"));
        private IWebElement AddButtonAvailableProducts => driver.FindElement(By.Id("available-products"));
        private IWebElement AddButtonViewCart => driver.FindElement(By.Id("cart"));
        private IWebElement AddButtonLogout => driver.FindElement(By.Id("logout"));
        private IWebElement AddButtonViewDetails => driver.FindElement(By.Id("viewdetails-btn"));
        private IWebElement AddButtonBook => driver.FindElement(By.Id("book-btn"));

        public void ClickAddButtonRegister()
        {
            AddButtonRegister.Click();
        }
        public void ClickAddButtonLogin()
        {
            AddButtonLogin.Click();
        }
       
        public void ClickAddButtonHome()
        {
            AddButtonHome.Click();
        }

        public void ClickAddButtonPrivacy()
        {
            AddButtonPrivacy.Click();
        }
        public void EnterName(string name)
        {
            Name.SendKeys(name);
        }
        public void EnterUserName(string username)
        {
            UserName.SendKeys(username);
        }
        public void EnterEmail(string email)
        {
            Email.SendKeys(email);
        }
        public void EnterRole(string role)
        {
            Role.SendKeys(role);
        }
        public void ClickAddButtonSave()
        {
            AddButtonSave.Click();
        }
        public void ClickAddButtonRegisterLogin()
        {
            AddButtonRegisterLogin.Click();
        }
        public void EnterUsernameLogin(string username)
        {
            LoginUserName.SendKeys(username);
        }
        public void ClickAddButtonMainLogin()
        {
            AddButtonMainLogin.Click();
        }
        public void ClickAddButtonAvailableProducts()
        {
            AddButtonAvailableProducts.Click();
        }
        public void ClickAddButtonViewCart()
        {
            AddButtonViewCart.Click();
        }
        public void ClickAddButtonLogout()
        {
            AddButtonLogout.Click();
        }

        public void ClickAddButtonViewDetails()
        {
            AddButtonViewDetails.Click();
        }
        public void ClickAddButtonBook()
        {
            AddButtonBook.Click();
        }
    }
}
