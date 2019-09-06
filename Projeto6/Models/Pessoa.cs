using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto6.Models {
	public class Pessoa {
		public int Id { get; set; }
		public string Nome { get; set; }
		public DateTime Nascimento { get; set; }
		public double Peso { get; set; }

		public string Validar() {
			if (string.IsNullOrWhiteSpace(Nome)) {
				return "Nome inválido!";
			}

			if (Nascimento.Year == 0 || Nascimento > DateTime.Now) {
				return "Nascimento inválido!";
			}

			if (Peso < 0) {
				return "Peso inválido!";
			}

			return null;
		}
	}
}
