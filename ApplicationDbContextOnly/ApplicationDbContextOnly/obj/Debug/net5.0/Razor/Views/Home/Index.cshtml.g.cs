#pragma checksum "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8198ea0b3838ff0e9f568ae33688fde56b74dceb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\_ViewImports.cshtml"
using ApplicationDbContextOnly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\_ViewImports.cshtml"
using ApplicationDbContextOnly.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8198ea0b3838ff0e9f568ae33688fde56b74dceb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a2029490e4de037bc65f14d2dcf58bc09ae221", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApplicationDbContextOnly.Models.PrintOrderModelView>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <table class=\"table table-bordered\">\r\n        <thead class=\"thead-light\">\r\n            <tr>\r\n                <th>");
#nullable restore
#line 11 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 12 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 13 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().Complex));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 14 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstOrDefault().Stage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 18 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.Complex));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml"
               Write(Html.DisplayFor(modelitem => item.Stage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApplicationDbContextOnly.Models.PrintOrderModelView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
