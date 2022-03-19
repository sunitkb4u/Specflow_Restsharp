using RestSharp;
using SpecFlow_Restsharp_API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlow_Restsharp_API.HelperClass
{
    public class RequestHelper
    {
        private RestClient client;
        private RestRequest request;
        private RestResponse response;
        public RestClient SetUrl(string baseUrl, string endPoint)
        {
            //To combine complete url
            var url = Path.Combine(endPoint, baseUrl);
            client = new RestClient(url);
            return client;
        }

        public RestRequest CreateGetRequest()
        {
            request = new RestRequest();
            request.Method = Method.Get;
            request.AddHeader("Accept", "application/json");
            return request;
        }

        public RestRequest CreatePostRequest( CreateUserReq payload)
        {
            request = new RestRequest();
            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");
            //Add payload
            request.AddBody(payload);
            // To set the request format in json
            request.RequestFormat=DataFormat.Json;
            return request;
        }

        public RestRequest CreatePutRequest(CreateUserReq payload)
        {
            request = new RestRequest();
            request.Method = Method.Put;
            request.AddHeader("Accept", "application/json");
            //Add payload
            request.AddBody(payload);
            // To set the request format in json
            request.RequestFormat = DataFormat.Json;
            return request;
        }

        public RestRequest CreateDeleteRequest()
        {
            request = new RestRequest();
            request.Method = Method.Delete;
            request.AddHeader("Accept", "application/json");
            return request;
        }

        public async Task<RestResponse> ExecuteAPI(RestClient restClient, RestRequest restRequest)
        {
            return await restClient.ExecuteAsync(restRequest);
        }
    }
}
