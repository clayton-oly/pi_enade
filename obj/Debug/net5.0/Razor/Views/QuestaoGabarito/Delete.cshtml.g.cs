#pragma checksum "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0ccbcb1203336ea954ec7cdb8ff8e1777c4c4cb24c8e3b1308d33d03a8cc2cb4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QuestaoGabarito_Delete), @"mvc.1.0.view", @"/Views/QuestaoGabarito/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\DEV\projeto-enade\ProjetoEnade\Views\_ViewImports.cshtml"
using ProjetoEnade;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DEV\projeto-enade\ProjetoEnade\Views\_ViewImports.cshtml"
using ProjetoEnade.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"0ccbcb1203336ea954ec7cdb8ff8e1777c4c4cb24c8e3b1308d33d03a8cc2cb4", @"/Views/QuestaoGabarito/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a89736548a41e1b7b148a4f8ed1a75269c5ff831da9f356185d9d5bf8a1088da", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_QuestaoGabarito_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoEnade.Models.QuestaoGabarito>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Excluir</h1>\n\n<h3>Você tem certeza que quer excluir?</h3>\n<div>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 14 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DescricaoProva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 17 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DescricaoProva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 20 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Enunciado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 23 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Enunciado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 26 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EnunciadoImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            <img");
            BeginWriteAttribute("src", " src=\"", 755, "\"", 791, 1);
#nullable restore
#line 29 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
WriteAttributeValue("", 761, ViewBag.EnunciadoImageDataURL, 761, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" width=\"150\" />\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 32 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoProva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 35 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DescricaoTipoProva));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 38 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.QuestoesDisciplinas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 41 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DescricaoDisciplinas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 44 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DificuldadeQuestao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 47 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DescricaoDificuldadeQuestao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n\n");
#nullable restore
#line 51 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
          
            if (Model.DescricaoTipoProva.ToLower() == "múltipla escolha")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 55 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 58 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayFor(model => model.RespostaA));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 61 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaAImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2048, "\"", 2084, 1);
#nullable restore
#line 64 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
WriteAttributeValue("", 2054, ViewBag.RespostaAImageDataURL, 2054, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" width=\"150\" />\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 67 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 70 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayFor(model => model.RespostaB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 73 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaBImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 2582, "\"", 2618, 1);
#nullable restore
#line 76 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
WriteAttributeValue("", 2588, ViewBag.RespostaBImageDataURL, 2588, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" width=\"150\" />\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 79 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 82 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayFor(model => model.RespostaC));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 85 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaCImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3116, "\"", 3152, 1);
#nullable restore
#line 88 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
WriteAttributeValue("", 3122, ViewBag.RespostaCImageDataURL, 3122, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" width=\"150\" />\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 91 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 94 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayFor(model => model.RespostaD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 97 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaDImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 3650, "\"", 3686, 1);
#nullable restore
#line 100 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
WriteAttributeValue("", 3656, ViewBag.RespostaDImageDataURL, 3656, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" width=\"150\" />\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 103 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 106 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayFor(model => model.RespostaE));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 109 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaEImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    <img");
            BeginWriteAttribute("src", " src=\"", 4184, "\"", 4220, 1);
#nullable restore
#line 112 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
WriteAttributeValue("", 4190, ViewBag.RespostaEImageDataURL, 4190, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" width=\"150\" />\n                </dd>\n                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 115 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaCorreta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 118 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayFor(model => model.DescricaoRespostaCorreta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n");
#nullable restore
#line 120 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
            }
            else if (Model.DescricaoTipoProva.ToLower() == "dissertativa")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-2\">\n                    ");
#nullable restore
#line 124 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayNameFor(model => model.RespostaDissertativa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dt>\n                <dd class=\"col-sm-10\">\n                    ");
#nullable restore
#line 127 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
               Write(Html.DisplayFor(model => model.RespostaDissertativa));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </dd>\n");
#nullable restore
#line 129 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ccbcb1203336ea954ec7cdb8ff8e1777c4c4cb24c8e3b1308d33d03a8cc2cb418525", async() => {
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0ccbcb1203336ea954ec7cdb8ff8e1777c4c4cb24c8e3b1308d33d03a8cc2cb418814", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 134 "D:\DEV\projeto-enade\ProjetoEnade\Views\QuestaoGabarito\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        <input type=\"submit\" value=\"Excluir\" class=\"btn btn-danger\" /> |\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ccbcb1203336ea954ec7cdb8ff8e1777c4c4cb24c8e3b1308d33d03a8cc2cb420613", async() => {
                    WriteLiteral("Voltar");
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
                WriteLiteral("\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoEnade.Models.QuestaoGabarito> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
