using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace desenvolvimentoweb.Controllers
{
    [Route("[controller]")]
    public class TesteController : Controller
    {
        private readonly ILogger<TesteController> _logger;

        public TesteController(ILogger<TesteController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       [HttpPost]       
       public IActionResult Index(string name, string password)
       {
            string receiveName = name;
            string receivePassword = password;

            //salvar no banco de dados
            return View();
       }
    }
}