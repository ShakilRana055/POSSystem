#pragma checksum "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e017aa9900fd1eecc990f572f89e3d77c38a9bb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesInvoice__SalesInvoiceInformation), @"mvc.1.0.view", @"/Views/SalesInvoice/_SalesInvoiceInformation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e017aa9900fd1eecc990f572f89e3d77c38a9bb7", @"/Views/SalesInvoice/_SalesInvoiceInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b6b5139d3f04192678769d821201b7c793563f", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesInvoice__SalesInvoiceInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<POSSystemWithInventory.EntityModel.SalesInvoice>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Company/logo.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("No"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<style>
    #invoiceTable thead, tbody, tfoot {
        font-weight: bold;
    }
</style>

<div class=""row"">
    <div class=""col-md-1"">
        <button class=""btn btn-success btn-sm"" id=""printBtnSalesInvoiceReport"">Print</button>
    </div>
    <div class=""col-md-10"" style=""background-color:ghostwhite;"" id=""printSalesInvoiceReport"">
        <table class=""table table-borderless"">
            <tr>
                <td id=""companyLogo"" rowspan=""2"" align=""right"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e017aa9900fd1eecc990f572f89e3d77c38a9bb75630", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </td>
                <td style=""text-align:center;"">
                    <h3 id=""companyName"" style=""font-weight: 500;"">Hima Cosmetics</h3><br />
                    <h6 id=""companySlogan"" style=""margin-top: -21px;font-size: 10px;"">Buy Cosmetics</h6>
                </td>
                <td width=""20%""></td>
                <td>
                    <h3 style=""font-weight: 900;"">INVOICE</h3><br />
                    <h6 style=""margin-top: -21px;font-size: 9px;"">No. <b id=""invoiceNumber"">#");
#nullable restore
#line 27 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                                                                        Write(Model.InvoiceNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></h6>
                </td>
            </tr>
            <tr>
                <td> <h6 style=""font-size: 11px; text-align:center; margin-top: -20px;"">Email: admin@gmail.com</h6></td>
                <td width=""20%""></td>
                <td>
                    <h6 id=""date"" style=""font-size: 11px;margin-top: -20px;"">Date: ");
#nullable restore
#line 34 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                                                              Write(Convert.ToDateTime(Model.CreatedDate).ToString("dd MMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td style=\"text-align:right;\">Customer Name:</td>\r\n                <td style=\"text-align:left;\"><b>");
#nullable restore
#line 39 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                           Write(Model.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                <td width=\"20%\"></td>\r\n                <td></td>\r\n            </tr>\r\n            <tr>\r\n                <td style=\"text-align:right;\">Contact:</td>\r\n                <td style=\"text-align:left;\"><b>");
#nullable restore
#line 45 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                           Write(Model.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <br /><b>");
#nullable restore
#line 45 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                                                              Write(Model.Customer.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                <td width=\"20%\"></td>\r\n                <td></td>\r\n            </tr>\r\n            <tr>\r\n                <td style=\"text-align:right;\">Payment Mode:</td>\r\n                <td style=\"text-align:left;\"><b>");
#nullable restore
#line 51 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                           Write(Model.PaymentMode);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></td>
                <td width=""20%""></td>
                <td></td>
            </tr>
        </table>
        <table class=""table table-bordered"" id=""invoiceTable"">
            <thead style=""text-align:center;"">
                <tr>
                    <th>Description</th>
                    <th>Quantity</th>
                    <th>Unit Price</th>
                    <th>Price</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 66 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                  
                    foreach (var item in Model.SalesInvoiceDetails)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 70 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"text-align:right;\">");
#nullable restore
#line 71 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                                     Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 71 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                                                          Write(item.Product.Unit.ShortForm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                            <td style=\"text-align:right;\">");
#nullable restore
#line 72 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                                     Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td style=\"text-align:right;\">");
#nullable restore
#line 73 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /-</td>\r\n                        </tr>\r\n");
#nullable restore
#line 75 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n            <tfoot>\r\n                <tr>\r\n                    <td style=\"text-align:right;\">In Words</td>\r\n                    <td id=\"amountInWords\" style=\"text-align:right;\">");
#nullable restore
#line 81 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                                                Write(Model.UpdatedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align:right;\">Sub Total</td>\r\n                    <td style=\"text-align:right;\">");
#nullable restore
#line 83 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                             Write(Model.SubTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /-</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"3\" style=\"text-align:right;\">Discount</td>\r\n                    <td style=\"text-align:right;\">");
#nullable restore
#line 87 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                             Write(Model.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"3\" style=\"text-align:right;\">Grand Total</td>\r\n                    <td style=\"text-align:right;\" id=\"grandTotal\">");
#nullable restore
#line 91 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                                             Write(Model.GrandTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /-</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"3\" style=\"text-align:right;\">Paid Amount</td>\r\n                    <td style=\"text-align:right;\">");
#nullable restore
#line 95 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                             Write(Model.PaidAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /-</td>\r\n                </tr>\r\n                <tr>\r\n                    <td colspan=\"3\" style=\"text-align:right;\">Dues</td>\r\n                    <td style=\"text-align:right;\">");
#nullable restore
#line 99 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\SalesInvoice\_SalesInvoiceInformation.cshtml"
                                             Write(Model.Dues);

#line default
#line hidden
#nullable disable
            WriteLiteral(" /-</td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n    </div>\r\n    <div class=\"col-md-1\"></div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<POSSystemWithInventory.EntityModel.SalesInvoice> Html { get; private set; }
    }
}
#pragma warning restore 1591
