#pragma checksum "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9226c25cfb66c228472a6b63cc5939b47819a12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flores_Detalhes), @"mvc.1.0.view", @"/Views/Flores/Detalhes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9226c25cfb66c228472a6b63cc5939b47819a12", @"/Views/Flores/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9baf52d5b23377a3f952389103eb04130c98448d", @"/Views/_ViewImports.cshtml")]
    public class Views_Flores_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Flor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detalhes da ");
#nullable restore
#line 7 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Detalhes.cshtml"
           Write(Model.Especie);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<p>");
#nullable restore
#line 8 "C:\Users\woman\Desktop\Orientacao a objetos\Floricultura\AtividadeFloricultura\Views\Flores\Detalhes.cshtml"
Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flor> Html { get; private set; }
    }
}
#pragma warning restore 1591