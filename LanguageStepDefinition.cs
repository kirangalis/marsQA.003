using MarsQA_003.Pages;
using MarsQA_003.Utilities;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace MarsQA_003.StepDefinitions
{
    [Binding]
    public class LanguagePageStepDefinition : CommonDriver
    {
        
        //IWebDriver driver = new ChromeDriver();
        //LoginPage loginPageobj= new LoginPage();
        ProfilePage profilePageobj = new ProfilePage();
        LanguagePage languagePageobj = new LanguagePage();
       

        [Given(@"I logged into site successfully")]
        public void GivenILoggedIntoSiteSuccessfully()
        {


            //loginPageobj = new LoginPage();
            //loginPageobj.LoginSteps(driver);

        }
        [When(@"I navigate languagepage in profile page")]
        public void WhenINavigateLanguagepageInProfilePage()
        {
            ProfilePage profilePageobj = new ProfilePage();
            profilePageobj.profiletabClick(driver);
            languagePageobj.LanguagetabClick(driver);


        }
        [When(@"I added a new language record")]
        public void WhenIAddedANewLanguageRecord()
        {

           
            languagePageobj.AddLanguage(driver);
            

        }

        [Then(@"the record should added successfully")]
        public void ThenTheRecordShouldAddedSuccessfully()
        {

            string newLanguage = languagePageobj.GetActualLanguage(driver);
            Assert.That(newLanguage == "telugu", "actual language and expected language do not match");

        }

        [When(@"I Edit credential in profile page")]
        public void WhenIEditCredentialInProfilePage()


        {

            LanguagePage LanguagePageobj = new LanguagePage();
             languagePageobj.EditLanguage(driver);

        }
        [Then(@"Record should be edited successfully")]
        public void ThenRecordShouldBeEditedSuccessfully()
        {

            languagePageobj = new LanguagePage();

            string newEditLanguage = languagePageobj.GetUpdatedLanguage(driver).ToString();
            Assert.That(newEditLanguage == "Hindi", "actual language and expected language do not match");



        }        
        [When(@"I deleted credential in language")]
        public void WhenIDeletedCredentialInLanguage()
        { 
            
            
            languagePageobj.DeleteLanguage(driver);

        }
        [Then(@"language should be delete successfully")]
        public void ThenLanguageShouldBeDeleteSuccessfully()
        {

            //languagePageobj = new LanguagePage();


            string GetDeleteLanguage = languagePageobj.GetDeleteLanguage(driver);
            Assert.That(GetDeleteLanguage != "Hindi", "actual language has been deleted successfully");


        }



    }
}


























