using FluentAssertions;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SpicyRecipesApi.Models;
using TechTalk.SpecFlow;

namespace SpicyRecipesApi.IntegrationTests
{
    [Binding]
    public class RecipesFeatureSteps : BaseSteps
    {
        private HttpResponseMessage _response;
        private Recipe[] _recipes;

        [Given(@"An API endpoint for getting Recipes")]
        public async Task GivenAnAPIEndpointForGettingRecipes()
        {
            // Arrange
            _response = await Client.GetAsync("/api/Recipes/All");
        }
        
        [When(@"I get the recipes")]
        public async Task WhenIGetTheRecipes()
        {
            // Act
            var content = await _response.Content.ReadAsStringAsync();
            _recipes = JsonConvert.DeserializeObject<Recipe[]>(content);
        }
        
        [Then(@"It should return (.*) recipes")]
        public void ThenItShouldReturnRecipes(int count)
        {
            // Assert
            _recipes.Length.Should().Be(count);
        }
    }
}
