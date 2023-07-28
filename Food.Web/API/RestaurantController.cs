using Food.Data.Models;
using Food.Data.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Food.Web.API
{
    public class RestaurantController : ApiController
    {
        private readonly IRestaurantData db;

        public RestaurantController(IRestaurantData db)
        {
            this.db = db;
        }
        public IEnumerable<Restaurant> Get()
        {
            var model = db.GetAll();
            return model;
        }
    }
}
