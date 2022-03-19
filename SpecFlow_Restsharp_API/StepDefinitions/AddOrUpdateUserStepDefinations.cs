using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Restsharp_API.StepDefinitions
{
    internal class AddOrUpdateUserStepDefinations
    {

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

    }
}
