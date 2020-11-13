using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using Xunit.Abstractions;

namespace backend_tests.integration
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
            // var terms = JsonSerializer.Deserialize<List<EmployeeDatum>>(stringResponse, new JsonSerializerOptions
            // {
            //     PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            // });

            stringResponse.Should().Contain("");

        }
    }
    
    
}