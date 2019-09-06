using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto5.Controllers {
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	[Route("api/[controller]")]
	[ApiController]
	public class PessoaRestController : ControllerBase {

		// GET: api/Pessoa
		[HttpGet]
		public IEnumerable<Pessoa> Get() {
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

			return pessoas;
		}

		// GET: api/Pessoa/5
		[HttpGet("{id}", Name = "Get")]
		public Pessoa Get(int id) {
			Pessoa pessoa = null;

			if (id == 1) {
				pessoa = new Pessoa() {
					Id = 1,
					Nome = "Teste",
					Peso = 10
				};
			}

			return pessoa;
		}

		// POST: api/Pessoa (Criar algo novo)
		[HttpPost]
		public void Post([FromBody] Pessoa pessoa) {
			// Validar os dados e criar a pessoa no banco de dados
		}

		// PUT: api/Pessoa (Salvar/Editar algo existente)
		[HttpPut()]
		public void Put([FromBody] Pessoa pessoa) {
			// Validar os dados e alterar a pessoa no banco de dados
		}

		// DELETE: api/Pessoa/5
		[HttpDelete("{id}")]
		public void Delete(int id) {
			// Excluir a pessoa do banco de dados
		}
	}
}
