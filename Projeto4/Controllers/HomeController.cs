using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Projeto4.Models;

namespace Projeto4.Controllers {
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	public class HomeController : Controller {

		public IActionResult Index(Pessoa pessoa) {
			// Tente chamar a action Index das seguntes formas:
			// - Apenas com o endereço: https://localhost:xxx
			// - Passando os valores através da query string (GET): https://localhost:xxx/?Id=1&Nome=Teste&Peso=70.5
			// - Passando um JSON no corpo de uma requisição POST: https://localhost:xxx
			// - Passando form-data ou x-www-form-urlencoded no corpo de uma requisição POST: https://localhost:xxx
			// (Compare com o que ocorre em IndexNovo e IndexMaisNovo)

			ViewBag.pessoa = pessoa;

			return View();
		}

		[HttpPost]
		public IActionResult IndexNovo([FromBody] Pessoa pessoa) {
			// Tente chamar a action IndexNovo das seguntes formas:
			// - Apenas com o endereço: https://localhost:xxx/Home/IndexNovo
			// - Passando os valores através da query string (GET): https://localhost:xxx/Home/IndexNovo/?Id=1&Nome=Teste&Peso=70.5
			// - Passando um JSON no corpo de uma requisição POST: https://localhost:xxx/Home/IndexNovo
			// - Passando form-data ou x-www-form-urlencoded no corpo de uma requisição POST: https://localhost:xxx/Home/IndexNovo
			// (Compare com o que ocorre em Index e IndexMaisNovo)

			ViewBag.pessoa = pessoa;

			return View("Index");
		}

		[HttpPost]
		public IActionResult IndexMaisNovo([FromForm] Pessoa pessoa) {
			// Tente chamar a action IndexMaisNovo das seguntes formas:
			// - Apenas com o endereço: https://localhost:xxx/Home/IndexMaisNovo
			// - Passando os valores através da query string (GET): https://localhost:xxx/Home/IndexMaisNovo/?Id=1&Nome=Teste&Peso=70.5
			// - Passando um JSON no corpo de uma requisição POST: https://localhost:xxx/Home/IndexMaisNovo
			// - Passando form-data ou x-www-form-urlencoded no corpo de uma requisição POST: https://localhost:xxx/Home/IndexMaisNovo
			// (Compare com o que ocorre em Index e IndexNovo)

			ViewBag.pessoa = pessoa;

			return View("Index");
		}

		public IActionResult OutraFormaDeEnvio(int id, string nome, double peso) {
			// Para chamar a action OutraFormaDeEnvio (GET):
			// https://localhost:xxx/Home/OutraFormaDeEnvio/?id=1&nome=Teste&peso=70.5

			Pessoa pessoa = new Pessoa();
			pessoa.Id = id;
			pessoa.Nome = nome;
			pessoa.Peso = peso;

			ViewBag.pessoa = pessoa;

			return View("Index");
		}

		// Para mais informações sobre rotas:
		// https://docs.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-2.1
		[Route("[controller]/[action]/{id}/{nome}/{peso}")]
		public IActionResult MaisUmaFormaDeEnvio(int id, string nome, double peso) {
			// Para chamar a action MaisUmaFormaDeEnvio (GET):
			// https://localhost:xxx/Home/MaisUmaFormaDeEnvio/1/Teste/70.5

			// Para quem gosta de economizar tempo (isso não funciona em Java...)
			Pessoa pessoa = new Pessoa() {
				Id = id,
				Nome = nome,
				Peso = peso
			};

			ViewBag.pessoa = pessoa;

			return View("Index");
		}

		public IActionResult Erro() {
			return View();
		}
	}
}
