using Microsoft.AspNetCore.Mvc;
using opg9._02.Shared;

namespace opg9._02.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NetflixNChillController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<ShoppingItem> Get() => SampleData.NetflixNChill;
    }
}