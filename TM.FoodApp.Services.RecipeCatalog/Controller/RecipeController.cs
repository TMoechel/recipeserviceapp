using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TM.FoodApp.Services.RecipeCatalog.Models;
using TM.FoodApp.Services.RecipeCatalog.Models.Api;

namespace TM.FoodApp.Services.RecipeCatalog.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        //public async Task<ActionResult<IEnumerable<Models.RecipeDto>>> Get(
        public IEnumerable<RecipeDto> Get()
        {
            //var result = await _eventRepository.GetEvents(categoryId);
            //return Ok(_mapper.Map<List<Models.RecipeDto>>(result));
            return new List<RecipeDto>
            {
                new RecipeDto() {Description = "Fry Meet and serve with french potatos", Title="Tasty Hamburger"},
                new RecipeDto() {Description = "Fry Chicken and add lots of curry", Title="Tasty Chicken"},
            };
        }
    }
}
