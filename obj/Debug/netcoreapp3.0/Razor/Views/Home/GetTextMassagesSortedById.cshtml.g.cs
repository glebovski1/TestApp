#pragma checksum "C:\Users\Ugleb\source\repos\TestApplication\Views\Home\GetTextMassagesSortedById.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d882e00da65c3a62d91184fe388bdce4f69f9f75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetTextMassagesSortedById), @"mvc.1.0.view", @"/Views/Home/GetTextMassagesSortedById.cshtml")]
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
#line 1 "C:\Users\Ugleb\source\repos\TestApplication\Views\_ViewImports.cshtml"
using TestApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ugleb\source\repos\TestApplication\Views\_ViewImports.cshtml"
using TestApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d882e00da65c3a62d91184fe388bdce4f69f9f75", @"/Views/Home/GetTextMassagesSortedById.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c18df14659d9ffcf730f540f4c694666d270b7cb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetTextMassagesSortedById : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<KeyValuePair<string, Massage>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ugleb\source\repos\TestApplication\Views\Home\GetTextMassagesSortedById.cshtml"
  
    ViewData["Title"] = "GetTextMassagesSortedById";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>All Massages</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Id\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Ugleb\source\repos\TestApplication\Views\Home\GetTextMassagesSortedById.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().Value.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Ugleb\source\repos\TestApplication\Views\Home\GetTextMassagesSortedById.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstOrDefault().Value.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "C:\Users\Ugleb\source\repos\TestApplication\Views\Home\GetTextMassagesSortedById.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 30 "C:\Users\Ugleb\source\repos\TestApplication\Views\Home\GetTextMassagesSortedById.cshtml"
               Write(Html.DisplayFor(modelItem => item.Key));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Ugleb\source\repos\TestApplication\Views\Home\GetTextMassagesSortedById.cshtml"
               Write(Html.DisplayFor(modelItem => item.Value.DateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Ugleb\source\repos\TestApplication\Views\Home\GetTextMassagesSortedById.cshtml"
               Write(Html.DisplayFor(modelItem => item.Value.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Users\Ugleb\source\repos\TestApplication\Views\Home\GetTextMassagesSortedById.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    ");
#nullable restore
#line 44 "C:\Users\Ugleb\source\repos\TestApplication\Views\Home\GetTextMassagesSortedById.cshtml"
Write(Html.ActionLink("Sort by date", "GetTextMassagesSortedByDate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<KeyValuePair<string, Massage>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
