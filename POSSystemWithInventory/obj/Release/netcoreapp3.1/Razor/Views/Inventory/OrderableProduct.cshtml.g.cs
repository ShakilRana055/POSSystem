#pragma checksum "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\Inventory\OrderableProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed7dcf6444ac7c9cbe1273bf097e61f8fc6c14dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_OrderableProduct), @"mvc.1.0.view", @"/Views/Inventory/OrderableProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed7dcf6444ac7c9cbe1273bf097e61f8fc6c14dd", @"/Views/Inventory/OrderableProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64b6b5139d3f04192678769d821201b7c793563f", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_OrderableProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Core\POSSystemWithInventory\POSSystemWithInventory\Views\Inventory\OrderableProduct.cshtml"
  
    ViewData["Title"] = "Orderable Product";
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
    .centerAlign {
        text-align: center;
    }
</style>

<div class=""row"">
    <div class=""col-md-12"">
        <div class=""card"">
            <div id=""headingTwo"" class=""card-header bg-blue1"">
                <button type=""button"" data-toggle=""collapse"" data-target=""#Collapse"" aria-expanded=""true"" class=""text-left m-0 p-0 btn btn-block"" style=""box-shadow: none;"">
                    <h5 class=""m-0 p-0"" style=""color: #fff;"">Orderable Product List</h5>
                </button>
            </div>
            <div class=""card-body table-responsive"">
                <table class=""table table-hover table-bordered"" id=""orderableProductList"">
                    <thead>
                        <tr style=""background-color:coral;"">
                            <th>Product Name</th>
                            <th>Available Quantity</th>
                            <th>Warnin");
            WriteLiteral("g Quantity</th>\r\n                        </tr>\r\n                    </thead>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    (function () {
        let selector = {
            orderableProductList: $(""#orderableProductList""),
        };
        function GenerateOrderable() {
            var orderableProductList = selector.orderableProductList.dataTable({
                ""processing"": true,
                ""serverSide"": true,
                ""filter"": true,
                ""pageLength"": 10,
                ""autoWidth"": false,
                'dom': ""<'row'<'col-sm-3'l><'col-sm-5 text-center'B><'col-sm-4'f>>"" + ""<'row'<'col-sm-12'tr>>"" + ""<'row'<'col-sm-5'i><'col-sm-7'p>>"",
                ""lengthMenu"": [[10, 50, 100, 150, 200, 500], [10, 50, 100, 150, 200, 500]],
                ""order"": [[0, ""desc""]],
                ""ajax"": {
                    ""url"": ""/Inventory/OrderableProductList/"",
                    ""type"": ""POST"",
                    ""data"": function (data) {

                    },
                    ""complete"": function (json) {

                    }
                },
       ");
                WriteLiteral(@"         ""columnDefs"": [
                    { ""className"": ""centerAlign"", ""targets"": [0, 1, 2] },
                ],
                ""columns"": [
                    { ""data"": ""name"", ""name"": ""name"", ""autowidth"": true, ""orderable"": true },
                    { ""data"": ""availableQuantity"", ""name"": ""availableQuantity"", ""autowidth"": true, ""orderable"": true },
                    { ""data"": ""warningQuantity"", ""name"": ""description"", ""autowidth"": true, ""orderable"": true },
                   
                ]
            });
        }


        window.onload = function () {
            GenerateOrderable();
        }
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