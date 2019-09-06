using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto6 {
	public class Startup {
		public Startup(IConfiguration configuration) {
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services) {
			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env) {
			if (env.IsDevelopment()) {
				app.UseDeveloperExceptionPage();
			} else {
				app.UseExceptionHandler("/Home/Erro");
			}

			app.UseHsts();
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseMvc(routes => {
				routes.MapRoute(
					name: "default",
					template: "{controller=Sisteminha}/{action=Index}");
			});

			// Algo como C:\Users\Aluno\Desktop\Projeto\Projeto6
			string caminho = env.ContentRootPath;
			// Não concatene strings manualmente para juntar pastas e arquivos, porque
			// no Windows usamos "\", mas no Linux, usamos "/"...
			// Por isso o System.IO.Path.Combine!!!
			AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Path.Combine(caminho, "App_Data"));

			// Outros atributos interessantes:
			// env.ApplicationName ("Projeto5")
			// env.EnvironmentName ("Development")
			// env.WebRootPath (Caminho para a pasta wwwroot, como C:\Users\Aluno\Desktop\Projeto\Projeto6\wwwroot)
		}
	}
}
