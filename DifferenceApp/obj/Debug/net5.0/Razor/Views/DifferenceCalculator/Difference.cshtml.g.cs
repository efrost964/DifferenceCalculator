#pragma checksum "C:\Users\lumpysacks\Desktop\coding\DifferenceApp\DifferenceApp\Views\DifferenceCalculator\Difference.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75f2e1b952e4e55c602a5c9f3439a801510838fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DifferenceCalculator_Difference), @"mvc.1.0.view", @"/Views/DifferenceCalculator/Difference.cshtml")]
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
#line 1 "C:\Users\lumpysacks\Desktop\coding\DifferenceApp\DifferenceApp\Views\_ViewImports.cshtml"
using DifferenceApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lumpysacks\Desktop\coding\DifferenceApp\DifferenceApp\Views\_ViewImports.cshtml"
using DifferenceApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75f2e1b952e4e55c602a5c9f3439a801510838fe", @"/Views/DifferenceCalculator/Difference.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed2e279c8ae993dea0561670efe8b1c1cf2ccef3", @"/Views/_ViewImports.cshtml")]
    public class Views_DifferenceCalculator_Difference : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\lumpysacks\Desktop\coding\DifferenceApp\DifferenceApp\Views\DifferenceCalculator\Difference.cshtml"
 if (ViewBag.difference > 10)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>The difference is <span class=\"greater\">");
#nullable restore
#line 8 "C:\Users\lumpysacks\Desktop\coding\DifferenceApp\DifferenceApp\Views\DifferenceCalculator\Difference.cshtml"
                                           Write(ViewBag.difference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h1>\r\n");
#nullable restore
#line 9 "C:\Users\lumpysacks\Desktop\coding\DifferenceApp\DifferenceApp\Views\DifferenceCalculator\Difference.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lumpysacks\Desktop\coding\DifferenceApp\DifferenceApp\Views\DifferenceCalculator\Difference.cshtml"
 if (ViewBag.difference < 10)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>The difference is <span class=\"lesser\">");
#nullable restore
#line 12 "C:\Users\lumpysacks\Desktop\coding\DifferenceApp\DifferenceApp\Views\DifferenceCalculator\Difference.cshtml"
                                          Write(ViewBag.difference);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h1>\r\n");
#nullable restore
#line 13 "C:\Users\lumpysacks\Desktop\coding\DifferenceApp\DifferenceApp\Views\DifferenceCalculator\Difference.cshtml"
}

#line default
#line hidden
#nullable disable
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