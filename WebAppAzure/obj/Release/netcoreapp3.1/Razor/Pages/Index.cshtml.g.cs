#pragma checksum "/Users/alybadarakeita/Projects/WebAppAzure/WebAppAzure/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a828b565f4543f2a713f3c6b34d00b86815a6e9a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebAppAzure.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace WebAppAzure.Pages
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
#line 1 "/Users/alybadarakeita/Projects/WebAppAzure/WebAppAzure/Pages/_ViewImports.cshtml"
using WebAppAzure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a828b565f4543f2a713f3c6b34d00b86815a6e9a", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abf3b18aa35dfd0604ce52c65ba14f797fae8798", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/alybadarakeita/Projects/WebAppAzure/WebAppAzure/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">This is  a special list of product</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>

    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">Product ID</th>
                <th scope=""col"">Product Name</th>
                <th scope=""col"">Quantity</th>

            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 22 "/Users/alybadarakeita/Projects/WebAppAzure/WebAppAzure/Pages/Index.cshtml"
             foreach(var product in Model.products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th scope=\"row\"> ");
#nullable restore
#line 25 "/Users/alybadarakeita/Projects/WebAppAzure/WebAppAzure/Pages/Index.cshtml"
                            Write(product.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th scope=\"row\"> ");
#nullable restore
#line 26 "/Users/alybadarakeita/Projects/WebAppAzure/WebAppAzure/Pages/Index.cshtml"
                            Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th scope=\"row\"> ");
#nullable restore
#line 27 "/Users/alybadarakeita/Projects/WebAppAzure/WebAppAzure/Pages/Index.cshtml"
                            Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n\n            </tr>\n");
#nullable restore
#line 30 "/Users/alybadarakeita/Projects/WebAppAzure/WebAppAzure/Pages/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591