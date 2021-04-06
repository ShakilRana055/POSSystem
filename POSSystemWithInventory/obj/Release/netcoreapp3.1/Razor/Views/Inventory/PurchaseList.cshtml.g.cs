#pragma checksum "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\Inventory\PurchaseList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b25aec6a5f84a1ca2c2b7425e4fdaf3bac146d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_PurchaseList), @"mvc.1.0.view", @"/Views/Inventory/PurchaseList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b25aec6a5f84a1ca2c2b7425e4fdaf3bac146d", @"/Views/Inventory/PurchaseList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b6b5139d3f04192678769d821201b7c793563f", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_PurchaseList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\Inventory\PurchaseList.cshtml"
  
    ViewData["Title"] = "Purchase List";
    Layout = "~/Views/Shared/_POSLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .odd {
        background-color: #b3ffff;
    }

    .even {
        background-color: #b3b3ff;
    }
    #purchaseProductList tr, td{
        text-align:center;
    }
    .rightAlign{
        text-align:right;
    }
</style>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div id=""headingOne"" class=""card-header bg-blue1"">
                <button type=""button"" data-toggle=""collapse"" data-target=""#advanceSearchPurchaseProductList"" aria-expanded=""true"" class=""text-left m-0 p-0 btn btn-block"" style=""box-shadow: none;"">
                    <h5 class=""m-0 p-0"" style=""color: #fff;"">Purchase List</h5>
                </button>
            </div>
            <div class=""card-body"">
                <div id=""advanceSearchPurchaseProductList"" class=""collapse show"">
                    <div class=""row table-responsive"">
                        <table class=""table table-hover table-bordered"" id=""purchaseProductList"">
                            ");
            WriteLiteral(@"<thead>
                                <tr style=""background-color:coral;"">
                                    <th>Invoice</th>
                                    <th>Supplier Name</th>
                                    <th>Grand Total</th>
                                    <th>Paid Amount</th>
                                    <th>Dues</th>
                                    <th>Date</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>

                            </tbody>
                            <tfoot>
                                <tr style=""background-color: coral;"">
                                    <td></td>
                                    <td></td>
                                    <td id=""grandTotal"" class=""rightAlign""></td>
                                    <td id=""paidAmount"" class=""rightAlign""></td>
                                    <td ");
            WriteLiteral(@"id=""duesAmount"" class=""rightAlign""></td>
                                    <td></td>
                                    <td></td>
                                </tr>
                            </tfoot>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    (function () {
        let ajaxOperation = new AjaxOperation();
        let modalOperation = new ModalOperation();

        let selector = {
            purchaseProductList: $(""#purchaseProductList""),
            grandTotal: $(""#grandTotal""),
            paidAmount: $(""#paidAmount""),
            duesAmount: $(""#duesAmount""),
            purchaseBtnInformationReport: $(""#purchaseBtnInformationReport""),
        };
        function GeneratePurchaseProductList() {
            let grandTotal = 0;
            let dues = 0;
            let paidAmount = 0;
            var purchaseProductList = selector.purchaseProductList.dataTable({
                ""processing"": true,
                ""serverSide"": true,
                ""filter"": true,
                ""pageLength"": 10,
                ""autoWidth"": false,
                'dom': ""<'row'<'col-sm-3'l><'col-sm-5 text-center'B><'col-sm-4'f>>"" + ""<'row'<'col-sm-12'tr>>"" + ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
                ""lengthMenu");
                WriteLiteral(@""": [[10, 50, 100, 150, 200, 500], [10, 50, 100, 150, 200, 500]],
                ""order"": [[0, ""desc""]],
                ""ajax"": {
                    ""url"": ""/Inventory/GetPurchaseList/"",
                    ""type"": ""POST"",
                    ""data"": function (data) {

                    },
                    ""complete"": function (json) {

                    }
                },
                ""columnDefs"": [
                    { ""className"": ""rightAlign"", ""targets"": [ 2, 3, 4 ] },
                ],
                ""columns"": [
                    { ""data"": ""invoiceNumber"", ""name"": ""invoiceNumber"", ""autowidth"": true, ""orderable"": true },
                    { ""data"": ""supplier.name"", ""name"": ""supplier.name"", ""autowidth"": true, ""orderable"": true},
                    { ""data"": ""grandTotal"", ""name"": ""grandTotal"", ""autowidth"": true, ""orderable"": true},
                    { ""data"": ""paidAmount"", ""name"": ""paidAmount"", ""autowidth"": true, ""orderable"": true},
                    { ""data"":");
                WriteLiteral(@" ""dues"", ""name"": ""dues"", ""autowidth"": true, ""orderable"": true},
                    { ""data"": ""createdDate"", ""name"": ""createdDate"", ""autowidth"": true, ""orderable"": true},
                    {
                        ""render"": function (data, type, full, meta) {
                            grandTotal += full.grandTotal;
                            dues += full.dues;
                            paidAmount += full.paidAmount;

                            selector.grandTotal.text(""= "" + grandTotal.toFixed(2));
                            selector.paidAmount.text(""= "" + paidAmount.toFixed(2));
                            selector.duesAmount.text(""= "" + dues.toFixed(2));

                            return `
                                <div class=""btn-group"">
                                    <i class=""fa fa-ellipsis-h"" title = 'Actions' style = 'cursor:pointer;' data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""></i>
                                  <div class=""dropdown-menu"" ");
                WriteLiteral(@">
                                    <button style=""font-size: inherit;"" class=""dropdown-item btn-rx viewPurchaseProductList""  invoiceNumber = ""${full.invoiceNumber}"" ><i class=""fa fa-info-circle"" aria-hidden=""true""></i>View</button >
                                  </div>
                                </div>`;

                            ///Product/ProductEditView ? search = ${ full.id }
                            //<a style=""font-size: inherit;"" class=""dropdown-item btn-rx"" href=""#"" ><i class=""fa fa-check-circle"" aria-hidden=""true""></i>Edit</a >
                            //    <button style=""font-size: inherit;"" class=""dropdown-item btn-rx"" invoiceNumber=""${full.invoiceNumber}""  > <i class=""fa fa-times"" aria-hidden=""true""></i>Delete</button >

                        }
                    },
                ]
            });
            
            selector.tableInformation = purchaseProductList;
        }
        window.onload = function () {
            GeneratePurchaseProductLi");
                WriteLiteral(@"st();
        }

        $(document).on(""click"", "".viewPurchaseProductList"", function () {
            let invoiceNumber = $(this).attr(""invoiceNumber"");
            let htmlData = ajaxOperation.GetAjaxHtmlByValue(""/Inventory/PurchaseInformation"", invoiceNumber);

            $(""#modalHeading"").text(""Purchase Details"");
            modalOperation.ModalStatic(""#informationModal"");
            modalOperation.ModalOpenWithHtml(""#informationModal"", ""#informationModalDiv"", htmlData);
        });
        $(document).on(""click"", ""#purchaseBtnInformationReport"", function () {
            printDiv(""purchaseInformationReport"");
        })
    })();
</script>
");
            }
            );
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
