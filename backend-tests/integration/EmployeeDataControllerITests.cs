using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
//using NUnit.Framework;
using Xunit;
using academy20_zingtech_backend;

namespace backend_tests.integration
{
    public class IntegrationTests: IClassFixture<WebApplicationFactory<academy20_zingtech_backend.Startup>>
    {
        private readonly HttpClient _httpClient;

        public IntegrationTests(WebApplicationFactory<academy20_zingtech_backend.Startup> factory)
        {
            _httpClient = factory.CreateClient();
        }
    }
}