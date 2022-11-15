using DrinksInfo.Models;
using Newtonsoft.Json;
using RestSharp;

namespace DrinksInfo
{
    internal class DrinksService
    {
        public void GetCategories()
        {
            var client = new RestClient("http://www.thecocktaildb.com/api/json/v1/1");
            var request = new RestRequest("list.php?c=list");
            var response = client.ExecuteAsync(request);

            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Result.Content;
                var serialize = JsonConvert.DeserializeObject<Categories>(rawResponse);
                List<Category> returnList = serialize.CategoriesList;
                TableVisualisationEngine.ShowTable<Category>(returnList, "Categories");
            }
        }

        public void GetDrinksByCategory(string category)
        {
            var client = new RestClient("http://www.thecocktaildb.com/api/json/v1/1");
            var request = new RestRequest($"filter.php?c={category}");
            var response = client.ExecuteAsync(request);

            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var rawResponse = response.Result.Content;
                var serialize = JsonConvert.DeserializeObject<Drinks>(rawResponse);
                List<Drink> returnList = serialize.DrinksList;
                TableVisualisationEngine.ShowTable<Drink>(returnList, $"{category} Drinks");
            }
        }
    }
}