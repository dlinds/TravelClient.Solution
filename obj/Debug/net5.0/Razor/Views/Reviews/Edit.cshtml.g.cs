#pragma checksum "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c55cf6c76564bf58a02021ff353bfd2745169b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Edit), @"mvc.1.0.view", @"/Views/Reviews/Edit.cshtml")]
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
#line 1 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml"
using TravelClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c55cf6c76564bf58a02021ff353bfd2745169b8", @"/Views/Reviews/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a2c3369f013b1358b71a58ed667a1c50670bdd", @"/Views/_ViewImports.cshtml")]
    public class Views_Reviews_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TravelClient.Models.Review>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container bg-light bg-gradient p-5 border rounded-3\">\r\n  <div class=\"mx-5 p-5 border rounded shadow-sm bg-white\">\r\n    <h3 class=\"mb-3\">Edit a review</h3>\r\n    <div class=\"row\">\r\n      <div class=\"col-7\">\r\n");
#nullable restore
#line 9 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml"
         using (Html.BeginForm("Edit", "Reviews", FormMethod.Post))
        {
          

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml"
     Write(Html.LabelFor(m => m.ReviewText));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml"
     Write(Html.TextBoxFor(m => m.ReviewText, new {@class="form-control mb-3 shadow-sm", required="required" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml"
     Write(Html.LabelFor(m => m.UserName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml"
     Write(Html.TextBoxFor(m => m.UserName, new {@class="form-control mb-3 shadow-sm", required="required" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml"
     Write(Html.LabelFor(m => m.Rating));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml"
     Write(Html.TextBoxFor(m => m.Rating, new {@class="form-control mb-3 shadow-sm", required="required", type="number", min="1", max="10" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml"
     Write(Html.HiddenFor(m => m.DestinationId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml"
     Write(Html.HiddenFor(m => m.ReviewId));

#line default
#line hidden
#nullable disable
            WriteLiteral("          <input type=\"submit\" value=\"Edit\" class=\"btn travel-color-darkest text-white mb-3 shadow-sm\" />\r\n");
#nullable restore
#line 23 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Edit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("      </div>\r\n      <div class=\"col-5\">\r\n        <p>Use the form to the left to edit a review!</p>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n");
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