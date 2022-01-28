using System;
using Microsoft.AspNetCore.Mvc;

namespace formando_devs_api.Controllers
{
    [Route("/api/calculator")]
    public class CalculatorController : Controller
    {
        [HttpGet]
        [Route("square/{number}")]
        public ActionResult<float> Get(double number)
        {
            Console.WriteLine(number);
            return Ok( Math.Sqrt(number));
        }

    }
}
