using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TM.FoodApp.Api.Models.View;
using TM.FoodApp.Api.Services;

namespace TM.FoodApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecipeCatalogController : ControllerBase
    {
        private readonly ILogger<RecipeCatalogController> _logger;
        private readonly IRecipeCatalogService recipeCatalogService;

        public RecipeCatalogController(IRecipeCatalogService recipeCatalogService, ILogger<RecipeCatalogController> logger)
        {
            this.recipeCatalogService = recipeCatalogService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<RecipeViewModel>> GetRecipes()
        {
            var recipeList = await recipeCatalogService.GetAll();
            return (IEnumerable<RecipeViewModel>)recipeList;
        }
    }
}
