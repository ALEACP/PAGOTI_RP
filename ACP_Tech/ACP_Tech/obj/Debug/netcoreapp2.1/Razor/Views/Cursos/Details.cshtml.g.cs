#pragma checksum "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\Cursos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb385e6814da1d1f557087544d99e40f3a54dc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cursos_Details), @"mvc.1.0.view", @"/Views/Cursos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cursos/Details.cshtml", typeof(AspNetCore.Views_Cursos_Details))]
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
#line 1 "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\_ViewImports.cshtml"
using ACP_Tech;

#line default
#line hidden
#line 2 "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\_ViewImports.cshtml"
using ACP_Tech.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb385e6814da1d1f557087544d99e40f3a54dc1", @"/Views/Cursos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ba4f9f377233e13b45476eda1d2ca7ebaa7643c", @"/Views/_ViewImports.cshtml")]
    public class Views_Cursos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ACP_Tech.Models.Curso>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\Cursos\Details.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(76, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(83, 17, false);
#line 7 "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\Cursos\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(100, 90, true);
            WriteLiteral("</h2>\r\n\r\n<div>    \r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(191, 45, false);
#line 13 "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NomeCurso));

#line default
#line hidden
            EndContext();
            BeginContext(236, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(280, 41, false);
#line 16 "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeCurso));

#line default
#line hidden
            EndContext();
            BeginContext(321, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(365, 41, false);
#line 19 "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(406, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(450, 37, false);
#line 22 "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(487, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(531, 48, false);
#line 25 "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\Cursos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CargaHoraria));

#line default
#line hidden
            EndContext();
            BeginContext(579, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(623, 44, false);
#line 28 "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\Cursos\Details.cshtml"
       Write(Html.DisplayFor(model => model.CargaHoraria));

#line default
#line hidden
            EndContext();
            BeginContext(667, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(714, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a54e3eb0803495b9affd3c5ce1316c1", async() => {
                BeginContext(760, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "D:\ESTUDOS\REPOSITÓRIO GIT\PAGOTI_RP\ACP_Tech\ACP_Tech\Views\Cursos\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(770, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(778, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e44dd90761f4505995bd7b04b82b576", async() => {
                BeginContext(800, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(810, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ACP_Tech.Models.Curso> Html { get; private set; }
    }
}
#pragma warning restore 1591
