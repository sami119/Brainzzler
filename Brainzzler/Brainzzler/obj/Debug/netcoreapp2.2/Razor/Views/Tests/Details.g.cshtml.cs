#pragma checksum "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c741152f43bc2f66c1a0b6e98c0015d5fbcad2a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tests_Details), @"mvc.1.0.view", @"/Views/Tests/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tests/Details.cshtml", typeof(AspNetCore.Views_Tests_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c741152f43bc2f66c1a0b6e98c0015d5fbcad2a7", @"/Views/Tests/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f1d9d069e295346ea1943bd543cccc9bbc58e12", @"/Views/_ViewImports.cshtml")]
    public class Views_Tests_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Brainzzler.Models.Test>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("StartGame"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none; color: white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n\n");
            EndContext();
#line 4 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Въпроси";

#line default
#line hidden
            BeginContext(96, 121, true);
            WriteLiteral("\n<div>\n    <h4>Тест</h4>\n    <hr />\n    <dl class=\"row\">\n        <dd class=\"col-sm-10\">\n            <h5>\n                ");
            EndContext();
            BeginContext(218, 41, false);
#line 15 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
           Write(Html.DisplayFor(model => model.Test_Name));

#line default
#line hidden
            EndContext();
            BeginContext(259, 94, true);
            WriteLiteral("\n            </h5>\n        </dd>\n    </dl>\n    <div id=\"quizz\" class=\"col-md-12 text-center\">\n");
            EndContext();
#line 20 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
         foreach (var question in Model.Questions)
        {

#line default
#line hidden
            BeginContext(414, 47, true);
            WriteLiteral("            <div class=\"question row\" data-id=\"");
            EndContext();
            BeginContext(462, 11, false);
#line 22 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
                                          Write(question.Id);

#line default
#line hidden
            EndContext();
            BeginContext(473, 108, true);
            WriteLiteral("\">\n                <div class=\"col-sm-12 text-center\" style=\"margin-bottom: 10px;\">\n                    <h2>");
            EndContext();
            BeginContext(582, 21, false);
#line 24 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
                   Write(question.QuestionText);

#line default
#line hidden
            EndContext();
            BeginContext(603, 29, true);
            WriteLiteral("</h2>\n                </div>\n");
            EndContext();
#line 26 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
                 foreach (var answer in question.Answers)
                {

#line default
#line hidden
            BeginContext(708, 138, true);
            WriteLiteral("                    <div class=\"col-sm-12 answer\">\n\n                        <button type=\"button\" class=\"answerButton btn-block\" data-id=\"");
            EndContext();
            BeginContext(847, 9, false);
#line 30 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
                                                                                 Write(answer.Id);

#line default
#line hidden
            EndContext();
            BeginContext(856, 20, true);
            WriteLiteral("\" data-question-id=\"");
            EndContext();
            BeginContext(877, 11, false);
#line 30 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
                                                                                                               Write(question.Id);

#line default
#line hidden
            EndContext();
            BeginContext(888, 23, true);
            WriteLiteral("\" data-question-score=\"");
            EndContext();
            BeginContext(912, 14, false);
#line 30 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
                                                                                                                                                  Write(question.Score);

#line default
#line hidden
            EndContext();
            BeginContext(926, 31, true);
            WriteLiteral("\">\n                            ");
            EndContext();
            BeginContext(958, 17, false);
#line 31 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
                       Write(answer.AnswerText);

#line default
#line hidden
            EndContext();
            BeginContext(975, 62, true);
            WriteLiteral("\n                        </button>\n                    </div>\n");
            EndContext();
#line 34 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"

                }

#line default
#line hidden
            BeginContext(1056, 19, true);
            WriteLiteral("            </div>\n");
            EndContext();
#line 37 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1085, 210, true);
            WriteLiteral("        <div class=\"submit-box\" style=\"display:none;\">\n            <p>Натиснете бутон \"Предай\", за да приключите с теста</p>\n            <buttton type=\"button\" class=\"StartGame\" id=\"submit-quizz\" data-test-id=\"");
            EndContext();
            BeginContext(1296, 8, false);
#line 40 "C:\Users\Rayna\source\repos\GitHub\sami\Brainzzler\Brainzzler\Brainzzler\Views\Tests\Details.cshtml"
                                                                                Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1304, 146, true);
            WriteLiteral("\">Предай</buttton>\n        </div>\n    </div>\n</div>\n<div class=\"row\">\n    <div class=\"col-sm-10\">\n\n    </div>\n    <div class=\"col-sm-2 \">\n        ");
            EndContext();
            BeginContext(1450, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c741152f43bc2f66c1a0b6e98c0015d5fbcad2a710091", async() => {
                BeginContext(1533, 5, true);
                WriteLiteral("Назад");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1542, 18, true);
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Brainzzler.Models.Test> Html { get; private set; }
    }
}
#pragma warning restore 1591
