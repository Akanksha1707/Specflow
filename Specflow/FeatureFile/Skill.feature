Feature: Skill
	

Scenario: add skill
	Given i click on Skill tab in profile page
	When i Add a new Skill where Skill name is "CurrentSkill" and Skill Type is "Beginner" 
	Then the Skill should be displayed on the list

Scenario: edit skill
	Given i click on Skill tab in profile page
	When i Edit a Skill where Skill name is "CurrentSkill" to "NewSkill" and update the Skill Type to "Expert"
	Then the Value should be Edited on my listings

Scenario: remove skill
	Given i Click on skill tab in profile page
	When i Delete a skill where Skill name is "NewSkill" and Skill Type is "Expert"
	Then The Value should be deleted on my listings