#pragma checksum "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\VatAndTax\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ab120813c388e6d390701b6f382e365a62738d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VatAndTax_Index), @"mvc.1.0.view", @"/Views/VatAndTax/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ab120813c388e6d390701b6f382e365a62738d5", @"/Views/VatAndTax/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0954828e5840935f343bc924c396ef2b26707336", @"/Views/_ViewImports.cshtml")]
    public class Views_VatAndTax_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<POSSystemWithInventory.Models.VatAndTaxVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("vatAndTaxCreateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\VatAndTax\Index.cshtml"
  
    ViewData["Title"] = "Vat & Tax";
    Layout = "~/Views/Shared/_POSLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .odd {\r\n        background-color: #b3ffff;\r\n    }\r\n\r\n    .even {\r\n        background-color: #b3b3ff;\r\n    }\r\n</style>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab120813c388e6d390701b6f382e365a62738d56307", async() => {
                WriteLiteral(@"
            <div class=""card"">
                <div id=""headingOne"" class=""card-header bg-blue1"">
                    <button type=""button"" data-toggle=""collapse"" data-target=""#Collapse"" aria-expanded=""true"" class=""text-left m-0 p-0 btn btn-block"" style=""box-shadow: none;"">
                        <h5 class=""m-0 p-0"" style=""color: #fff;"">Add Vat & Tax</h5>
                    </button>
                </div>
                <div class=""card-body"">
                    <div id=""Collapse"" class=""collapse show"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab120813c388e6d390701b6f382e365a62738d57310", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 32 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\VatAndTax\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ab120813c388e6d390701b6f382e365a62738d58931", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 33 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\VatAndTax\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab120813c388e6d390701b6f382e365a62738d510546", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 34 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\VatAndTax\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab120813c388e6d390701b6f382e365a62738d512342", async() => {
                    WriteLiteral("Percentage");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 37 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\VatAndTax\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Amount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1ab120813c388e6d390701b6f382e365a62738d514015", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 38 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\VatAndTax\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Amount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ab120813c388e6d390701b6f382e365a62738d515849", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 39 "G:\ProjectPOS\POSSystemWithInventory\POSSystemWithInventory\Views\VatAndTax\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Amount);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" id=""vatAndTaxResetBtn"">Reset</button>
                        <button type=""button"" id=""vatAndTaxCreateBtn"" class=""btn btn-primary"">Save</button>
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""col-md-6"">
        <div class=""card"">
            <div id=""headingTwo"" class=""card-header bg-blue1"">
                <button type=""button"" data-toggle=""collapse"" data-target=""#Collapse"" aria-expanded=""true"" class=""text-left m-0 p-0 btn btn-block"" style=""box-shadow: none;"">
                    <h5 class=""m-0 p-0"" style=""color: #fff;"">Vat & Tax List</h5>
                </button>
            </div>
            <div class=""card-body table-responsive"">
                <table class=""table table-hover table-bordered"" id=""vatAndTaxList"">
                    <thead style=""background-color: #ffd9b3;"">
                        <tr>
                            <th>Name</th>
                            <th>Percentage</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                </table>
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
                name: $(""#Name""),
                amount: $(""#Amount""),
                vatAndTaxCreateBtn: $(""#vatAndTaxCreateBtn""),
                vatAndTaxCreateForm: $(""#vatAndTaxCreateForm""),
                vatAndTaxList: $(""#vatAndTaxList""),
                vatAndTaxResetBtn: $(""#vatAndTaxResetBtn""),
                tableInformation: '',
                globalId: '',
            };
            let validator = selector.vatAndTaxCreateForm.validate({
                // Specify validation rules
                rules: {
                    Name: {
                        required: true,
                    },
                    Amount: {
                        required: true,
                    },
                },
                // Specify validation error messages
                messages: {
       ");
                WriteLiteral(@"             Name: ""Name Field is required"",
                    Amount: ""Can't Empty"",
                },
                // Make sure the form is submitted to the destination defined
                // in the ""action"" attribute of the form when valid
                submitHandler: function (form) {

                }
            });

            function GenerateVatAndTaxList() {
                var vatAndTaxList = selector.vatAndTaxList.dataTable({
                    ""processing"": true,
                    ""serverSide"": true,
                    ""filter"": true,
                    ""pageLength"": 10,
                    ""autoWidth"": false,
                    ""lengthMenu"": [[10, 50, 100, 150, 200, 500], [10, 50, 100, 150, 200, 500]],
                    ""order"": [[0, ""desc""]],
                    ""ajax"": {
                        ""url"": ""/VatAndTax/VatAndTaxList/"",
                        ""type"": ""POST"",
                        ""data"": function (data) {

                        },
 ");
                WriteLiteral(@"                       ""complete"": function (json) {

                        }
                    },
                    ""columnDefs"": [
                        { ""className"": ""custome"", ""targets"": [0, 1, 2] },
                    ],
                    ""columns"": [
                        { ""data"": ""name"", ""name"": ""name"", ""autowidth"": true, ""orderable"": true },
                        {
                            ""render"": function (data, type, full, meta) {
                                return full.amount.toFixed(2);
                            }
                        },
                        {
                            ""render"": function (data, type, full, meta) {
                                return `
                                <div class=""btn-group"">
                                    <i class=""fa fa-ellipsis-h"" title = 'Actions' style = 'cursor:pointer;' data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""></i>
                                  <div cla");
                WriteLiteral(@"ss=""dropdown-menu"" >
                                    <button style=""font-size: inherit;"" class=""dropdown-item btn-rx editVatAndTaxInformation"" name = ""${full.name}"" amount = ""${full.amount}"" vatAndTaxId = ""${full.id}"" ><i class=""fa fa-check-circle"" aria-hidden=""true""></i>Edit</button >
                                    <button style=""font-size: inherit;"" class=""dropdown-item btn-rx deleteVatAndTaxInformation"" vatAndTaxId = ""${full.id}"" > <i class=""fa fa-times"" aria-hidden=""true""></i>Delete</button >
                                  </div>
                                </div>`;
                            }
                        },
                    ]
                });
                selector.tableInformation = vatAndTaxList;
            }

            function ShowEditInformation(name, amount){
                selector.name.val(name);
                selector.amount.val(amount);
            }

            selector.vatAndTaxCreateBtn.click(function () {
                if($(th");
                WriteLiteral(@"is).text() === ""Save""){
                    if (selector.vatAndTaxCreateForm.valid()) {
                        let formData = new FormData(selector.vatAndTaxCreateForm[0]);
                        let data = ajaxOperation.SaveAjax(""/VatAndTax/Index"", formData);

                        if (data === true) {
                            selector.tableInformation.fnFilter();
                            selector.vatAndTaxCreateForm[0].reset();
                            toastr.success('Successfully Saved!', 'success');
                        }
                        else {
                            toastr.error('Something went wrong!', 'error');
                        }
                    }
                    else {
                        toastr.error('Please fill up the form with valid information.', 'Validation Failed!');
                    }
                }
                else{
                    let formData = new FormData(selector.vatAndTaxCreateForm[0]);
                   ");
                WriteLiteral(@" formData.append(""Id"", selector.globalId);

                    let data = ajaxOperation.SaveAjax(""/VatAndTax/VatAndTaxUpdate"", formData);
                    if (data === true) {
                        selector.tableInformation.fnFilter();
                        selector.vatAndTaxCreateForm[0].reset();
                        toastr.success('Successfully Updated!', 'success');
                        $(this).text(""Save"");
                    }
                    else {
                        toastr.error('Something went wrong!', 'error');
                    }
                }
            });

            window.onload = function () {
                GenerateVatAndTaxList();
            }

            selector.vatAndTaxResetBtn.click(function () {
                selector.vatAndTaxCreateForm[0].reset();
            });

            $(document).on(""click"", "".editVatAndTaxInformation"", function () {
                selector.globalId = $(this).attr(""vatAndTaxId"");
                l");
                WriteLiteral(@"et name = $(this).attr(""name"");
                let amount = $(this).attr(""amount"");
                ShowEditInformation(name, amount);
                selector.vatAndTaxCreateBtn.text(""Update"");
            });

            $(document).on(""click"", "".deleteVatAndTaxInformation"", function () {
                let supplierId = $(this).attr(""vatAndTaxId"");
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
                    allowOutsideClick: false,

                }).then((result) => {
                    if (result.value) {
                        let hasDone = ajaxOperation.DeleteAjaxById(""/VatAndTax/DeleteVatAndTax"", supplierI");
                WriteLiteral(@"d);
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

        })();
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<POSSystemWithInventory.Models.VatAndTaxVM> Html { get; private set; }
    }
}
#pragma warning restore 1591