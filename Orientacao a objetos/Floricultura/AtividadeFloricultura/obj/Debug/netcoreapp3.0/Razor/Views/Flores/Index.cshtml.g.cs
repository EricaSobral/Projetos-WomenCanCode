#pragma checksum "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40b8edf6e9f973ce1c14c3c3bf14d562605de36c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flores_Index), @"mvc.1.0.view", @"/Views/Flores/Index.cshtml")]
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
#line 1 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\_ViewImports.cshtml"
using AtividadeFloricultura;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\_ViewImports.cshtml"
using AtividadeFloricultura.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40b8edf6e9f973ce1c14c3c3bf14d562605de36c", @"/Views/Flores/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9baf52d5b23377a3f952389103eb04130c98448d", @"/Views/_ViewImports.cshtml")]
    public class Views_Flores_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Flor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Flores</h1>\r\n<a href=\"/Flores/Criar\"> Adicionar flor</a>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>");
#nullable restore
#line 12 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Index.cshtml"
   Write(item.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 12 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Index.cshtml"
                   Write(item.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <p><strong>");
#nullable restore
#line 13 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Index.cshtml"
          Write(item.Preco);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>");
#nullable restore
#line 13 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Index.cshtml"
                              Write(item.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n       <a class=\"btn btn-primary\"");
            BeginWriteAttribute("type", "type=\"", 290, "\"", 296, 0);
            EndWriteAttribute();
            BeginWriteAttribute("href", " href=\"", 297, "\"", 329, 2);
            WriteAttributeValue("", 304, "/Flores/Detalhes/", 304, 17, true);
#nullable restore
#line 14 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Index.cshtml"
WriteAttributeValue("", 321, item.Id, 321, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Detalhes flor</a>\r\n");
#nullable restore
#line 15 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Index.cshtml"
   
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Flor>> Html { get; private set; }
    }
}
#pragma warning restore 1591