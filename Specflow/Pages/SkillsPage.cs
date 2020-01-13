using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Specflow.Utilities;

namespace Specflow.Pages
{
    public class SkillsPage
    {



        By Skill_name = By.XPath("//input[@placeholder='Add Skill']");
        By Skill_type = By.XPath("//select[contains(@class,'dropdown')]");
        public void SelectSkillTab()
        {
            Driver.WaitUntilElementisClickable(ByMethods.SelectDataTab("Skills"), 15);
            Driver.WebDriver.FindElement(ByMethods.SelectDataTab("Skills")).Click();
            Console.WriteLine("Selected the Tab Skills");
            System.Threading.Thread.Sleep(5000);
        }

        public void AddSkill(string SkillName, String SkillType)
        {
            Driver.WebDriver.FindElement(By.XPath("//div[@data-tab='second']//div[.='Add New']")).Click();
            Console.WriteLine("Selected the Add New Button");
            System.Threading.Thread.Sleep(2000);

            Driver.WebDriver.FindElement(Skill_name).SendKeys(SkillName);
            Console.WriteLine("Added the Skill as " + SkillName);
            // System.Threading.Thread.Sleep(2000);

            ByMethods.SelectDropdownByValue(Driver.WebDriver.FindElement(Skill_type), SkillType);


            Driver.WaitUntilElementisClickable(ByMethods.SelectButton("Add"), 15);
            Driver.WebDriver.FindElement(ByMethods.SelectButton("Add")).Click();

            Console.WriteLine("Clicked the Add Button");
            System.Threading.Thread.Sleep(2000);

        }

        public void EditSkill(string SkillName, String SkillType, String NewSkillName)
        {
            if (Driver.WaitUntilElementisDisplayed(ByMethods.Select_EditFor_SkillName(SkillName), 5))
            {
                Driver.WebDriver.FindElement(ByMethods.Select_EditFor_SkillName(SkillName)).Click();

                Console.WriteLine("Selected the Edit Button for Skill Name" + SkillName);

                // Update the Skill Name

                Driver.WebDriver.FindElement(Skill_name).Clear();
                Driver.WebDriver.FindElement(Skill_name).SendKeys(NewSkillName);
                Console.WriteLine("Updated the Skill name from " + SkillName + " to " + NewSkillName);


                ByMethods.SelectDropdownByValue(Driver.WebDriver.FindElement(Skill_type), SkillType);
                Driver.WaitUntilElementisClickable(ByMethods.SelectButton("Update"), 15);
                Driver.WebDriver.FindElement(ByMethods.SelectButton("Update")).Click();

                Console.WriteLine("Clicked the Update Button");
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Skill not found where Skill Name is " + SkillName);
            }

        }

        public void RemoveSkill(string SkillName, String SkillType)
        {
            if (Driver.WaitUntilElementisDisplayed(ByMethods.Select_EditFor_SkillName(SkillName), 5))
            {
                Driver.WebDriver.FindElement(ByMethods.Select_RemoveFor_SkillName(SkillName)).Click();
                Console.WriteLine("Selected the Remove Button for Skill Name" + SkillName);
                System.Threading.Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Skill not found where Skill Name is " + SkillName);
            }
        }

    }
}

