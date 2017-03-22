﻿using Microsoft.AspNetCore.Mvc;

namespace JoshOlsonCore.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Index() => View();

        [Route("error")]
        public IActionResult Error() => View();
    }
}
