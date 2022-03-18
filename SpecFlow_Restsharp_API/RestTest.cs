using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Restsharp_API
{
    internal class RestTest
    {
        private RestRequest request;
        private RestResponse response;
        private RestClient client;

        [Test]
        public async Task TestAPIAsync()
        {
            client = new RestClient("https://reqres.in/api/users/2");
            request = new RestRequest()
            {
                Method = Method.Get
            };
            
            //To get the response 
            response = await client.ExecuteAsync(request);
            int i = (int)response.StatusCode;
            Assert.AreEqual(200, i, "Not Success");
        }

        [Test]
        public async Task TestAPI_Post()
        {
            client = new RestClient("https://reqres.in/api/users");
            request = new RestRequest()
            {
                Method = Method.Post
            };
            request.AddBody(new CreateUserReq
            {
                job = "QA",
                name = "Sunit"
            });
            response = await client.ExecuteAsync(request);
            int i = ((int)response.StatusCode);
            Assert.AreEqual(201, i, "Not Success");
        }

        private class CreateUserReq
        {
            public string job { get; set; }
            public string name { get; set; }
        }
    }
}
