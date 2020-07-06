using System;
using System.Net.Http;

namespace SpicyRecipesApi.IntegrationTests
{
    public class BaseSteps
    {
        private HttpClient _client;

        public HttpClient Client
        {
            get
            {
                if (_client == null)
                {
                    _client = new HttpClient
                    {
                        BaseAddress = new Uri("https://localhost:44372")
                    };
                }

                return _client;
            }
        }
    }
}