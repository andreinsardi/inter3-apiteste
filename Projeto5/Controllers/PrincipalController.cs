using Microsoft.AspNetCore.Mvc;
using Projeto5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto5.Controllers {
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public class PrincipalController : Controller {

		public string App_Data {
			get {
				return AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
			}
		}

		public string CaminhoFotos(int id) {
			return System.IO.Path.Combine(App_Data, "Fotos", id + ".jpg");
		}
	}
}
