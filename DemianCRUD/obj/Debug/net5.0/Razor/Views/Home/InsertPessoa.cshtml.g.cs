#pragma checksum "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1a27e6cc2096a47e517964ba706d5ec49432523"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InsertPessoa), @"mvc.1.0.view", @"/Views/Home/InsertPessoa.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1a27e6cc2096a47e517964ba706d5ec49432523", @"/Views/Home/InsertPessoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f888b9e13e08ae47b736e4fa25f254af3e92bc5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InsertPessoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DemianCRUD.Models.Pessoa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
  
    ViewData["Title"] = "Insira Uma Pessoa";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Use this page to detail your site\'s privacy policy.</p>\r\n\r\n\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
 using (Html.BeginForm())
{


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.nome));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 35 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 38 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.email));

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 42 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.telefone));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.telefone));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 46 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.habilitacao));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.habilitacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 51 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
     if (true)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
   Write(Html.LabelFor(model => model.categoria));

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
   Write(Html.EditorFor(model => model.categoria));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 56 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.listLinguaEstrangeira));

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
     if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
       Write(Html.DropDownList("Testando",
          new SelectList(Model.listLinguaEstrangeira), "Selecione Lingua", "Text"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
                                                                                  
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 68 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.estado));

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 72 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.cidade));

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.cidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 76 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.cep));

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.cep));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 80 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.logadouro));

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.logadouro));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 83 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.numero));

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.numero));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 87 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.complemento));

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.complemento));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 91 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.cargo));

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.cargo));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 95 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.LabelFor(model => model.salarioProposto));

#line default
#line hidden
#nullable disable
#nullable restore
#line 96 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"
Write(Html.EditorFor(model => model.salarioProposto));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <input type=\"submit\" value=\"Inserir\">\r\n");
#nullable restore
#line 101 "C:\Users\Avansys\Documents\Demian Estudo Crud C#\CRUDc-\DemianCRUD\Views\Home\InsertPessoa.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemianCRUD.Models.Pessoa> Html { get; private set; }
    }
}
#pragma warning restore 1591
