using MarsQA_003.Pages;
using TechTalk.SpecFlow;
using NUnit.Framework;
using MarsQA_003.Utilities;

namespace MarsQA_003.StepDefinitions
{
    [Binding]
    public class SkillsPageStepDefinition : CommonDriver
    {
        //IWebDriver driver = new ChromeDriver();
        //LoginPage loginPageobj = new LoginPage();
        ProfilePage profilePageobj = new ProfilePage();
        SkillsPage skillsPageObj = new SkillsPage();

        [Given(@"I logged into site successfully")]
        public void GivenILoggedIntoSiteSuccessfully()
        {


            //loginPageobj = new LoginPage();
            //loginPageobj.LoginSteps(driver);

        }    //   Add a record
        [When(@"I navigate skillspage in profile page")]
        public void WhenINavigateSkillspageInProfilePage()
        {

            ProfilePage profilePageobj = new ProfilePage();
            profilePageobj.profiletabClick(driver);
            skillsPageObj.SkillstabClick(driver);


        }
        [When(@"I added a new skills record")]
        public void WhenIAddedANewSkillsRecord()
        {

            skillsPageObj.addSkills(driver);
               

        }

        [Then(@"the the skill record should add new record successfully")]
        public void ThenTheTheSkillRecordShouldAddNewRecordSuccessfully()

        {

                string newSkills = skillsPageObj.GetaddSkills(driver);
                Assert.That(newSkills == "Testing", "actual skill and expected skill did not match");


                string newLevel = skillsPageObj.GetaddLevel(driver);
                Assert.That(newLevel == "Excellent", "actual level and expected level did not match");


        }

        [When(@"I edit existing skills record")]
        public void WhenIEditExistingSkillsRecord()

        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.EditSkills(driver);

        }
        [Then(@"the record should be edited successfully")]
        public void ThenTheRecordShouldBeEditedSuccessfully()
        {


            SkillsPage skillsPageObj = new SkillsPage();
            string updatedSkills = skillsPageObj.GeteditSkills(driver);
            Assert.That(updatedSkills == "Tamil", "record not updated");



           string editLevel = skillsPageObj.GeteditLevel(driver);
           Assert.That(editLevel == "begineer", "actual degree and expected degree did not match");


        }

        [When(@"I delete a skills record  which is edited")]
        public void WhenIDeleteASkillsRecordWhichIsEdited()
        {
            SkillsPage skillsPageObj = new SkillsPage();
            skillsPageObj.DeleteSkills(driver);

        }
        [Then(@"the skills record should be delete successfully")]
        public void ThenTheSkillsRecordShouldBeDeleteSuccessfully()
        {



                string GetDeleteSkills = skillsPageObj.GetDeleteSkills(driver);
                Assert.That(GetDeleteSkills != "Tamil", "actual language has been deleted successfully");


                string GetDeleteLevel = skillsPageObj.GetDeleteLevel(driver);
                Assert.That(GetDeleteLevel != "Begineer", "actual language has been deleted successfully");



        }

    }
 
}


