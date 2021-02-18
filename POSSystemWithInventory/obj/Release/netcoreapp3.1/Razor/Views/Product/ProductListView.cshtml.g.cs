#pragma checksum "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\Product\ProductListView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ecc6527c8e11e81f3ea1e2a1217a4e8fd95c890"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductListView), @"mvc.1.0.view", @"/Views/Product/ProductListView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ecc6527c8e11e81f3ea1e2a1217a4e8fd95c890", @"/Views/Product/ProductListView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0954828e5840935f343bc924c396ef2b26707336", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductListView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<POSSystemWithInventory.Models.ProductVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\Product\ProductListView.cshtml"
  
    ViewData["Title"] = "Product List";
    Layout = "~/Views/Shared/_POSLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .odd {\r\n        background-color: #b3ffff;\r\n    }\r\n\r\n    .even {\r\n        background-color: #b3b3ff;\r\n    }\r\n</style>\r\n\r\n<div class=\"row\">\r\n");
            WriteLiteral(@"
    <div class=""col-md-12"">
        <div class=""card"">
            <div id=""headingOne"" class=""card-header bg-blue1"">
                <button type=""button"" data-toggle=""collapse"" data-target=""#advanceSearchProductList"" aria-expanded=""true"" class=""text-left m-0 p-0 btn btn-block"" style=""box-shadow: none;"">
                    <h5 class=""m-0 p-0"" style=""color: #fff;"">Product List</h5>
                </button>
            </div>
            <div class=""card-body"">
                <div id=""advanceSearchProductList"" class=""collapse show"">
                    <div class=""row table-responsive"">
                        <table class=""table table-hover table-bordered"" id=""productList"">
                            <thead>
                                <tr>
                                    <th>Name</th>
                                    <th>Brand</th>
                                    <th>Category</th>
                                    <th>Unit</th>
                                    <th>W");
            WriteLiteral(@"arning Quantity</th>
                                    <th>Photo</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
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
                productList: $(""#productList""),
                tableInformation: '',
                brandId: $(""#BrandId""),
                categoryId: $(""#CategoryId""),
                unitId: $(""#UnitId""),
            };

            let search = {
                brandId:0,
                categoryId:0,
                unitId:0,
            }

            function GenerateBrandList() {
                var brandList = selector.productList.dataTable({
                    ""processing"": true,
                    ""serverSide"": true,
                    ""filter"": true,
                    ""pageLength"": 10,
                    ""autoWidth"": false,
                    'dom': ""<'row'<'col-sm-3'l><'col-sm-5 text-center'B><'col-sm-4'f>>"" + ""<'row'<'col-sm-12'tr>>"" + ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
          ");
                WriteLiteral(@"          ""lengthMenu"": [[10, 50, 100, 150, 200, 500], [10, 50, 100, 150, 200, 500]],
                    ""order"": [[0, ""desc""]],
                    ""ajax"": {
                        ""url"": ""/Product/ProductList/"",
                        ""type"": ""POST"",
                        ""data"": function (data) {
                            categoryId = search.categoryId;
                            brandId = search.brandId;
                            unitId = search.unitId;
                            console.log(search);
                        },
                        ""complete"": function (json) {

                        }
                    },
                    ""columnDefs"": [
                        { ""className"": ""custome"", ""targets"": [0, 1, 2, 3] },
                    ],
                    ""columns"": [
                        { ""data"": ""name"", ""name"": ""name"", ""autowidth"": true, ""orderable"": true },
                        {
                            ""render"": function (data, type");
                WriteLiteral(@", full, meta) {
                                return full.brand !== null ? full.brand.name : """";
                            }
                        },
                        {
                            ""render"": function (data, type, full, meta) {
                                return full.category !== null ? full.category.name : """";
                            }
                        },
                        {
                            ""render"": function (data, type, full, meta) {
                                return full.unit !== null ? full.unit.shortForm : """";
                            }
                        },
                        { ""data"": ""warningQuantity"", ""name"": ""warningQuantity"", ""autowidth"": true, ""orderable"": true },
                        {
                            ""render"": function (data, type, full, meta) {
                                return `<img src = ${full.photoUrl} width = ""20"" height = ""20""/>`;
                            }
           ");
                WriteLiteral(@"             },
                        {
                            ""render"": function (data, type, full, meta) {
                                return `
                                <div class=""btn-group"">
                                    <i class=""fa fa-ellipsis-h"" title = 'Actions' style = 'cursor:pointer;' data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""></i>
                                  <div class=""dropdown-menu"" >
                                    <button style=""font-size: inherit;"" class=""dropdown-item btn-rx viewProductInformation""  productId = ""${full.id}"" ><i class=""fa fa-info-circle"" aria-hidden=""true""></i>View</button >
                                    <a style=""font-size: inherit;"" class=""dropdown-item btn-rx"" href = ""/Product/ProductEditView?search=${full.id}""><i class=""fa fa-check-circle"" aria-hidden=""true""></i>Edit</a >
                                    <button style=""font-size: inherit;"" class=""dropdown-item btn-rx deleteProductInformation"" produ");
                WriteLiteral(@"ctId = ""${full.id}"" > <i class=""fa fa-times"" aria-hidden=""true""></i>Delete</button >
                                  </div>
                                </div>`;
                            }
                        },
                    ]
                });
                selector.tableInformation = brandList;
            }

            window.onload = function () {
                GenerateBrandList();
            }

            $(document).on(""click"", "".deleteProductInformation"", function () {
                let productId = $(this).attr(""productId"");
                Swal.fire({
                    title: 'Are You Sure?',
                    text: """",
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Yes',
                    showConfirmButton: true,
                    allowEscapeKey: false,
               ");
                WriteLiteral(@"     allowOutsideClick: false,

                }).then((result) => {
                    if (result.value) {
                        let hasDone = ajaxOperation.DeleteAjaxById(""/Product/DeleteProduct"", productId);
                        if (hasDone === true) {
                            toastr.success('Successfully Deleted!', 'Success');
                            selector.tableInformation.fnFilter();
                        }
                        else {
                            toastr.error('Something went wrong', 'Error');
                        }
                    }
                });
            });


            $(document).on(""click"", "".viewProductInformation"", function () {
                let productId = $(this).attr(""productId"");
                let htmlData = ajaxOperation.GetAjaxHtmlByValue(""/Product/ProductInformation"", productId);

                $(""#modalHeading"").text(""Product Information"");
                modalOperation.ModalStatic(""#informationModal"");
 ");
                WriteLiteral(@"               modalOperation.ModalOpenWithHtml(""#informationModal"", ""#informationModalDiv"", htmlData);
            });

            selector.brandId.change(function () {
                search.brandId = Number(selector.brandId.val());
                selector.tableInformation.fnFilter();
            });
            selector.categoryId.change(function () {
                search.categoryId = Number(selector.categoryId.val());
                selector.tableInformation.fnFilter();
            });
            selector.unitId.change(function () {
                search.unitId = Number(selector.unitId.val());
                selector.tableInformation.fnFilter();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<POSSystemWithInventory.Models.ProductVM> Html { get; private set; }
    }
}
#pragma warning restore 1591