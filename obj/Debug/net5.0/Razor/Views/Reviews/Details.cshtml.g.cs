#pragma checksum "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa559c1b35cae78299355bc1f212dd9ba74e58e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Details), @"mvc.1.0.view", @"/Views/Reviews/Details.cshtml")]
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
#line 1 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\_ViewImports.cshtml"
using TravelClient.Solution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\_ViewImports.cshtml"
using TravelClient.Solution.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Details.cshtml"
using TravelClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa559c1b35cae78299355bc1f212dd9ba74e58e9", @"/Views/Reviews/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a2c3369f013b1358b71a58ed667a1c50670bdd", @"/Views/_ViewImports.cshtml")]
    public class Views_Reviews_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelClient.Models.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Review Details</h1>\r\n");
#nullable restore
#line 4 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Details.cshtml"
 if (@Model.ReviewId == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h5>No reviews for this place.</h5>\r\n");
#nullable restore
#line 7 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <ul>\r\n    <li>Review Text: ");
#nullable restore
#line 11 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Details.cshtml"
                Write(Model.ReviewText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Review User : ");
#nullable restore
#line 12 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Details.cshtml"
                 Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n  </ul>\r\n");
#nullable restore
#line 14 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TravelClient.Models.Review> Html { get; private set; }
    }
}
#pragma warning restore 1591