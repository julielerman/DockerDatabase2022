using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Agilistas;
using Agilistas.Controllers;
using AgilistaTracker;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using Xunit;

namespace ModelTests {
    //test controller action with database
    public class IntegrationTests : IClassFixture<WebApplicationFactory<Program>> {
        private readonly WebApplicationFactory<Program> _factory;

        public IntegrationTests (WebApplicationFactory<Program> factory) {
            _factory = factory;
        }

        [Theory]
        [InlineData ("/api/values")]
       public async Task ValuesControllerDefaultReturnsJson (string url) {
            // Arrange
            var client = _factory.CreateClient ();

            // Act
            var response = await client.GetAsync (url);

            // Assert
            response.EnsureSuccessStatusCode (); // Status Code 200-299
            Assert.Equal ("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString ());
        }

        [Theory]
        [InlineData ("/api/values")]
        public async Task ValuesControllerDefaultReturnsExpectedResults (string url) {
            // Arrange
            var client = _factory.CreateClient ();

            // Act
            var response = await client.GetAsync (url);

            // Assert
            response.EnsureSuccessStatusCode (); // Status Code 200-299
            Assert.Equal ("[\"value1\",\"value2\"]",
                response.Content.ReadAsStringAsync ().Result);
        }

        [Theory]
        [InlineData ("/api/agilistas")]
        public async Task AgilistasControllerDefaultReturnsExpectedResults (string url) {
            // Arrange
            var client = _factory.CreateClient ();

            // Act
            var response = await client.GetAsync (url);

            // Assert
            response.EnsureSuccessStatusCode (); // Status Code 200-299
            var result = JsonConvert.DeserializeObject<List<Agilista>> (response.Content.ReadAsStringAsync ().Result);

            Assert.Single (result.Where (a => a.Name == "Julie Lerman").ToList ());
        }
    }
}