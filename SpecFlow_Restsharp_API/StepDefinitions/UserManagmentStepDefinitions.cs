using NUnit.Framework;
using RestSharp;
using SpecFlow_Restsharp_API.HelperClass;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_Restsharp_API.StepDefinitions
{
    [Binding]
    public class UserManagmentStepDefinitions
    {
        string endPoint = "api/users/";
        RestClient client;
        RestRequest request;
        RestResponse response;
        RequestHelper requestHelper = new RequestHelper();

        [Given(@"User enters user id (.*)")]
        public void GivenUserEntersUserId(int id)
        {
            endPoint=endPoint+id;
        }

        [When(@"User send get user request")]
        public void WhenUserSendGetUserRequest()
        {
            requestHelper.SetUrl(TestContext)
        }

        [Then(@"User validates details (.*) (.*) and http response code (.*)")]
        public void ThenUserValidatesDetailsJanetWeaverAndHttpResponseCode(string firstName, string lastName, int httpCode)
        {
            throw new PendingStepException();
        }

        [When(@"User send delete user request")]
        public void WhenUserSendDeleteUserRequest()
        {
            throw new PendingStepException();
        }

        [Then(@"Validate user should get deleted (.*)")]
        public void ThenValidateIserShouldGetDeletedHttpCode(int httpCode)
        {
            throw new PendingStepException();
        }
    }
}
