using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Domain;
using Newtonsoft.Json;
using RestSharp;

namespace BL
{
    public class HackTheFutureApi
    {
        private const string TEAMNAME = "TIMPIM";
        private const string SECRET = "PIMTIM";
        private RestClient _client;

        public HackTheFutureApi()
        {
            _client= new RestClient("https://htf2018.azurewebsites.net/");
        }
        
        public Response GetChallengeCodes()
        {
            var getRequest = new RestRequest("challenges", Method.GET);
            var challenge1 = _client.Execute<Challenge>(getRequest);

            var request = new RestRequest("challenges", Method.POST);

            var answer = new Answer()
            {
                ChallengeId = challenge1.Data.Id,
                Values = new List<InputValue>()
                {
                    new InputValue()
                    {
                        Data = TEAMNAME,
                        Name = "name"
                    },

                    new InputValue()
                    {
                        Data = SECRET,
                        Name = "secret"
                    }
                }
            };
            request.AddJsonBody(answer);
            var test = _client.Execute<Response>(request);
            return test.Data;
        }

        public Challenge RequestChallenge(string code)
        {
            var request = new RestRequest("challenges/{code}");
            request.AddUrlSegment("code", code); // replaces matching token in request.Resource

            request.AddHeader("htf-identification", GetChallengeCodes().Identification);

            return _client.Execute<Challenge>(request).Data;
        }

        public Response PostChallenge(string code, Answer answer)
        {
            var request = new RestRequest("challenges/{code}", Method.POST);
            request.AddUrlSegment("code", code); // replaces matching token in request.Resource
            request.AddJsonBody(answer);

            request.AddHeader("htf-identification", GetChallengeCodes().Identification);

            return _client.Execute<Response>(request).Data;
        }
    }
}
