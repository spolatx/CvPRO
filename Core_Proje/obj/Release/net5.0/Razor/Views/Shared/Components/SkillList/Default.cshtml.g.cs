#pragma checksum "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "dc96044605af66afeeb50a7c4de331286ee0f1d28c61014e8d7b3a4001acf2b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SkillList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SkillList/Default.cshtml")]
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
#line 1 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"dc96044605af66afeeb50a7c4de331286ee0f1d28c61014e8d7b3a4001acf2b2", @"/Views/Shared/Components/SkillList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_SkillList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""section px-3 px-lg-4 pt-5"" id=""skills"">
    <div class=""container-narrow"">
        <div class=""text-center mb-5"">
            <h2 class=""marker marker-center"">Yeteneklerim</h2>
        </div>
        <div class=""text-center"">
            <p class=""mx-auto mb-3"" style=""max-width:600px"">Aşağıda bildiğim programlama dilleri ve teknolojiler üzerine bir bar listesi bulunmaktadır. Yeni bir programlama dilini öğrenmek benim için oldukça hızlı gerçekleşen bir durumdur.</p>
        </div>
        <div class=""bg-light p-3"">
            <div class=""row"">
                <div class=""col-md-12"">
");
#nullable restore
#line 14 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"py-1\">\r\n                        <div class=\"d-flex text-small fw-bolder\"><span class=\"me-auto\">");
#nullable restore
#line 17 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span>");
#nullable restore
#line 17 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                                                                                                          Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span></div>\r\n                        <div class=\"progress my-1\">\r\n                            <div class=\"progress-bar bg-primary\" role=\"progressbar\" data-aos=\"zoom-in-right\" data-aos-delay=\"100\" data-aos-anchor=\".skills-section\"");
            BeginWriteAttribute("style", " style=\"", 1129, "\"", 1156, 3);
            WriteAttributeValue("", 1137, "width:", 1137, 6, true);
#nullable restore
#line 19 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue(" ", 1143, item.Value, 1144, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1155, "%", 1155, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1157, "\"", 1184, 1);
#nullable restore
#line 19 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
WriteAttributeValue("", 1173, item.Value, 1173, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 22 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\SkillList\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
