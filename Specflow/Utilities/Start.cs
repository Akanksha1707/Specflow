using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Specflow.Pages;
using TechTalk.SpecFlow;

namespace Specflow.Utilities
{
   public class Start: Driver
    {

        
        [BeforeScenario]
        public void SetUp()
        {
            //Launch the browser
            Driver.DriverInitialize("Chrome");
            Driver.NavigateUrl();
            Thread.Sleep(500);

            //Call the Login Class  
            LoginPage loginPage = new LoginPage();
            loginPage.LoginStep("akankshabhola17@gmail.com","Ankurbhardwaj");
        }

        [AfterScenario]
        public void TearDown()
        {
            Thread.Sleep(500);
           
            //Close the browser
            Close();

            
        }
    }
}
