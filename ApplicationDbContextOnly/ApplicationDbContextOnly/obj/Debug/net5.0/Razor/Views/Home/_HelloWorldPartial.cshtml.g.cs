#pragma checksum "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\_HelloWorldPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88bc443609e02a58ac69b24d795ffd4996fe6fd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__HelloWorldPartial), @"mvc.1.0.view", @"/Views/Home/_HelloWorldPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88bc443609e02a58ac69b24d795ffd4996fe6fd4", @"/Views/Home/_HelloWorldPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a2029490e4de037bc65f14d2dcf58bc09ae221", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__HelloWorldPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>");
#nullable restore
#line 1 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\_HelloWorldPartial.cshtml"
Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" from the Hello World partial at ");
#nullable restore
#line 1 "E:\My Works\DotNetCore\ApplicationDbContextOnly\ApplicationDbContextOnly\Views\Home\_HelloWorldPartial.cshtml"
                                                   Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591