using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Projeto6.Models;

namespace Projeto6.Controllers {
	public class HomeController : PrincipalController {

		public IActionResult Index() {
			return View();
		}

		public IActionResult Erro() {
			return View();
		}
	}
}
