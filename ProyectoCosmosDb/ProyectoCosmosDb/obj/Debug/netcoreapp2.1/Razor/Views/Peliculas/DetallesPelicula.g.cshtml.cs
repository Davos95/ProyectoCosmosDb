#pragma checksum "C:\Users\AlumnoMCSD\source\Github\ProyectoCosmosDb\ProyectoCosmosDb\ProyectoCosmosDb\Views\Peliculas\DetallesPelicula.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12605ba86241190e80d570d952ce5ff67b251858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Peliculas_DetallesPelicula), @"mvc.1.0.view", @"/Views/Peliculas/DetallesPelicula.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Peliculas/DetallesPelicula.cshtml", typeof(AspNetCore.Views_Peliculas_DetallesPelicula))]
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
#line 1 "C:\Users\AlumnoMCSD\source\Github\ProyectoCosmosDb\ProyectoCosmosDb\ProyectoCosmosDb\Views\_ViewImports.cshtml"
using ProyectoCosmosDb;

#line default
#line hidden
#line 1 "C:\Users\AlumnoMCSD\source\Github\ProyectoCosmosDb\ProyectoCosmosDb\ProyectoCosmosDb\Views\Peliculas\DetallesPelicula.cshtml"
using ProyectoCosmosDb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12605ba86241190e80d570d952ce5ff67b251858", @"/Views/Peliculas/DetallesPelicula.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be927c3616b904b9f868c6a4e3d0d03dfd1f4b7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Peliculas_DetallesPelicula : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pelicula>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VerPeliculas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\AlumnoMCSD\source\Github\ProyectoCosmosDb\ProyectoCosmosDb\ProyectoCosmosDb\Views\Peliculas\DetallesPelicula.cshtml"
  
    ViewData["Title"] = "DetallesPeliculas";

#line default
#line hidden
            BeginContext(104, 177, true);
            WriteLiteral("\r\n<h2>Detalles Pelicula</h2>\r\n\r\n<div>\r\n    <h4>Pelicula</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Id\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(282, 8, false);
#line 18 "C:\Users\AlumnoMCSD\source\Github\ProyectoCosmosDb\ProyectoCosmosDb\ProyectoCosmosDb\Views\Peliculas\DetallesPelicula.cshtml"
       Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(290, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Titulo\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(383, 12, false);
#line 24 "C:\Users\AlumnoMCSD\source\Github\ProyectoCosmosDb\ProyectoCosmosDb\ProyectoCosmosDb\Views\Peliculas\DetallesPelicula.cshtml"
       Write(Model.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(395, 101, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Titulo Original\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(497, 20, false);
#line 30 "C:\Users\AlumnoMCSD\source\Github\ProyectoCosmosDb\ProyectoCosmosDb\ProyectoCosmosDb\Views\Peliculas\DetallesPelicula.cshtml"
       Write(Model.TituloOriginal);

#line default
#line hidden
            EndContext();
            BeginContext(517, 94, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Sinopsis\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(612, 14, false);
#line 36 "C:\Users\AlumnoMCSD\source\Github\ProyectoCosmosDb\ProyectoCosmosDb\ProyectoCosmosDb\Views\Peliculas\DetallesPelicula.cshtml"
       Write(Model.Sinopsis);

#line default
#line hidden
            EndContext();
            BeginContext(626, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Genero\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(719, 12, false);
#line 42 "C:\Users\AlumnoMCSD\source\Github\ProyectoCosmosDb\ProyectoCosmosDb\ProyectoCosmosDb\Views\Peliculas\DetallesPelicula.cshtml"
       Write(Model.Genero);

#line default
#line hidden
            EndContext();
            BeginContext(731, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Imagen\r\n        </dt>\r\n        <dd>\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 827, "\"", 846, 1);
#line 48 "C:\Users\AlumnoMCSD\source\Github\ProyectoCosmosDb\ProyectoCosmosDb\ProyectoCosmosDb\Views\Peliculas\DetallesPelicula.cshtml"
WriteAttributeValue("", 833, Model.Imagen, 833, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(847, 84, true);
            WriteLiteral(" style=\"width:130px; height:200px\" />\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(932, 74, false);
#line 53 "C:\Users\AlumnoMCSD\source\Github\ProyectoCosmosDb\ProyectoCosmosDb\ProyectoCosmosDb\Views\Peliculas\DetallesPelicula.cshtml"
Write(Html.ActionLink("Editar", "EditPelicula", new {  idPelicula = Model.Id  }));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1014, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efe9eddc02fd4647be0c39b87279f866", async() => {
                BeginContext(1043, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1059, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pelicula> Html { get; private set; }
    }
}
#pragma warning restore 1591
