using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Specflow.Utilities
{
    public class ByMethods
    {
      

            public static By SelectDataTab(string tabName)
            {

                return By.XPath("//a[contains(@class,'item' ) and text()='"+ tabName+"']");
            }


            public static By Select_EditFor_SkillName(string skillName)
            {


                return By.XPath("//td[.='" + skillName + "']/../..//i[@class='outline write icon']");

            }

            public static By Select_RemoveFor_SkillName(string skillName)
            {


                return By.XPath("//td[.='" + skillName + "']/../..//i[@class='remove icon']");

            }
            public static void SelectDropdownByValue(IWebElement element, string value)
            {


                var selectElement = new SelectElement(element);
                selectElement.SelectByValue(value);

                Console.WriteLine("Selected dropdown by Value " + value);
            }


            public static By SelectButton(string buttonname)
            {
                Console.WriteLine("Selected Button by Name " + buttonname);

                return By.XPath("//input[@type='button' and @value ='" + buttonname + "']");



            }

        }
    }

