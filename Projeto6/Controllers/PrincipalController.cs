using Microsoft.AspNetCore.Mvc;
using Projeto6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto6.Controllers {
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public class PrincipalController : Controller {

		public string App_Data {
			get {
				return AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
			}
		}

		public IActionResult Erro(string mensagem) {
			return new ContentResult() {
				Content = mensagem,
				ContentType = "text/plain",
				StatusCode = 500
			};
		}

		public string CaminhoFotos(int id) {
			return System.IO.Path.Combine(App_Data, "Fotos", id + ".jpg");
		}
	}
}
