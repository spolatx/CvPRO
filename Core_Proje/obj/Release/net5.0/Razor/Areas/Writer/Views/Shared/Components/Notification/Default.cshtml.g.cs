#pragma checksum "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "464d7f3fc685f0d0503181d281ec539db5bbc48822b873e4bafd130430e88492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Shared_Components_Notification_Default), @"mvc.1.0.view", @"/Areas/Writer/Views/Shared/Components/Notification/Default.cshtml")]
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
#line 1 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"464d7f3fc685f0d0503181d281ec539db5bbc48822b873e4bafd130430e88492", @"/Areas/Writer/Views/Shared/Components/Notification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"f68c967ecac2dee79a0753fe99077890945878b3e87c560bd67de47177eeb66f", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Shared_Components_Notification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Announcement>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
  string color = ""; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <p class=\"mb-0 font-weight-normal float-left dropdown-header\">Bildirimler</p>\r\n");
#nullable restore
#line 6 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
     foreach (var item in Model)
    {
        if (item.Status == "Yeni Yazı")
        {
            color = "preview-icon bg-success";
        }
        if (item.Status == "Yeni Video")
        {
            color = "preview-icon bg-warning";
        }
        if (item.Status == "Konferans")
        {
            color = "preview-icon bg-info";
        }
        if (item.Status == "Bootcamp")
        {
            color = "preview-icon bg-primary";
        }
        if (item.Status == "Workshop")
        {
            color = "preview-icon bg-danger";
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"dropdown-item preview-item\"");
            BeginWriteAttribute("href", " href=\"", 916, "\"", 967, 2);
            WriteAttributeValue("", 923, "/Writer/Default/AnnouncementDetails/", 923, 36, true);
#nullable restore
#line 28 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
WriteAttributeValue("", 959, item.ID, 959, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <div class=\"preview-thumbnail\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1036, "\"", 1050, 1);
#nullable restore
#line 30 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
WriteAttributeValue("", 1044, color, 1044, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"ti-info-alt mx-0\"></i>\r\n                </div>\r\n            </div>\r\n            <div class=\"preview-item-content\">\r\n                <h6 class=\"preview-subject font-weight-normal\">");
#nullable restore
#line 35 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
                                                          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"font-weight-light small-text mb-0 text-muted\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
               Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 41 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Areas\Writer\Views\Shared\Components\Notification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Announcement>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591