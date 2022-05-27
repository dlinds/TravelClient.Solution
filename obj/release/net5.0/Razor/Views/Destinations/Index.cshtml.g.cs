#pragma checksum "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4048b6bc0e5a243d391a729a461347d72dd82824"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Destinations_Index), @"mvc.1.0.view", @"/Views/Destinations/Index.cshtml")]
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
#line 1 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\_ViewImports.cshtml"
using TravelClient.Solution;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\_ViewImports.cshtml"
using TravelClient.Solution.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
using TravelClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4048b6bc0e5a243d391a729a461347d72dd82824", @"/Views/Destinations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a2c3369f013b1358b71a58ed667a1c50670bdd", @"/Views/_ViewImports.cshtml")]
    public class Views_Destinations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "/destinations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "/destinations?sortMethod=numOfReviews", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "/destinations?sortMethod=averageRating", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"


<div class=""px-5 py-4 border rounded shadow-sm bg-light"">
  <h1 class=""fw-light text-center mb-0"">Destinations</h1>
  <div class=""mb-1 text-end"">
    <label for=""sortMethod"">Sort Method</label>
  </div>
  <div class=""mb-1 text-end d-flex justify-content-end"">
    <select class=""form-control w-25 text-end"" id=""sortMethod"" name=""sortMethod"">
      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4048b6bc0e5a243d391a729a461347d72dd828244692", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4048b6bc0e5a243d391a729a461347d72dd828246237", async() => {
                WriteLiteral("By Country");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4048b6bc0e5a243d391a729a461347d72dd828247406", async() => {
                WriteLiteral("Number of Reviews");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n      ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4048b6bc0e5a243d391a729a461347d72dd828248582", async() => {
                WriteLiteral("Average Rating");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </select>
    <script>
      $(""#sortMethod"").change(function() {
        let $option = $(this).find(':selected');
        let url = $option.val();
        if (url != """") {
          window.location.href = url;
        }
      });
    </script>
  </div>
");
#nullable restore
#line 28 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
   for (int x = 0; x < @Model.Count; x++)
  {
    if (x == 0 || (x % 3 == 0))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      ");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 33 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("      <div class=\"col-sm-12  my-3 col-lg-4\">\r\n        <div class=\"card shadow-sm bg-white\">\r\n          <div class=\"text-end p-2\">\r\n            <a class=\"text-dark text-decoration-none\"");
            BeginWriteAttribute("href", " href=\"", 1234, "\"", 1283, 2);
            WriteAttributeValue("", 1241, "/destinations/edit/", 1241, 19, true);
#nullable restore
#line 37 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 1260, Model[x].DestinationId, 1260, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
              <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pencil-square text-muted"" viewBox=""0 0 16 16"">
                <path d=""M15.502 1.94a.5.5 0 0 1 0 .706L14.459 3.69l-2-2L13.502.646a.5.5 0 0 1 .707 0l1.293 1.293zm-1.75 2.456-2-2L4.939 9.21a.5.5 0 0 0-.121.196l-.805 2.414a.25.25 0 0 0 .316.316l2.414-.805a.5.5 0 0 0 .196-.12l6.813-6.814z""/>
                <path fill-rule=""evenodd"" d=""M1 13.5A1.5 1.5 0 0 0 2.5 15h11a1.5 1.5 0 0 0 1.5-1.5v-6a.5.5 0 0 0-1 0v6a.5.5 0 0 1-.5.5h-11a.5.5 0 0 1-.5-.5v-11a.5.5 0 0 1 .5-.5H9a.5.5 0 0 0 0-1H2.5A1.5 1.5 0 0 0 1 2.5v11z""/>
              </svg>
            </a>
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-x-circle text-muted"" viewBox=""0 0 16 16"" data-bs-toggle=""modal"" data-bs-target=""#deleteModal-");
#nullable restore
#line 43 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                                                                                                                                                                                                    Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" role=""button"">
              <path d=""M8 15A7 7 0 1 1 8 1a7 7 0 0 1 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z""/>
              <path d=""M4.646 4.646a.5.5 0 0 1 .708 0L8 7.293l2.646-2.647a.5.5 0 0 1 .708.708L8.707 8l2.647 2.646a.5.5 0 0 1-.708.708L8 8.707l-2.646 2.647a.5.5 0 0 1-.708-.708L7.293 8 4.646 5.354a.5.5 0 0 1 0-.708z""/>
            </svg>
            <div class=""modal fade""");
            BeginWriteAttribute("id", " id=\"", 2547, "\"", 2566, 2);
            WriteAttributeValue("", 2552, "deleteModal-", 2552, 12, true);
#nullable restore
#line 47 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 2564, x, 2564, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 2581, "\"", 2618, 2);
            WriteAttributeValue("", 2599, "deleteModalLabel-", 2599, 17, true);
#nullable restore
#line 47 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 2616, x, 2616, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\">\r\n              <div class=\"modal-dialog modal-dialog-centered\">\r\n                <div class=\"modal-content\">\r\n                  <div class=\"modal-header shadow-sm\">\r\n                    <h5 class=\"modal-title\"");
            BeginWriteAttribute("id", " id=\"", 2849, "\"", 2873, 2);
            WriteAttributeValue("", 2854, "deleteModalLabel-", 2854, 17, true);
#nullable restore
#line 51 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 2871, x, 2871, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Confirm Deletion</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                  </div>
                  <div class=""modal-body text-center p-5"">
                    Are you sure you want to delete ");
#nullable restore
#line 55 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                                               Write(Model[x].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("?\r\n                  </div>\r\n                  <div class=\"modal-footer\">\r\n                    <button type=\"button\" class=\"btn btn-secondary\" data-bs-dismiss=\"modal\">Cancel</button>\r\n");
#nullable restore
#line 59 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                     using (Html.BeginForm("Delete", "Destinations"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                      <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 3494, "\"", 3525, 1);
#nullable restore
#line 61 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 3502, Model[x].DestinationId, 3502, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                      <button type=\"submit\" class=\"btn btn-danger\">Yes, Delete</button>\r\n");
#nullable restore
#line 63 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  </div>\r\n                </div>\r\n              </div>\r\n            </div>\r\n          </div>\r\n          <a class=\"link-light\"");
            BeginWriteAttribute("href", " href=\"", 3782, "\"", 3834, 2);
            WriteAttributeValue("", 3789, "/destinations/details/", 3789, 22, true);
#nullable restore
#line 69 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 3811, Model[x].DestinationId, 3811, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n          <div class=\"card border-0\">\r\n            <div class=\"card-body pt-0\">\r\n              <img class=\"card-img-top rounded\" style=\"filter: brightness(50%); height: 200px; object-fit: cover;\"");
            BeginWriteAttribute("src", " src=\"", 4033, "\"", 4056, 1);
#nullable restore
#line 72 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 4039, Model[x].ImgLink, 4039, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4057, "\"", 4088, 3);
            WriteAttributeValue("", 4063, "picture", 4063, 7, true);
            WriteAttributeValue(" ", 4070, "of", 4071, 3, true);
#nullable restore
#line 72 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue(" ", 4073, Model[x].Name, 4074, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n              <div class=\"card-img-overlay px-5 text-white\">\r\n                <div class=\"text-center mt-4 mb-4\">\r\n                  <h3 class=\"fw-normal\">");
#nullable restore
#line 75 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                                   Write(Model[x].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                </div>\r\n              </div>\r\n            </div>\r\n          </div>\r\n          </a>\r\n          <div class=\"card-body mx-0 pt-0\">\r\n            <p class=\"card-text text-center mt-3 fs-5\">\r\n              ");
#nullable restore
#line 83 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
         Write(Model[x].City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 83 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                         Write(Model[x].Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n              <br>\r\n              <span class=\"fs-6\">");
#nullable restore
#line 85 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                            Write(String.Format("{0:0.00}", @Model[x].AverageRating));

#line default
#line hidden
#nullable disable
            WriteLiteral(" / 10</span>\r\n              <br>\r\n              <a class=\"fs-6 link-dark\"");
            BeginWriteAttribute("href", " href=\"", 4696, "\"", 4742, 2);
            WriteAttributeValue("", 4703, "/Reviews?type=name&value=", 4703, 25, true);
#nullable restore
#line 87 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 4728, Model[x].Name, 4728, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                                                                                  Write(Model[x].NumOfReviews);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Reviews</a>\r\n            </p>\r\n            <div class=\"text-center\">\r\n              <button type=\"button\" class=\"btn btn-sm travel-color-darkest text-white shadow-sm\" data-bs-toggle=\"modal\" data-bs-target=\"#exampleModal-");
#nullable restore
#line 90 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                                                                                                                                                 Write(x);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                Add Review\r\n              </button>\r\n            </div>\r\n            <div class=\"modal fade\"");
            BeginWriteAttribute("id", " id=\"", 5101, "\"", 5121, 2);
            WriteAttributeValue("", 5106, "exampleModal-", 5106, 13, true);
#nullable restore
#line 94 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 5119, x, 5119, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" tabindex=\"-1\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 5136, "\"", 5189, 3);
            WriteAttributeValue("", 5154, "#", 5154, 1, true);
#nullable restore
#line 94 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 5155, Model[x].DestinationId, 5155, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5178, "-ModalLabel", 5178, 11, true);
            EndWriteAttribute();
            WriteLiteral(" aria-hidden=\"true\">\r\n              <div class=\"modal-dialog\">\r\n");
#nullable restore
#line 96 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                 using (Html.BeginForm("Create", "Reviews"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"modal-content\">\r\n                  <div class=\"modal-header\">\r\n                    <h4 class=\"modal-title\"");
            BeginWriteAttribute("id", " id=\"", 5469, "\"", 5508, 2);
#nullable restore
#line 100 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 5474, Model[x].DestinationId, 5474, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5497, "-ModalLabel", 5497, 11, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 100 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                                                                               Write(Model[x].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<span class=""fs-5 fw-light""> | Add Review</span></h4>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                  </div>
                  <div class=""modal-body px-5 bg-light"">
                    <div class=""form-group"">
                      <label");
            BeginWriteAttribute("for", " for=\"", 5851, "\"", 5870, 2);
            WriteAttributeValue("", 5857, "reviewText-", 5857, 11, true);
#nullable restore
#line 105 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 5868, x, 5868, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Review Body</label>\r\n                      <textarea rows=\"10\" class=\"form-control mb-3 shadow-sm\" name=\"Review.ReviewText\"");
            BeginWriteAttribute("id", " id=\"", 5995, "\"", 6013, 2);
            WriteAttributeValue("", 6000, "reviewText-", 6000, 11, true);
#nullable restore
#line 106 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 6011, x, 6011, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required=\"required\"></textarea>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                      <label");
            BeginWriteAttribute("for", " for=\"", 6150, "\"", 6173, 2);
            WriteAttributeValue("", 6156, "reviewUserName-", 6156, 15, true);
#nullable restore
#line 109 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 6171, x, 6171, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">User Name</label>\r\n                      <input type=\"text\" class=\"form-control mb-3 shadow-sm\" name=\"Review.UserName\"");
            BeginWriteAttribute("id", " id=\"", 6293, "\"", 6315, 2);
            WriteAttributeValue("", 6298, "reviewUserName-", 6298, 15, true);
#nullable restore
#line 110 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 6313, x, 6313, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" required=\"required\">\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                      <label");
            BeginWriteAttribute("for", " for=\"", 6441, "\"", 6456, 2);
            WriteAttributeValue("", 6447, "rating-", 6447, 7, true);
#nullable restore
#line 113 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 6454, x, 6454, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Rating, out of 10</label>\r\n                      <input type=\"number\" class=\"form-control w-25 shadow-sm mb-3\" name=\"Review.Rating\"");
            BeginWriteAttribute("id", " id=\"", 6589, "\"", 6603, 2);
            WriteAttributeValue("", 6594, "rating-", 6594, 7, true);
#nullable restore
#line 114 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 6601, x, 6601, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" min=0 max=10>\r\n                    </div>\r\n                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 6688, "\"", 6719, 1);
#nullable restore
#line 116 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
WriteAttributeValue("", 6696, Model[x].DestinationId, 6696, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Review.DestinationId"">
                  </div>
                  <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-outline-dark"" data-bs-dismiss=""modal"">Cancel</button>
                    <button type=""submit"" class=""btn travel-color-darkest text-white"">Add Review</button>
                  </div>
                </div>
");
#nullable restore
#line 123 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n");
#nullable restore
#line 129 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
    if ((x+1) % 3 == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      ");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 132 "C:\Users\DanielLindsey\Desktop\C#\TravelClient.Solution\Views\Destinations\Index.cshtml"
    }
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
