using Microsoft.AspNetCore.Mvc;
using Projeto5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto5.Controllers {
	// Perceba que aqui não precisamos utilizar o atributo [ResponseCache],
	// pois ele já se encontra na classe BaseController
	public class SimplesController : PrincipalController {

		public IActionResult Index() {
			// Para utilizar uma view de outra controller...
			// (Ou poderíamos simplesmente deixar Index dentro de Shared...)
			return View("~/Views/Home/Index.cshtml");
		}

		public IActionResult ObterFotoPessoa(int id, bool forcarDownload) {
			if (id == 1) {
				if (forcarDownload == true) {
					Response.Headers.Add("Content-Disposition", "attachment; filename=\"Perfil.jpg\"");
				}

				// Como estamos utilizando herança, podemos acessar atributos e métodos da
				// classe pai, melhorando a legibilidade e reaproveitamento de código
				System.IO.FileStream stream = new System.IO.FileStream(CaminhoFotos(id), System.IO.FileMode.Open);
				return new FileStreamResult(stream, "image/jpeg");
			}

			return NotFound(); // 404
		}
	}
}
