using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;

namespace Specflow.Utilities
{
    public class Driver
    {

        //Initialize the browser
        public static IWebDriver WebDriver { get; set; }

       
        public static void DriverInitialize(string browser)
        {
            switch (browser)
            {
                case "Chrome":
                    WebDriver = new ChromeDriver();
                    break;
                case "IE":
                    WebDriver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    WebDriver = new FirefoxDriver();
                    break;
            }
            //Maximise the window
            WebDriver.Manage().Window.Maximize();
            TurnOnWait();
        }

        public static string BaseUrl
        {
            get { return Constants.Url; }
        }


        //Implicit Wait
        public static void TurnOnWait()
        {
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }

        //Navigate to Website URL
        public static void NavigateUrl(string url)
        {
            WebDriver.Navigate().GoToUrl(url);
        }

        //Navigate to Website URL
        public static void NavigateUrl()
        {
            WebDriver.Navigate().GoToUrl(BaseUrl);
        }
        //Close the browser
        public static void Close()
        {
            WebDriver.Close();
            WebDriver.Quit();
        }

      
        public static Boolean WaitUntilElementisClickable(By locator, int timeout) {
            Boolean status = false;
            try
            {
                WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(timeout));
#pragma warning disable CS0618 // Type or member is obsolete
                IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
#pragma warning restore CS0618 // Type or member is obsolete
                status = true;
                return status;
            } catch (WebDriverTimeoutException) {
               
                    }
            return status;
        }

        public static Boolean WaitUntilElementisDisplayed(By locator, int timeout)
        {
            Boolean status = false;
            try
            {
                WebDriverWait wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(timeout));
#pragma warning disable CS0618 // Type or member is obsolete
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(locator));
#pragma warning restore CS0618 // Type or member is obsolete
                status = true;
                return status;
            }
            catch (WebDriverTimeoutException)
            {

            }
            return status;
        }
    }
}
