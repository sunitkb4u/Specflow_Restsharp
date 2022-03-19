using System;
using TechTalk.SpecFlow;

namespace SpecFlow_Restsharp_API.StepDefinitions
{
    [Binding]
    public class UserManagmentStepDefinitions
    {
        [Given(@"User enters user id (.*)")]
        public void GivenUserEntersUserId(int id)
        {
            throw new PendingStepException();
        }

        [When(@"User send get user request")]
        public void WhenUserSendGetUserRequest()
        {
            throw new PendingStepException();
        }

        [Then(@"User validates details (.*) (.*) and http response code (.*)")]
        public void ThenUserValidatesDetailsJanetWeaverAndHttpResponseCode(string firstName, string lastName, int httpCode)
        {
            throw new PendingStepException();
        }

        [Given(@"User entrs job ().*")]
        public void GivenUserEntrsJobTester(string job)
        {
            throw new PendingStepException();
        }

        [Given(@"User enters role(.*)")]
        public void GivenUserEntersRoleAPITest(string role)
        {
            throw new PendingStepException();
        }

        [When(@"User send create user request")]
        public void WhenUserSendCreateUserRequest()
        {
            throw new PendingStepException();
        }

        [Then(@"user should get created")]
        public void ThenUserShouldGetCreated()
        {
            throw new PendingStepException();
        }

        [Given(@"user want to update user id (.*)")]
        public void GivenUserWantToUpdateUserId(int id)
        {
            throw new PendingStepException();
        }

        [When(@"User send update user request")]
        public void WhenUserSendUpdateUserRequest()
        {
            throw new PendingStepException();
        }

        [Then(@"user should get updated")]
        public void ThenUserShouldGetUpdated()
        {
            throw new PendingStepException();
        }

        [Given(@"User enters job user id (.*)")]
        public void GivenUserEntrsJobUserId(int id)
        {
            throw new PendingStepException();
        }

        [When(@"User send delete user request")]
        public void WhenUserSendDeleteUserRequest()
        {
            throw new PendingStepException();
        }

        [Then(@"Validate iser should get deleted (.*)")]
        public void ThenValidateIserShouldGetDeletedHttpCode(int httpCode)
        {
            throw new PendingStepException();
        }
    }
}
