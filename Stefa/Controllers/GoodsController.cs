using System;
using System.Threading.Tasks;
using System.Linq;

using Microsoft.AspNetCore.Mvc;


namespace Stefa.Controllers
{
    public class GoodsController : Controller
    {

        [HttpGet]
        async public Task<IActionResult> Get()
        {
            return NoContent();
        }


        [HttpPost]
        async public Task<IActionResult> AddNewGoods()
        {
            return NoContent();
        }


        [HttpPut]
        async public Task<IActionResult> Put()
        {
            return NoContent();
        }
    }
}
