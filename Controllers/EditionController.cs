using Checkpoint_3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint_3.Controllers
{
    public class EditionController : Controller
    {
        private readonly Edition _edition;
        public EditionController (Edition editions)
        {
            _edition = editions;
        }


        [HttpGet]


        public IActionResult Index()
        {
            return View();
        }
    }
}
