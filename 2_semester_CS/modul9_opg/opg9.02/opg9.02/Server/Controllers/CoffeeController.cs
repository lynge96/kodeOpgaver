using Microsoft.AspNetCore.Mvc;
using opg9._02.Shared;
using Newtonsoft;
using Newtonsoft.Json;

namespace opg9._02.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<ShoppingItem> Get()
        {
            List<ShoppingItem> items;
            using (StreamReader r = new StreamReader("coffeeDrinks.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<ShoppingItem>>(json);

            }
            return items;
        }

    }
}