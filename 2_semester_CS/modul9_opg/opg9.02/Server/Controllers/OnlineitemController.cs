using Microsoft.AspNetCore.Mvc;
using opg9._02.Shared;
using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Net.Http;


namespace opg9._02.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OnlineitemController : ControllerBase
    {

        [HttpGet]
        public static async Task<IEnumerable<Onlineitem>> GetAsync()
        {
            String url = "https://fakestoreapi.com/products";

            HttpClient client = new HttpClient();
            try
            {
                string response = await client.GetStringAsync(url);

                dynamic liste = JsonConvert.DeserializeObject(response);

                List<Onlineitem> onlineitems = new List<Onlineitem>();

                foreach (var obj in liste)
                {
                    float price = (float)obj["price"];
                    Onlineitem item = new Onlineitem(price, $"{obj["description"]}", $"{obj["category"]}", $"{obj["title"]}", false);

                    onlineitems.Add(item);
                }
                return onlineitems;
            } catch (HttpRequestException e)
            {
                return null;
            }
            

        }
    }
}