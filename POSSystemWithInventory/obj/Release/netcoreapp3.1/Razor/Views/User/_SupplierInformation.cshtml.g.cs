#pragma checksum "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\User\_SupplierInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01783c248e3b611830a7fef09368d4ea251fb7f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User__SupplierInformation), @"mvc.1.0.view", @"/Views/User/_SupplierInformation.cshtml")]
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
#line 1 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\_ViewImports.cshtml"
using POSSystemWithInventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\_ViewImports.cshtml"
using POSSystemWithInventory.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\_ViewImports.cshtml"
using POSSystemWithInventory.EntityModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01783c248e3b611830a7fef09368d4ea251fb7f2", @"/Views/User/_SupplierInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b6b5139d3f04192678769d821201b7c793563f", @"/Views/_ViewImports.cshtml")]
    public class Views_User__SupplierInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<POSSystemWithInventory.Models.SupplierVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-1\">\r\n\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n        <table class=\"table\">\r\n            <tbody>\r\n                <tr>\r\n                    <td>Name : ");
#nullable restore
#line 13 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\User\_SupplierInformation.cshtml"
                          Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td rowspan=\"7\"><img");
            BeginWriteAttribute("src", " src=\"", 308, "\"", 329, 1);
#nullable restore
#line 14 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\User\_SupplierInformation.cshtml"
WriteAttributeValue("", 314, Model.PhotoUrl, 314, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"150\" /></td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Designation : ");
#nullable restore
#line 17 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\User\_SupplierInformation.cshtml"
                                 Write(Model.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Company Name : ");
#nullable restore
#line 20 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\User\_SupplierInformation.cshtml"
                                  Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Phone : ");
#nullable restore
#line 23 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\User\_SupplierInformation.cshtml"
                           Write(Model.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Email : ");
#nullable restore
#line 26 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\User\_SupplierInformation.cshtml"
                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>Address : ");
#nullable restore
#line 29 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\User\_SupplierInformation.cshtml"
                             Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <tr>\r\n                    <td>NID : ");
#nullable restore
#line 32 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\User\_SupplierInformation.cshtml"
                         Write(Model.NID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"col-md-1\">\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<POSSystemWithInventory.Models.SupplierVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
