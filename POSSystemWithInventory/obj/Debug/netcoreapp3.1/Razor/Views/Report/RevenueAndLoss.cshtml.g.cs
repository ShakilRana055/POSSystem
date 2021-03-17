#pragma checksum "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\Report\RevenueAndLoss.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81a6b91fceaf2c59152702e9f415ccbaf21768de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_RevenueAndLoss), @"mvc.1.0.view", @"/Views/Report/RevenueAndLoss.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81a6b91fceaf2c59152702e9f415ccbaf21768de", @"/Views/Report/RevenueAndLoss.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b6b5139d3f04192678769d821201b7c793563f", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_RevenueAndLoss : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\Report\RevenueAndLoss.cshtml"
  
    ViewData["Title"] = "Income Statement";
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

    #purchaseProductList tr, td {
        text-align: center;
    }

    .rightAlign {
        text-align: right;
    }
</style>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div id=""headingOne"" class=""card-header bg-blue1"">
                <button type=""button"" data-toggle=""collapse"" data-target=""#advanceSearchProductList"" aria-expanded=""true"" class=""text-left m-0 p-0 btn btn-block"" style=""box-shadow: none;"">
                    <h5 class=""m-0 p-0"" style=""color: #fff;"">Income Statement</h5>
                </button>
            </div>
            <div class=""card-body"">
                <div id=""advanceSearchProductList"" class=""collapse show"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=");
            WriteLiteral(@"""control-label"">Start Date</label>
                                <input type=""text"" class=""datepicker form-control"" id=""startDate"" />
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""control-label"">End Date</label>
                                <input type=""text"" class=""datepicker form-control"" id=""endDate"" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-primary btn-sm"" id=""resetIncomeStatement"">Reset</button>
                <button class=""btn btn-secondary btn-sm"" id=""showIncomeStatment"">Show</button>
            </div>
        </div>
    </div>
    <div class=""col-md-12"" style=""display:none;"" id=""showIncomeReport"">
        <div class=""card"">
            <");
            WriteLiteral(@"div id=""headingTwo"" class=""card-header bg-blue1"">
                <button type=""button"" data-toggle=""collapse"" data-target=""#incomeReport"" aria-expanded=""true"" class=""text-left m-0 p-0 btn btn-block"" style=""box-shadow: none;"">
                    <h5 class=""m-0 p-0"" style=""color: #fff;"">Income Statement Report</h5>
                </button>
            </div>
            <div class=""card-body"">

                <div id=""incomeReport"" class=""collapse show"">


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

            function GeneratePurchaseInRange(startDate, endDate) {
                var purchaseList = $(""#purchaseBtnIncomeList"").dataTable({
                    ""processing"": true,
                    ""serverSide"": true,
                    ""filter"": true,
                    ""pageLength"": 10,
                    ""autoWidth"": false,
                    'dom': ""<'row'<'col-sm-3'l><'col-sm-5 text-center'B><'col-sm-4'f>>"" + ""<'row'<'col-sm-12'tr>>"" + ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
                    ""lengthMenu"": [[10, 50, 100, 150, 200, 500], [10, 50, 100, 150, 200, 500]],
                    ""order"": [[0, ""desc""]],
                    ""ajax"": {
                        ""url"": ""/Report/PurchaseListInRange/"",
                        ""type"": ""POST"",
                        ""data"": function (data) {
                            data.startDate = startDate;
                            data.endDate = e");
                WriteLiteral(@"ndDate;
                        },
                        ""complete"": function (json) {

                        }
                    },
                    ""columnDefs"": [
                        { ""className"": ""custome"", ""targets"": [0, 1, 2, 3] },
                    ],
                    ""columns"": [
                        { ""data"": ""invoiceNumber"", ""name"": ""invoiceNumber"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""supplier.name"", ""name"": ""supplier.name"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""grandTotal"", ""name"": ""grandTotal"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""paidAmount"", ""name"": ""paidAmount"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""dues"", ""name"": ""dues"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""createdDate"", ""name"": ""createdDate"", ""autowidth"": true, ""orderable"": true },
                    ],
              ");
                WriteLiteral(@"      ""footerCallback"": function (row, data, start, end, display) {
                        var api = this.api(), data;
                        var intVal = function (i) {
                            return typeof i === 'string' ?
                                i.replace(/[\$,]/g, '') * 1 :
                                typeof i === 'number' ?
                                    i : 0;
                        };

                        let column2 = intVal;
                        let column3 = intVal;
                        let column4 = intVal;

                        let grandTotal = api
                            .column(2)
                            .data()
                            .reduce(function (a, b) {
                                return column2(a) + column2(b);
                            }, 0);

                        let paidAmount = api
                            .column(3)
                            .data()
                            .reduce(function (a,");
                WriteLiteral(@" b) {
                                return column3(a) + column3(b);
                            }, 0);

                        let duesAmount = api
                            .column(4)
                            .data()
                            .reduce(function (a, b) {
                                return column4(a) + column4(b);
                            }, 0);

                        $(api.column(2).footer()).html(""= "" + grandTotal + ""/-"");
                        $(api.column(3).footer()).html(""= "" + paidAmount + ""/-"");
                        $(api.column(4).footer()).html(""= "" + duesAmount + ""/-"");
                    }

                });
            }
            function GenerateSalesInRange(startDate, endDate) {
                var purchaseList = $(""#salesBtnIncomeList"").dataTable({
                    ""processing"": true,
                    ""serverSide"": true,
                    ""filter"": true,
                    ""pageLength"": 10,
                    ""autoWi");
                WriteLiteral(@"dth"": false,
                    'dom': ""<'row'<'col-sm-3'l><'col-sm-5 text-center'B><'col-sm-4'f>>"" + ""<'row'<'col-sm-12'tr>>"" + ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
                    ""lengthMenu"": [[10, 50, 100, 150, 200, 500], [10, 50, 100, 150, 200, 500]],
                    ""order"": [[0, ""desc""]],
                    ""ajax"": {
                        ""url"": ""/Report/SalesListInRange/"",
                        ""type"": ""POST"",
                        ""data"": function (data) {
                            data.startDate = startDate;
                            data.endDate = endDate;
                        },
                        ""complete"": function (json) {

                        }
                    },
                    ""columnDefs"": [
                        { ""className"": ""custome"", ""targets"": [0, 1, 2, 3] },
                    ],
                    ""columns"": [
                        { ""data"": ""invoiceNumber"", ""name"": ""invoiceNumber"", ""autowidth"": true, ""orderable"": tr");
                WriteLiteral(@"ue },
                        { ""data"": ""customer.name"", ""name"": ""customer.name"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""grandTotal"", ""name"": ""grandTotal"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""paidAmount"", ""name"": ""paidAmount"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""dues"", ""name"": ""dues"", ""autowidth"": true, ""orderable"": true },
                        { ""data"": ""createdDate"", ""name"": ""createdDate"", ""autowidth"": true, ""orderable"": true },
                    ],
                    ""footerCallback"": function (row, data, start, end, display) {
                        var api = this.api(), data;
                        var intVal = function (i) {
                            return typeof i === 'string' ?
                                i.replace(/[\$,]/g, '') * 1 :
                                typeof i === 'number' ?
                                    i : 0;
                        };
");
                WriteLiteral(@"
                        let column2 = intVal;
                        let column3 = intVal;
                        let column4 = intVal;

                        let grandTotal = api
                            .column(2)
                            .data()
                            .reduce(function (a, b) {
                                return column2(a) + column2(b);
                            }, 0);

                        let paidAmount = api
                            .column(3)
                            .data()
                            .reduce(function (a, b) {
                                return column3(a) + column3(b);
                            }, 0);

                        let duesAmount = api
                            .column(4)
                            .data()
                            .reduce(function (a, b) {
                                return column4(a) + column4(b);
                            }, 0);

                        $(api.column(");
                WriteLiteral(@"2).footer()).html(""= "" + grandTotal + ""/-"");
                        $(api.column(3).footer()).html(""= "" + paidAmount + ""/-"");
                        $(api.column(4).footer()).html(""= "" + duesAmount + ""/-"");
                    }
                });
            }

            let selector = {
                resetIncomeStatement: $(""#resetIncomeStatement""),
                showIncomeStatment: $(""#showIncomeStatment""),
                startDate: $(""#startDate""),
                endDate: $(""#endDate""),
                showIncomeReport: $(""#showIncomeReport""),
                incomeReport: $(""#incomeReport""),

                incomeStatement: """",
                printBtnIncomeStatement: $(""#printBtnIncomeStatement""),
            }
            selector.resetIncomeStatement.click(function () {
                selector.startDate.val("""");
                selector.endDate.val("""");
            });

            selector.showIncomeStatment.click(function () {
                if (selector.startDa");
                WriteLiteral(@"te.val() != """" && selector.endDate.val() != """") {
                    let jsonData = {
                        startDate: selector.startDate.val(),
                        endDate: selector.endDate.val(),
                    };
                    let htmlData = ajaxOperation.GetAjaxHtmlByJson(""/Report/IncomeStatement"", jsonData);
                    selector.showIncomeReport.show();
                    selector.incomeReport.html(htmlData);
                    selector.incomeStatement = htmlData;
                    $(""#firstIncomeBtn"").click();
                    GeneratePurchaseInRange(jsonData.startDate, jsonData.endDate);
                    GenerateSalesInRange(jsonData.startDate, jsonData.endDate);
                }
                else {
                    toastr.error(""Fill Up the Range!"", ""Error"");
                }

            });
            selector.resetIncomeStatement.click(function () {
                selector.showIncomeReport.hide();
                selector.startDate.v");
                WriteLiteral(@"al("""");
                selector.endDate.val("""");
            });

            $(document).on(""click"", ""#printBtnIncomeStatement"", function () {
                printDiv(""printIncomeStatement"");
                setTimeout(function () {
                    printDiv(""printIncomeStatement"");
                }, 500);
            });
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
