#pragma checksum "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/Sisteminha/_Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec1e83e46bf4df9f344dcc4e9f45bcb031ede0dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sisteminha__Listar), @"mvc.1.0.view", @"/Views/Sisteminha/_Listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sisteminha/_Listar.cshtml", typeof(AspNetCore.Views_Sisteminha__Listar))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/_ViewImports.cshtml"
using Projeto6;

#line default
#line hidden
#line 2 "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/_ViewImports.cshtml"
using Projeto6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec1e83e46bf4df9f344dcc4e9f45bcb031ede0dd", @"/Views/Sisteminha/_Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12480f842ab3bf5b810aa065d1981530e00d087e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sisteminha__Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Pessoa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 293, true);
            WriteLiteral(@"
<table class=""table table-striped table-hover table-row-pointer"" id=""tabela"">
	<thead>
		<tr>
			<th></th>
			<th>Id</th>
			<th>Nome</th>
			<th>Nascimento</th>
			<th>Peso</th>
			<th data-orderable=""false""></th>
			<th data-orderable=""false""></th>
		</tr>
	</thead>
	<tbody>
");
            EndContext();
#line 16 "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/Sisteminha/_Listar.cshtml"
         if (Model != null) {
			foreach (Pessoa pessoa in Model) {

#line default
#line hidden
            BeginContext(378, 50, true);
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td class=\"col-min\"><img alt=\"Foto\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 428, "\"", 488, 1);
#line 19 "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/Sisteminha/_Listar.cshtml"
WriteAttributeValue("", 434, Url.Action("ObterFotoPessoa", new { id = pessoa.Id }), 434, 54, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(489, 31, true);
            WriteLiteral(" height=\"75\" /></td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(521, 9, false);
#line 20 "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/Sisteminha/_Listar.cshtml"
                   Write(pessoa.Id);

#line default
#line hidden
            EndContext();
            BeginContext(530, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(547, 11, false);
#line 21 "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/Sisteminha/_Listar.cshtml"
                   Write(pessoa.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(558, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(575, 40, false);
#line 22 "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/Sisteminha/_Listar.cshtml"
                   Write(pessoa.Nascimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(615, 16, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
            EndContext();
            BeginContext(632, 11, false);
#line 23 "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/Sisteminha/_Listar.cshtml"
                   Write(pessoa.Peso);

#line default
#line hidden
            EndContext();
            BeginContext(643, 75, true);
            WriteLiteral("</td>\r\n\t\t\t\t\t<td class=\"col-min\"><button class=\"btn btn-outline btn-primary\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 718, "\"", 746, 3);
            WriteAttributeValue("", 728, "editar(", 728, 7, true);
#line 24 "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/Sisteminha/_Listar.cshtml"
WriteAttributeValue("", 735, pessoa.Id, 735, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 745, ")", 745, 1, true);
            EndWriteAttribute();
            BeginContext(747, 125, true);
            WriteLiteral(" title=\"Editar\"><i class=\"fa fa-edit\"></i></button></td>\r\n\t\t\t\t\t<td class=\"col-min\"><button class=\"btn btn-outline btn-danger\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 872, "\"", 907, 4);
            WriteAttributeValue("", 882, "excluir(", 882, 8, true);
#line 25 "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/Sisteminha/_Listar.cshtml"
WriteAttributeValue("", 890, pessoa.Id, 890, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 900, ",", 900, 1, true);
            WriteAttributeValue(" ", 901, "this)", 902, 6, true);
            EndWriteAttribute();
            BeginContext(908, 71, true);
            WriteLiteral(" title=\"Excluir\"><i class=\"fa fa-times\"></i></button></td>\r\n\t\t\t\t</tr>\r\n");
            EndContext();
#line 27 "/Volumes/HDMemory-/source/ESPM/inter3/inter3-apiteste/Projeto6/Views/Sisteminha/_Listar.cshtml"
			}
		}

#line default
#line hidden
            BeginContext(990, 21, true);
            WriteLiteral("\t</tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
