#pragma checksum "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\Product\_ProductInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a645b056855608ca3a67dab00418322f969e649"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product__ProductInformation), @"mvc.1.0.view", @"/Views/Product/_ProductInformation.cshtml")]
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
#line 1 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\_ViewImports.cshtml"
using POSSystemWithInventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\_ViewImports.cshtml"
using POSSystemWithInventory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a645b056855608ca3a67dab00418322f969e649", @"/Views/Product/_ProductInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0954828e5840935f343bc924c396ef2b26707336", @"/Views/_ViewImports.cshtml")]
    public class Views_Product__ProductInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<POSSystemWithInventory.Models.ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-1\">\r\n\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n        <table class=\"table\">\r\n            <tbody>\r\n                <tr>\r\n                    <td>Name : ");
#nullable restore
#line 11 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\Product\_ProductInformation.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td rowspan=\"6\"><img");
            BeginWriteAttribute("src", " src=\"", 303, "\"", 324, 1);
#nullable restore
#line 12 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\Product\_ProductInformation.cshtml"
WriteAttributeValue("", 309, Model.PhotoUrl, 309, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"150\" alt=\"No Image\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Brand : ");
#nullable restore
#line 15 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\Product\_ProductInformation.cshtml"
                           Write(Model.BrandName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Category : ");
#nullable restore
#line 18 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\Product\_ProductInformation.cshtml"
                              Write(Model.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Unit : ");
#nullable restore
#line 21 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\Product\_ProductInformation.cshtml"
                          Write(Model.UnitName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Description : ");
#nullable restore
#line 24 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\Product\_ProductInformation.cshtml"
                                 Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Warning Quantity : ");
#nullable restore
#line 27 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\Product\_ProductInformation.cshtml"
                                      Write(Model.WarningQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"col-md-1\">\r\n\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<POSSystemWithInventory.Models.ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
