#pragma checksum "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4c59b530b45939c6e9aa7071c7fe440260c4ff4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reviews_Index), @"mvc.1.0.view", @"/Views/Reviews/Index.cshtml")]
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
#line 1 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Index.cshtml"
using TravelClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4c59b530b45939c6e9aa7071c7fe440260c4ff4", @"/Views/Reviews/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a2c3369f013b1358b71a58ed667a1c50670bdd", @"/Views/_ViewImports.cshtml")]
    public class Views_Reviews_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<div class=""px-5 py-4 border rounded shadow-sm bg-light"">
  <div class=""px-5"">
    <div class=""card shadow-sm mb-4"">
      <img class=""card-img-top rounded"" style=""filter: brightness(50%);"" src=""https://cdn.getyourguide.com/img/tour/5d4c31d4123d3.jpeg/99.jpg"" alt=""picture of place"">
      <div class=""card-img-overlay mt-2 p-5 text-white"">
        <h1 class=""fw-normal text-center mt-2 mb-0 fs-1"">Eiffel Tower</h1>
        <h4 class=""fw-light text-center mb-3 fs-3"">Paris, France</h4>
      </div>
    </div>
");
#nullable restore
#line 15 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Index.cshtml"
     for (int x = 0; x < 5; x++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      <div class=""card my-3 bg-white shadow-sm"">
        <div class=""card-header bg-white"">
          <div class=""text-end"">
            <a class=""text-dark text-decoration-none"" href=""reviews/edit/3"">
              <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pencil-square text-muted"" viewBox=""0 0 16 16"">
                <path d=""M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z"" />
                <path fill-rule=""evenodd"" d=""M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z"" />
              </svg>
            </a>
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-x-circle text-muted"" viewBox=""0 0 16 16""");
            WriteLiteral(" data-bs-toggle=\"modal\" data-bs-target=\"#deleteModal-");
#nullable restore
#line 26 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Index.cshtml"
                                                                                                                                                                                                    Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" role=""button"">
              <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
              <path d=""M4.646 4.646a.5.5 0 0 1 .708 0L8 7.293l2.646-2.647a.5.5 0 0 1 .708.708L8.707 8l2.647 2.646a.5.5 0 0 1-.708.708L8 8.707l-2.646 2.647a.5.5 0 0 1-.708-.708L7.293 8 4.646 5.354a.5.5 0 0 1 0-.708z"" />
            </svg>
            <div class=""modal fade""");
            BeginWriteAttribute("id", " id=\"", 2115, "\"", 2134, 2);
            WriteAttributeValue("", 2120, "deleteModal-", 2120, 12, true);
#nullable restore
#line 30 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Index.cshtml"
WriteAttributeValue("", 2132, x, 2132, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2149, "\"", 2186, 2);
            WriteAttributeValue("", 2167, "deleteModalLabel-", 2167, 17, true);
#nullable restore
#line 30 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Index.cshtml"
WriteAttributeValue("", 2184, x, 2184, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\">\r\n              <div class=\"modal-dialog modal-dialog-centered\">\r\n                <div class=\"modal-content\">\r\n                  <div class=\"modal-header shadow-sm\">\r\n                    <h5 class=\"modal-title\"");
            BeginWriteAttribute("id", " id=\"", 2417, "\"", 2441, 2);
            WriteAttributeValue("", 2422, "deleteModalLabel-", 2422, 17, true);
#nullable restore
#line 34 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Index.cshtml"
WriteAttributeValue("", 2439, x, 2439, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Confirm Deletion</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                  </div>
                  <div class=""modal-body text-center p-5"">
                    Are you sure you want to delete REVIEW--------NAME?
                  </div>
                  <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Cancel</button>
");
#nullable restore
#line 42 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Index.cshtml"
                     using (Html.BeginForm("Delete", "Reviews"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <input type=\"hidden\" name=\"id\" value=\"REVIEW--------NAME\">\r\n                      <button type=\"submit\" class=\"btn btn-danger\">Yes, Delete</button>\r\n");
#nullable restore
#line 46 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class=""row px-5 pt-1"">
            <div class=""col-md-9 col-sm-12"">
              <h5 class=""fw-light"">Username</h5>
            </div>
            <div class=""col-md-3 col-sm-12 text-end"">
              <h5 class=""fw-light"">Rating: 6 / 10</h5>
            </div>
          </div>
        </div>
        <div class=""card-body"">
          <p class=""card-text px-5 py-2"">
            Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
          </p>
        </div>
      </div>
");
#nullable restore
#line 67 "C:\Users\DanielLindsey\Desktop\c#\TravelClient.Solution\Views\Reviews\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </div>\r\n</div>\r\n");
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
