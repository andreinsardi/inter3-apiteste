using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Controllers {
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public class HomeController : Controller {

		public IActionResult Index() {
			return View();
		}

		public IActionResult Erro() {
			return View();
		}
	}
}
