using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FitnessApp.Services
{
    public class FitnessDataStoreClient
    {
        private readonly IHttpClientFactory _httpFactory;
        public FitnessDataStoreClient(IHttpClientFactory factoryInstance)
        {
            _httpFactory = factoryInstance;
        }
    }
}
