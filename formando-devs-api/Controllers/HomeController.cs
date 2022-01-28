using System;
using Microsoft.AspNetCore.Mvc;

namespace formando_devs_api.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Formando Devs API Running.");
        }

    }
}
