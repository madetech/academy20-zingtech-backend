using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Xunit.Abstractions;

namespace backend_testsv1.integration
{
    public class IntegrationTests: IClassFixture<WebApplicationFactory<academy20_zingtech_backend.Startup>>
    {
        private readonly HttpClient _httpClient;

        public IntegrationTests(WebApplicationFactory<academy20_zingtech_backend.Startup> factory, ITestOutputHelper testOutputHelper)
        {
            _httpClient = factory.CreateClient();
        }

        [Fact]
        public async Task GetEmployeeDataList()
        {

            // ACT
            var response = await _httpClient.GetAsync($"https://localhost:8080/api/employeedata/1");
            // ASSERT

            //response.EnsureSuccessStatusCode();
            var stringResponse = await response.Content.ReadAsStringAsync();

            stringResponse.Should().Contain("");

        }
    }
    
    
}