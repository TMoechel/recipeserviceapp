using System;

namespace TM.FoodApp.Services.RecipeCatalog.Models.Api
{
    public class RecipeDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
