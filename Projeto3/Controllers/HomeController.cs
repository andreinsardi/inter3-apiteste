using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto3.Controllers {
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public class HomeController : Controller {

		public IActionResult Index() {
			ViewBag.Descricao = "Uma string";
			ViewBag.QuantidadeDeRepeticoes = 20;
			ViewBag.Liberado = true;

			return View();
		}

		public IActionResult Erro() {
			return View();
		}
	}
}
