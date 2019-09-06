using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto6.Models;

namespace Projeto6.Controllers {
	//***************************************************************************************
	// Todos os métodos daqui são de mentirinha...
	// Eles servem para fazer de conta que estamos acessando um banco de dados de verdade!
	//***************************************************************************************
	public class SisteminhaController : PrincipalController {

		private List<Pessoa> ObterListaPessoas() {
			List<Pessoa> pessoas = new List<Pessoa>();
			pessoas.Add(new Pessoa() {
				Id = 1,
				Nome = "Teste",
				Nascimento = new DateTime(2017, 10, 18),
				Peso = 10
			});
			pessoas.Add(new Pessoa() {
				Id = 2,
				Nome = "Teste 2",
				Nascimento = new DateTime(1990, 5, 8),
				Peso = 20
			});
			pessoas.Add(new Pessoa() {
				Id = 3,
				Nome = "Teste 3",
				Nascimento = new DateTime(2000, 12, 5),
				Peso = 30,
			});

			return pessoas;
		}

		public IActionResult Index() {
			List<Pessoa> pessoas = ObterListaPessoas();
			return View(pessoas);
		}

		public IActionResult Listar() {
			List<Pessoa> pessoas = ObterListaPessoas();
			return PartialView("_Listar", pessoas);
		}

		public IActionResult Criar() {
			ViewBag.Criando = true;
			return PartialView("_CriarEditar");
		}

		public IActionResult Editar(int id) {
			Pessoa pessoa = null;

			if (id == 1) {
				pessoa = new Pessoa() {
					Id = 1,
					Nome = "Teste",
					Nascimento = new DateTime(2017, 10, 18),
					Peso = 10
				};
			}

			return PartialView("_CriarEditar", pessoa);
		}

		[HttpPost]
		public IActionResult Gravar([FromForm] Pessoa pessoa) {
			string mensagem = null;
			if (pessoa == null) {
				mensagem = "Dados inválidos!";
			} else {
				mensagem = pessoa.Validar();
			}

			if (mensagem != null) {
				return Erro(mensagem);
			}

			// Para validar o arquivo de foto
			IFormFile foto = null;
			if (Request.Form.Files.Count > 0) {
				// Se o usuário enviou uma foto, vamos verificá-la!
				foto = Request.Form.Files[0];
				if (foto.Length > 1 * 1024 * 1024) {
					return Erro("A foto deve ter no máximo 1 MiB!");
				}

				if (foto.ContentType != "image/jpeg") {
					return Erro("A foto deve ser um arquivo JPG!");
				}

				try {
					using (Stream stream = foto.OpenReadStream()) {
						using (Bitmap bmp = (Bitmap)Image.FromStream(stream)) {
							if (bmp.Width > 1000 || bmp.Height > 1000) {
								return Erro("A foto deve ter dimensões máximas de 1000x1000!");
							}
						}
					}
				} catch {
					return Erro("Formato de foto inválido!");
				}
			}

			// Verificaria se pessoa.Id == 0 para decidir se estamos criando
			// uma pessoa nova, ou alterando uma já existente

			// Já de posse do id da pessoa, caso ela tenha sido criada,
			// precisamos salvar a foto, caso ela tenha sideo enviada
			if (foto != null) {
				try {
					using (Stream stream = foto.OpenReadStream()) {
						using (Stream streamGravacao = new FileStream(CaminhoFotos(pessoa.Id), FileMode.Create)) {
							stream.CopyTo(streamGravacao);
						}
					}
				} catch {
					return Erro("Formato de foto inválido!");
				}
			}

			return Ok();
		}

		public IActionResult Excluir(int id) {
			// Deveríamos ir até o banco excluir a pessoa...
			return Ok();
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
