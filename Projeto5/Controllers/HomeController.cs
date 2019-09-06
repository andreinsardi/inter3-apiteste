using Microsoft.AspNetCore.Mvc;
using Projeto5.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto5.Controllers {
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public class HomeController : Controller {

		public IActionResult Index() {
			return View();
		}

		public IActionResult ListarPessoas() {
			List<Pessoa> pessoas = new List<Pessoa>();
			pessoas.Add(new Pessoa() {
				Id = 1,
				Nome = "Teste",
				Peso = 10
			});
			pessoas.Add(new Pessoa() {
				Id = 2,
				Nome = "Teste 2",
				Peso = 20
			});
			pessoas.Add(new Pessoa() {
				Id = 3,
				Nome = "Teste 3",
				Peso = 30
			});

			return new JsonResult(pessoas);
		}

		public IActionResult ProcurarPessoa(int id) {
			Pessoa pessoa = null;

			if (id == 1) {
				pessoa = new Pessoa() {
					Id = 1,
					Nome = "Teste",
					Peso = 10
				};
			}

			return new JsonResult(pessoa);
		}

		public IActionResult ObterFotoPessoa(int id, bool forcarDownload) {
			if (id == 1) {
				if (forcarDownload == true) {
					Response.Headers.Add("Content-Disposition", "attachment; filename=\"Perfil.jpg\"");
				}

				string app_Data = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
				string arquivo = System.IO.Path.Combine(app_Data, "Fotos", id + ".jpg");

				// Normalmente, quando utilizamos arquivos, temos que fechar o arquivo no final,
				// para liberar memória etc...
				// Aqui não precisamos fazer isso, pois a classe FileStreamResult faz isso por nós:
				// https://github.com/ASP-NET-MVC/aspnetwebstack/blob/master/src/System.Web.Mvc/FileStreamResult.cs
				System.IO.FileStream stream = new System.IO.FileStream(arquivo, System.IO.FileMode.Open);
				return new FileStreamResult(stream, "image/jpeg");
			}

			return NotFound(); // 404
		}

		public IActionResult ObterBytesGenericos() {
			// Suponha que nossos dados não estivessem em um arquivo do servidor,
			// mas em outro lugar, como o banco de dados ou em um armazenamento na nuvem

			byte[] bytes = new byte[] { 48, 49, 50, 65, 66, 67 };

			return new FileContentResult(bytes, "text/plain");
		}

		public IActionResult Erro() {
			return View();
		}
	}
}
