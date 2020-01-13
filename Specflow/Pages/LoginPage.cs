using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Specflow.Utilities;

namespace Specflow.Pages
{
    public class LoginPage
    {
        public void LoginStep(string username, string password)
        {
            //Click on Sign - In
            Driver.WebDriver.FindElement(By.XPath("//a[contains(.,'Sign In')]")).Click();

            Driver.TurnOnWait();
            //Enter Username
            IWebElement UserName = Driver.WebDriver.FindElement(By.Name("email"));
            UserName.Click();
            UserName.Clear();
            UserName.SendKeys(username);

            //Enter password
            IWebElement passWord = Driver.WebDriver.FindElement(By.Name("password"));
            passWord.Click();
            passWord.Clear();
            passWord.SendKeys(password);

            //Click on Login Button
            Driver.WebDriver.FindElement(By.XPath("//button[contains(.,'Login')]")).Click();



        }

    }
}
