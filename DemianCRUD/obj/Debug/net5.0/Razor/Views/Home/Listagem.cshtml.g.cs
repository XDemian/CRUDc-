#pragma checksum "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6a8efe17d23ed73137439262762541cb66e4afe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listagem), @"mvc.1.0.view", @"/Views/Home/Listagem.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\_ViewImports.cshtml"
using DemianCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\_ViewImports.cshtml"
using DemianCRUD.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6a8efe17d23ed73137439262762541cb66e4afe", @"/Views/Home/Listagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f888b9e13e08ae47b736e4fa25f254af3e92bc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DemianCRUD.Models.Pessoa>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
  
    ViewData["Title"] = "Listagem";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
 foreach (var items in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Lista com os Nomes </h3>\r\n");
            WriteLiteral("    <h3>Lista com os Nomes </h3>\r\n");
#nullable restore
#line 15 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 17 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 21 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 24 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.habilitacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 26 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 28 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.linguaEstrangeira);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 30 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 33 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.cidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 35 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 37 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.cep);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 39 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.logadouro);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 41 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.numero);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 44 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.complemento);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 46 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.cargo);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 48 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(items.salarioProposto);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 50 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(Html.Hidden("id", items.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 52 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
Write(Html.ActionLink("Editar", "Update", "Home", items));

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\Listagem.cshtml"
                                                       


}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DemianCRUD.Models.Pessoa>> Html { get; private set; }
    }
}
#pragma warning restore 1591
