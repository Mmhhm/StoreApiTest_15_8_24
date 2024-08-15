using Microsoft.AspNetCore.Mvc;
using StoreApiTest_15_8_24.Model;
namespace StoreApiTest_15_8_24.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class StoreController : Controller
    {


        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            //Define your baseUrl
            string baseUrl = $"https://fakestoreapi.com/products";

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseUrl))
                {
                    using (HttpContent content = res.Content)
                    {
                        var data = await content.ReadAsStringAsync();

                        if (data == null)
                        {
                            return NotFound();
                        }
                        return Ok(data);
                    }
                }
            }
        }
    }


}




