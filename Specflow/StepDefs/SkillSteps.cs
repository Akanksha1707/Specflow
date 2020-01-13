using System;
using Specflow.Pages;
using TechTalk.SpecFlow;

namespace Specflow.StepDefs
{
    [Binding]
    public class SkillSteps : Utilities.Start
    {

        SkillsPage skillsPageObj = new SkillsPage();


        [Given(@"i click on Skill tab in profile page")]
        public void GivenIClickOnSkillTabInProfilePage()
        {
            skillsPageObj.SelectSkillTab();
        }
        
        [Given(@"i Click on skill tab in profile page")]
        public void GiveniClickOnSkillTabInProfilePage()
        {
            skillsPageObj.SelectSkillTab();
        }
        
        [When(@"i Add a new Skill where Skill name is ""(.*)"" and Skill Type is ""(.*)""")]
        public void WhenIAddANewSkillWhereSkillNameIsAndSkillTypeIs(string SkillName, string SkillType)
        {
            skillsPageObj.AddSkill(SkillName, SkillType);
        }
        
        [When(@"i Edit a Skill where Skill name is ""(.*)"" and Skill Type is ""(.*)""")]
        public void WhenIEditASkillWhereSkillNameIsAndSkillTypeIs(string SkillName, string SkillType)
        {
            
        }

        [When(@"i Edit a Skill where Skill name is ""(.*)"" to ""(.*)"" and update the Skill Type to ""(.*)""")]
        public void WhenIEditASkillWhereSkillNameIsToAndUpdateTheSkillTypeTo(string CurrentSkillName, string NewSkillName, string SkillType)
        {
            skillsPageObj.EditSkill(CurrentSkillName, SkillType, NewSkillName );
        }

        [When(@"i Delete a skill where Skill name is ""(.*)"" and Skill Type is ""(.*)""")]
        public void WhenIDeleteASkillWhereSkillNameIsAndSkillTypeIs(string SkillName, string SkillType)
        {
            skillsPageObj.RemoveSkill(SkillName, SkillType);
        }
        
        [Then(@"the Skill should be displayed on the list")]
        public void ThenTheSkillShouldBeDisplayedOnTheList()
        {
            
        }
        
        [Then(@"the Value should be Edited on my listings")]
        public void ThenTheValueShouldBeEditedOnMyListings()
        {
            
        }
        
        [Then(@"The Value should be deleted on my listings")]
        public void ThenTheValueShouldBeDeletedOnMyListings()
        {
           
        }
    }
}
