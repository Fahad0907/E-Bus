#pragma checksum "E:\Ebus\Ebus\Views\Driver\driverPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b77eb8b722031b508627035c2d6909f2f7298fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Driver_driverPage), @"mvc.1.0.view", @"/Views/Driver/driverPage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Driver/driverPage.cshtml", typeof(AspNetCore.Views_Driver_driverPage))]
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
#line 1 "E:\Ebus\Ebus\Views\_ViewImports.cshtml"
using Ebus;

#line default
#line hidden
#line 2 "E:\Ebus\Ebus\Views\_ViewImports.cshtml"
using Ebus.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b77eb8b722031b508627035c2d6909f2f7298fc", @"/Views/Driver/driverPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ad30c4f751e99dbd563e33deae9e688e594211", @"/Views/_ViewImports.cshtml")]
    public class Views_Driver_driverPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Ebus\Ebus\Views\Driver\driverPage.cshtml"
  
    ViewData["Title"] = "driverPage";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(95, 115, true);
            WriteLiteral("<div class=\"container\">\r\n    <h2 class=\"text-center\">Driver Page</h2>\r\n    <button class=\"btn btn-light\">\r\n        ");
            EndContext();
            BeginContext(211, 53, false);
#line 9 "E:\Ebus\Ebus\Views\Driver\driverPage.cshtml"
   Write(Html.ActionLink("Trip start", "Trip_start", "Driver"));

#line default
#line hidden
            EndContext();
            BeginContext(264, 61, true);
            WriteLiteral("\r\n    </button>\r\n    <button class=\"btn btn-light\">\r\n        ");
            EndContext();
            BeginContext(326, 52, false);
#line 12 "E:\Ebus\Ebus\Views\Driver\driverPage.cshtml"
   Write(Html.ActionLink("My route", "driverRoute", "Driver"));

#line default
#line hidden
            EndContext();
            BeginContext(378, 61, true);
            WriteLiteral("\r\n    </button>\r\n    <button class=\"btn btn-light\">\r\n        ");
            EndContext();
            BeginContext(440, 56, false);
#line 15 "E:\Ebus\Ebus\Views\Driver\driverPage.cshtml"
   Write(Html.ActionLink("Request List", "requestList", "Driver"));

#line default
#line hidden
            EndContext();
            BeginContext(496, 61, true);
            WriteLiteral("\r\n    </button>\r\n    <button class=\"btn btn-light\">\r\n        ");
            EndContext();
            BeginContext(558, 64, false);
#line 18 "E:\Ebus\Ebus\Views\Driver\driverPage.cshtml"
   Write(Html.ActionLink("Check Passenger Entry", "checkEntry", "Driver"));

#line default
#line hidden
            EndContext();
            BeginContext(622, 33, true);
            WriteLiteral("\r\n    </button>\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591