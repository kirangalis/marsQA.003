using MarsQA_003.Pages;
using MarsQA_003.Utilities;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace MarsQA_003.StepDefinitions
{
    [Binding]
    public class EducationPageStepDefinition : CommonDriver
    {
        
       
        ProfilePage profilePageobj = new ProfilePage();
        EducationPage educationPageobj = new EducationPage();

        [Given(@"I logged into web site successfully")]
        public void GivenILoggedIntoWebSiteSuccessfully()
        {

            

        }
        [When(@"I navigate Educationpage in profile page")]
        public void WhenINavigateEducationpageInProfilePage()

        {


            ProfilePage profilePageobj = new ProfilePage();
            profilePageobj.profiletabClick(driver);
            educationPageobj.EducationtabClick(driver);


        }
        // Add a new record
        [When(@"I added new record in education page")]
        public void WhenIAddedNewRecordInEducationPage()

        {

            educationPageobj.AddEducation(driver);

        }
        [Then(@"it should add a new record in education page successfully\.")]
        public void ThenItShouldAddANewRecordInEducationPageSuccessfully_()

        {
            string newCollage = educationPageobj.GetActualCollage(driver);
            Assert.That(newCollage == "ACCollage", "actual collage and expected collage did not match");


            string newDegree = educationPageobj.GetActualDegree(driver);
            Assert.That(newDegree == "Bacholors", "actual degree and expected degree did not match");

            string newCountry = educationPageobj.GetActualCountry(driver);
            Assert.That(newCountry == "india", "actual country and expected coutry did not match");

            string newYear = educationPageobj.GetActualYear(driver);
            Assert.That(newYear == "2000", "actual year and expected year do not match");


            string newTitle = educationPageobj.GetActualTitle(driver);
            Assert.That(newTitle == "BA", "actual level and expected level do not match");


        }
         // edit
        [When(@"I edited existing record  in education page\.")]
        public void WhenIEditedExistingRecordInEducationPage_()
        {

            educationPageobj.EditEducation(driver);
        }

        [Then(@"it should edited the record succesfully\.")]
        public void ThenItShouldEditedTheRecordSuccesfully_()

        {
            string EditedCollage = educationPageobj.GetUpdatedCollage(driver);
            Assert.That(EditedCollage == "HinduCollage", "actual collage and expected collage did not match");


            string EditedDegree = educationPageobj.GetUpdatedDegree(driver);
            Assert.That(EditedDegree == "masters", "actual degree and expected degree did not match");

            string EditedCountry = educationPageobj.GetUpdatedCountry(driver);
            Assert.That(EditedCountry == "Newzealand", "actual country and expected coutry did not match");

            string EditedYear = educationPageobj.GetUpdatedYear(driver);
            Assert.That(EditedYear == "2005", "actual year and expected year do not match");


            string EditedTitle = educationPageobj.GetUpdatedTitle(driver);
            Assert.That(EditedTitle == "MBA", "actual Title and expected Title did not match");


        }                     
        [When(@"I delete the existing record\.")]
        public void WhenIDeleteTheExistingRecord_()

        {

            educationPageobj.DeleteEducation(driver);

        }
        [Then(@"it should delete the selected record successfully\.")]
        public void ThenItShouldDeleteTheSelectedRecordSuccessfully_()

        {
            

            string GetDeletedEducation = educationPageobj.GetDeletedEducation(driver);
            Assert.That(GetDeletedEducation != "MBA", "actual language has been deleted successfully");



        }

    }
}
