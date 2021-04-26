using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TM.FoodApp.Api.Models.Api;

namespace TM.FoodApp.Api.Services
{

    public interface IRecipeCatalogService
    {
        Task<IEnumerable<Recipe>> GetAll();
    }
}
