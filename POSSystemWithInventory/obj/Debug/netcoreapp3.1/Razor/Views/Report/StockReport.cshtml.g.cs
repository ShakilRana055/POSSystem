#pragma checksum "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\Report\StockReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6519586398ff6bf8317c46e6226f5c6dacb56aaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_StockReport), @"mvc.1.0.view", @"/Views/Report/StockReport.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6519586398ff6bf8317c46e6226f5c6dacb56aaf", @"/Views/Report/StockReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b6b5139d3f04192678769d821201b7c793563f", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_StockReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\Report\StockReport.cshtml"
  
    ViewData["Title"] = "Stock Report";
    Layout = "~/Views/Shared/_POSLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .odd {
        background-color: #b3ffff;
    }

    .even {
        background-color: #b3b3ff;
    }

    .rightAlign{
        text-align:right;
    }
    .centerAlign{
        text-align:center;
    }
    #stockList tr td{
        font-weight:bold;
    }
</style>
<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div id=""headingOne"" class=""card-header bg-blue1"">
                <button type=""button"" data-toggle=""collapse"" data-target=""#advanceSearchProductList"" aria-expanded=""true"" class=""text-left m-0 p-0 btn btn-block"" style=""box-shadow: none;"">
                    <h5 class=""m-0 p-0"" style=""color: #fff;"">Stock Report</h5>
                </button>
            </div>
            <div class=""card-body"">
                <div id=""advanceSearchProductList"" class=""collapse show"">
");
            WriteLiteral(@"                    <div class=""row"">
                        <div class=""table-responsive"" id=""printStockReport"">
                            <table class=""table table-hover table-bordered"" id=""stockList"">
                                <thead style=""background-color:coral;"">
                                    <tr class=""center"">
                                        <th>Product Name</th>
                                        <th>Quantity</th>
                                        <th>Warning Quantity</th>
                                        <th>Sell Price</th>
                                        <th>Price</th>
                                    </tr>
                                </thead>
                                <tbody>
                                </tbody>
                                <tfoot style=""background-color:coral;"">
                                    <tr>
                                        <td colspan=""4"" style=""text-align:right;"">total</td>
 ");
            WriteLiteral(@"                                       <td style=""text-align:right;"" id=""totalPrice""></td>
                                    </tr>
                                </tfoot>
                            </table>
                        </div>
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

            let selector = {
                productList: $(""#stockList""),
                totalPrice: $(""#totalPrice""),
                printBtnStockReport: $(""#printBtnStockReport""),
            };

            function GenerateBrandList() {
                let totalPrice = 0;

                var brandList = selector.productList.dataTable({
                    ""processing"": true,
                    ""serverSide"": true,
                    ""filter"": true,
                    ""pageLength"": 10,
                    ""autoWidth"": false,
                    'dom': ""<'row'<'col-sm-3'l><'col-sm-5 text-center'B><'col-sm-4'f>>"" + ""<'row'<'col-sm-12'tr>>"" + ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
                    ""lengthMenu"": [[10, 50, 100, 150, 200, 500], [10, 50, 100, 150, 200, 500]],
                    ""order"": [[0, ""desc""]],
                    ""ajax"": {
                        ""url"": ""/Report/GetStockReport/"",
                        ""type"": ""POST"",");
                WriteLiteral(@"
                        ""data"": function (data) {

                        },
                        ""complete"": function (json) {
                            totalPrice = 0;
                        }
                    },
                    ""columnDefs"": [
                        { ""className"": ""centerAlign"", ""targets"": [0, 1, 2] },
                        { ""className"": ""rightAlign"", ""targets"": [3,4] },
                    ],
                    ""columns"": [
                        { ""data"": ""product.name"", ""name"": ""product.name"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""availableQuantity"", ""name"": ""availableQuantity"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""product.warningQuantity"", ""name"": ""product.warningQuantity"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""sellPrice"", ""name"": ""sellPrice"", ""autowidth"": true, ""orderable"": true },
                        {
                            ""r");
                WriteLiteral(@"ender"": function (data, type, full, meta) {
                                totalPrice += (full.availableQuantity * full.sellPrice);
                                return (full.availableQuantity * full.sellPrice).toFixed(2);
                            }
                        },
                        
                    ],
                    ""footerCallback"": function (row, data, start, end, display) {
                        var api = this.api(), data;
                        $(api.column(4).footer()).html(""="" + totalPrice.toFixed(2) + ""/-"");
                        totalPrice = 0;
                    }
                });
                
            }

            window.onload = function () {
                GenerateBrandList();
            }
            selector.printBtnStockReport.click(function () {
                printDiv(""printStockReport"");
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
