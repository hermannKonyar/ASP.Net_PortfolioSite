#pragma checksum "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fc39d01bce91fcdcb2018202f1052a40d354cb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_AddPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/AddPortfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fc39d01bce91fcdcb2018202f1052a40d354cb6", @"/Views/Portfolio/AddPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3901bc2aa10f466a436e651d47d8a48ebde308f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_AddPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Portfolio>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
  
    ViewData["Title"] = "AddPortfolio";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-header border-0\">\r\n    <h3 class=\"mb-0\">Proje Ekleme Sayfası</h3>\r\n</div>\r\n");
#nullable restore
#line 10 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
 using (Html.BeginForm("AddPortfolio", "Portfolio", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 14 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.Label("Proje Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.Name,new{ @class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <label>Görsel 1</label>\r\n");
#nullable restore
#line 19 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl,new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <label>Görsel 2</label>\r\n");
#nullable restore
#line 23 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl,new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <label>Proje Url</label>\r\n");
#nullable restore
#line 27 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextAreaFor(x=>x.ProjectUrl,10,3,new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <label>Fiyat</label>\r\n");
#nullable restore
#line 32 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextAreaFor(x=>x.Price,10,3,new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n    <label>Tamamlanma Oranı</label>\r\n");
#nullable restore
#line 37 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextAreaFor(x=>x.Value,10,3,new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Proje Url</label>\r\n");
#nullable restore
#line 42 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextAreaFor(x=>x.ProjectUrl,10,3,new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Proje Url</label>\r\n");
#nullable restore
#line 47 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.TextAreaFor(x=>x.ProjectUrl,10,3,new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
Write(Html.ValidationMessageFor(x=>x.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n        <button class=\"btn btn-primary\">Ekle</button>\r\n");
#nullable restore
#line 52 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Portfolio\AddPortfolio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Portfolio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591