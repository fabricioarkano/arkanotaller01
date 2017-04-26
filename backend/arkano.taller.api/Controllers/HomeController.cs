namespace arkano.taller.api.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/Home")]
    public class HomeController : Controller
    {
        public string GetHome()
        {
            return "Rock & Roll!";
        }
    }
}