#pragma checksum "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fc2865ecff00f2b9fb43c6b3aa1c82c60433df8ba0e6f733a9d2bd777af9f2a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_EditPortfolio), @"mvc.1.0.view", @"/Views/Portfolio/EditPortfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fc2865ecff00f2b9fb43c6b3aa1c82c60433df8ba0e6f733a9d2bd777af9f2a4", @"/Views/Portfolio/EditPortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6ce2767b5e9aacf9218c5ea7d9b3dff0f71adde816b8961150960e416b571dcd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_EditPortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Portfolio>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
  
    ViewData["Title"] = "EditPortfolio";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
 using (Html.BeginForm("EditPortfolio", "Portfolio", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <p class=\"card-description\"> Proje Düzenleme Paneli </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc2865ecff00f2b9fb43c6b3aa1c82c60433df8ba0e6f733a9d2bd777af9f2a44689", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.HiddenFor(x => x.PortfolioID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    ");
#nullable restore
#line 18 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.Label("Proje Başlığı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 19 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 20 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label>Görsel 1</label>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.ImageUrl));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label>Görsel2</label>\r\n                    ");
#nullable restore
#line 27 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.ImageUrl2, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 28 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.ImageUrl2));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label>Proje URL</label>\r\n                    ");
#nullable restore
#line 31 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.ProjectUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 32 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.ProjectUrl));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label>Fiyat</label>\r\n                    ");
#nullable restore
#line 35 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 36 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label>Tamamlanma Oranı</label>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.Value, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 40 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.Value));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <label>Platform</label>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.TextBoxFor(x => x.Platform, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 44 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
               Write(Html.ValidationMessageFor(x => x.Platform));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <br />\r\n                    <button class=\"btn btn-info\">Kaydet</button>\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 52 "C:\Users\Samet Polat\Downloads\Core_Proje\Core_Proje\Core_Proje\Views\Portfolio\EditPortfolio.cshtml"
}

#line default
#line hidden
#nullable disable
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
