#pragma checksum "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Skill\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18675180a768d9f6c8ce4f587f30158e181a3d98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Skill\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18675180a768d9f6c8ce4f587f30158e181a3d98", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3901bc2aa10f466a436e651d47d8a48ebde308f8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Skill\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Yetenek Listesi Tablosu</h3>
</div>
<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Başlık</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Oran</th>
                <th scope=""col"">Sil</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Düzenle</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">
");
#nullable restore
#line 26 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Skill\Index.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th>\r\n                        ");
#nullable restore
#line 30 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Skill\Index.cshtml"
                   Write(item.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <td class=\"budget\">\r\n                        ");
#nullable restore
#line 33 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Skill\Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                   \r\n                    <td>\r\n                        <div class=\"d-flex align-items-center\">\r\n                            <span class=\"completion mr-2\">");
#nullable restore
#line 38 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Skill\Index.cshtml"
                                                     Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\r\n                            <div>\r\n                                <div class=\"progress\">\r\n                                    <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1509, "\"", 1536, 1);
#nullable restore
#line 41 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Skill\Index.cshtml"
WriteAttributeValue("", 1525, item.Value, 1525, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"");
            BeginWriteAttribute("style", " style=\"", 1575, "\"", 1603, 3);
            WriteAttributeValue("", 1583, "width:", 1583, 6, true);
#nullable restore
#line 41 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Skill\Index.cshtml"
WriteAttributeValue(" ", 1589, item.Value, 1590, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1601, "%;", 1601, 2, true);
            EndWriteAttribute();
            WriteLiteral(@"></div>
                                </div>
                            </div>
                        </div>
                    </td>
                    <td><a href=""#"" class=""btn btn-danger"">Sil</a></td>
                    <td><a href=""#"" class=""btn btn-success"">Güncelle</a></td>
                    
                </tr>
");
#nullable restore
#line 50 "C:\Users\Erman\source\repos\PorfolioApp\PorfolioApp\Views\Skill\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            \r\n        </tbody>\r\n    </table>\r\n    <br />\r\n    <a href=\"/Skill/SkillAdd\" class=\"btn btn-primary\">\r\n        Yeni Yetenek Ekle\r\n    </a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
