#pragma checksum "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\AnswerSheet.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3bdcc3158d09ac760799b521c563939ea537e84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnswerSheets_AnswerSheet), @"mvc.1.0.view", @"/Views/AnswerSheets/AnswerSheet.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AnswerSheets/AnswerSheet.cshtml", typeof(AspNetCore.Views_AnswerSheets_AnswerSheet))]
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
#line 1 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\_ViewImports.cshtml"
using Brainzzler;

#line default
#line hidden
#line 2 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\_ViewImports.cshtml"
using Brainzzler.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3bdcc3158d09ac760799b521c563939ea537e84", @"/Views/AnswerSheets/AnswerSheet.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ea5b3403c4bd34db91360874e4e66643ed6959", @"/Views/_ViewImports.cshtml")]
    public class Views_AnswerSheets_AnswerSheet : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Brainzzler.Models.AnswerSheet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("AnswerSheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AnswerSheet", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "new", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Model.Id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\AnswerSheet.cshtml"
                                                                              
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(174, 30, true);
            WriteLiteral("\r\n<h4 class=\"col-sm-10\">\r\n    ");
            EndContext();
            BeginContext(205, 41, false);
#line 9 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\AnswerSheet.cshtml"
Write(Html.DisplayFor(model => model.Test_Name));

#line default
#line hidden
            EndContext();
            BeginContext(246, 42, true);
            WriteLiteral("\r\n</h4>\r\n<br />\r\n<div class=\"container\">\r\n");
            EndContext();
            BeginContext(479, 284, true);
            WriteLiteral(@"
    <div class=""jumbotron banner text-center"" style="" background-image: url(../images/header_home.png);margin-bottom:0;"">
        <div style=""vertical-align: middle; display: inline-block; text-align: left; margin-left: 10px;"">
            <h1 class=""col-sm-10"">
                ");
            EndContext();
            BeginContext(764, 45, false);
#line 22 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\AnswerSheet.cshtml"
           Write(Html.DisplayFor(model => model.Question_Text));

#line default
#line hidden
            EndContext();
            BeginContext(809, 84, true);
            WriteLiteral("\r\n            </h1>\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n");
            EndContext();
#line 28 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\AnswerSheet.cshtml"
         foreach (var item in Model.Question_Answers)
        {

#line default
#line hidden
            BeginContext(959, 37, true);
            WriteLiteral("            <div class=\"col-sm-12\">\r\n");
            EndContext();
            BeginContext(1132, 93, true);
            WriteLiteral("\r\n                <button type=\"button\" class=\"btn-block AnswerButton\">\r\n                    ");
            EndContext();
            BeginContext(1226, 41, false);
#line 34 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\AnswerSheet.cshtml"
               Write(Html.DisplayFor(modelItem => item.Answer));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 49, true);
            WriteLiteral("\r\n                </button>\r\n            </div>\r\n");
            EndContext();
#line 42 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\AnswerSheet.cshtml"
                        
        }

#line default
#line hidden
            BeginContext(1606, 33, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1639, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3bdcc3158d09ac760799b521c563939ea537e848068", async() => {
                BeginContext(1734, 6, true);
                WriteLiteral("Напред");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\AnswerSheet.cshtml"
                                                                                      Model.Id++;

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1749, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(1755, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3bdcc3158d09ac760799b521c563939ea537e8410671", async() => {
                BeginContext(1859, 6, true);
                WriteLiteral("Напред");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("{", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("+", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("1", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("}", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1874, 19, true);
            WriteLiteral("\r\n    <p>\r\n        ");
            EndContext();
            BeginContext(1894, 68, false);
#line 51 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\AnswerSheet.cshtml"
   Write(Html.ActionLink("Forward", "AnswerSheet", new { id = Model.Id + 1 }));

#line default
#line hidden
            EndContext();
            BeginContext(1962, 136, true);
            WriteLiteral("\r\n    </p>\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(2657, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Brainzzler.Models.AnswerSheet> Html { get; private set; }
    }
}
#pragma warning restore 1591
