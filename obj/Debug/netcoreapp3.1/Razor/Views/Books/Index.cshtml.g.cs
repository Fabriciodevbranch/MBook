#pragma checksum "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b256a6b736de22bb26f0d83b721577d27d86a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
#line 1 "/home/fhenrique/Documentos/projeto/MBook/Views/_ViewImports.cshtml"
using MBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/fhenrique/Documentos/projeto/MBook/Views/_ViewImports.cshtml"
using MBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b256a6b736de22bb26f0d83b721577d27d86a2", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1063fcf8d07f5464bdbf9407d099323b13c7bdcf", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MBook.Models.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("textHv"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
  
    ViewData["Title"] = "Projects Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div id=\"mensagem\"></div>\n");
#nullable restore
#line 7 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">");
#nullable restore
#line 9 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
                                Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 10 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
 if (TempData["Error"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">");
#nullable restore
#line 13 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
                               Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 14 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
 if (TempData["Warning"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">");
#nullable restore
#line 17 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
                                Write(TempData["Warning"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 18 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
 if (TempData["Info"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\">");
#nullable restore
#line 21 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
                             Write(TempData["Info"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
#nullable restore
#line 22 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <h2>Projetos</h2>\n    </div>\n</div>\n<hr />\n    ");
#nullable restore
#line 30 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
Write(Html.ActionLink("Novo Projeto",  "Create","Books", new { @class = "btn btn-sm btn-success" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<hr />\n<div class=\"card-group\">\n    \n");
#nullable restore
#line 34 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card mb-3 bg-light"" style=""min-width: 18rem;max-width: 540px;margin:5px;"">
            <div class=""row no-gutters"">
                <div class=""col-md-4 containerHv"">
                      <div class=""middleHv"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2b256a6b736de22bb26f0d83b721577d27d86a27912", async() => {
                WriteLiteral("<i class=\"fas fa-search\"></i>Open");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n                      </div>\n                    <img");
            BeginWriteAttribute("src", " src = \'", 1199, "\'", 1222, 1);
#nullable restore
#line 42 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
WriteAttributeValue("", 1207, item.CoverPath, 1207, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  alt = \"Cover\" class=\"imageHv\" style=\"width: 100%; height:250;\"/>\n                </div>\n                <div class=\"col-md-8\">\n                    <div class=\"card-body\">\n                        <h5 class=\"card-title\">");
#nullable restore
#line 46 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
                                          Write(Html.DisplayFor(modelItem=> item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                        <p class=\"card-text\">");
#nullable restore
#line 47 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
                                        Write(Html.DisplayFor(modelItem => item.Resume));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 48 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.LastEdit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\n                    </div>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 53 "/home/fhenrique/Documentos/projeto/MBook/Views/Books/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MBook.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
