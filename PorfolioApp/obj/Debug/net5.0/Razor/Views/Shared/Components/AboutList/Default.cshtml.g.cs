#pragma checksum "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Shared\Components\AboutList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00ba0094120aafd3821de5e1b9523ccfddd88a3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_AboutList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/AboutList/Default.cshtml")]
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
#line 1 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\_ViewImports.cshtml"
using PorfolioApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\_ViewImports.cshtml"
using PorfolioApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Shared\Components\AboutList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00ba0094120aafd3821de5e1b9523ccfddd88a3b", @"/Views/Shared/Components/AboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3901bc2aa10f466a436e651d47d8a48ebde308f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_AboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<About>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar img-fluid mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Walter Patterson"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"section pt-4 px-3 px-lg-4\" id=\"about\">\r\n    <div class=\"container-narrow\">\r\n        \r\n            <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Shared\Components\AboutList\Default.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6\">\r\n                    <h2 class=\"h4 my-2\">");
#nullable restore
#line 13 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Shared\Components\AboutList\Default.cshtml"
                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <p>");
#nullable restore
#line 14 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Shared\Components\AboutList\Default.cshtml"
                  Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <div class=""row mt-3"">
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Age:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 20 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Email:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 26 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(item.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Phone:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 32 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Address:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">");
#nullable restore
#line 38 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Shared\Components\AboutList\Default.cshtml"
                                                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                        </div>
                        <div class=""col-sm-2"">
                            <div class=""pb-1"">Staus:</div>
                        </div>
                        <div class=""col-sm-10"">
                            <div class=""pb-1 fw-bolder"">Available</div>
                        </div>
                    </div>
                </div>
                <div class=""col-md-5 offset-md-1"" data-aos=""fade-left"" data-aos-delay=""100"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "00ba0094120aafd3821de5e1b9523ccfddd88a3b8749", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2090, "~/Template/images/", 2090, 18, true);
#nullable restore
#line 48 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Shared\Components\AboutList\Default.cshtml"
AddHtmlAttributeValue("", 2108, item.ImageUrl, 2108, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 49 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Shared\Components\AboutList\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n       \r\n        \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<About>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
