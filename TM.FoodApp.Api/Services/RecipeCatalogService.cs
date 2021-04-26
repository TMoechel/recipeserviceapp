using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TM.FoodApp.Api.Extensions;
using TM.FoodApp.Api.Models.Api;

namespace TM.FoodApp.Api.Services
{
    public class RecipeCatalogService : IRecipeCatalogService
    {
        private readonly HttpClient client;

        public RecipeCatalogService(HttpClient client)
        {
            this.client = client;
        }
        public async Task<IEnumerable<Recipe>> GetAll()
        {
            var response = await client.GetAsync("api/recipe");
            var result = await response.ReadContentAs<List<Recipe>>();
            return result;
        }
    }
}
