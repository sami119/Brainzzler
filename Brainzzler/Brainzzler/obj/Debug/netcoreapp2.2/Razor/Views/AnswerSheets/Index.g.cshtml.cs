#pragma checksum "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "981907c001b3825b645259bd4306d8724c6bd09e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnswerSheets_Index), @"mvc.1.0.view", @"/Views/AnswerSheets/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AnswerSheets/Index.cshtml", typeof(AspNetCore.Views_AnswerSheets_Index))]
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
#line 1 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\_ViewImports.cshtml"
using Brainzzler;

#line default
#line hidden
#line 2 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\_ViewImports.cshtml"
using Brainzzler.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"981907c001b3825b645259bd4306d8724c6bd09e", @"/Views/AnswerSheets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4ea5b3403c4bd34db91360874e4e66643ed6959", @"/Views/_ViewImports.cshtml")]
    public class Views_AnswerSheets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Brainzzler.Models.AnswerSheet>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(170, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "981907c001b3825b645259bd4306d8724c6bd09e4827", async() => {
                BeginContext(193, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(207, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(300, 42, false);
#line 17 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(342, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(398, 44, false);
#line 20 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(442, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(498, 42, false);
#line 23 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TestId));

#line default
#line hidden
            EndContext();
            BeginContext(540, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(596, 45, false);
#line 26 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Test_Name));

#line default
#line hidden
            EndContext();
            BeginContext(641, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(697, 46, false);
#line 29 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.QuestionId));

#line default
#line hidden
            EndContext();
            BeginContext(743, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(799, 49, false);
#line 32 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Question_Text));

#line default
#line hidden
            EndContext();
            BeginContext(848, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(904, 44, false);
#line 35 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AnswerId));

#line default
#line hidden
            EndContext();
            BeginContext(948, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1004, 42, false);
#line 38 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Answer));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1102, 42, false);
#line 41 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Chosen));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1200, 43, false);
#line 44 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Correct));

#line default
#line hidden
            EndContext();
            BeginContext(1243, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 50 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1361, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1410, 41, false);
#line 53 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(1451, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1507, 43, false);
#line 56 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(1550, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1606, 41, false);
#line 59 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TestId));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1703, 44, false);
#line 62 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Test_Name));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1803, 45, false);
#line 65 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.QuestionId));

#line default
#line hidden
            EndContext();
            BeginContext(1848, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1904, 48, false);
#line 68 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Question_Text));

#line default
#line hidden
            EndContext();
            BeginContext(1952, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2008, 43, false);
#line 71 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AnswerId));

#line default
#line hidden
            EndContext();
            BeginContext(2051, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2107, 41, false);
#line 74 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Answer));

#line default
#line hidden
            EndContext();
            BeginContext(2148, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2204, 41, false);
#line 77 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Chosen));

#line default
#line hidden
            EndContext();
            BeginContext(2245, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2301, 42, false);
#line 80 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Correct));

#line default
#line hidden
            EndContext();
            BeginContext(2343, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2398, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "981907c001b3825b645259bd4306d8724c6bd09e15254", async() => {
                BeginContext(2443, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            BeginContext(2451, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2471, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "981907c001b3825b645259bd4306d8724c6bd09e17610", async() => {
                BeginContext(2519, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            BeginContext(2530, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2550, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "981907c001b3825b645259bd4306d8724c6bd09e19972", async() => {
                BeginContext(2597, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            BeginContext(2607, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 88 "D:\My-Zone\IT-Zone\Repos\Brainzzler\Brainzzler\Brainzzler\Views\AnswerSheets\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2646, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Brainzzler.Models.AnswerSheet>> Html { get; private set; }
    }
}
#pragma warning restore 1591
