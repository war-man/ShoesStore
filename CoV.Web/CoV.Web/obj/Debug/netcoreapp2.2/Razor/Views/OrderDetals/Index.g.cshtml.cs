#pragma checksum "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e69f4947da4585e6951c5f0c2ee196a1c10b858"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetals_Index), @"mvc.1.0.view", @"/Views/OrderDetals/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderDetals/Index.cshtml", typeof(AspNetCore.Views_OrderDetals_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/_ViewImports.cshtml"
using CoV.Web;

#line default
#line hidden
#line 2 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/_ViewImports.cshtml"
using CoV.Web.Models;

#line default
#line hidden
#line 3 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 4 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e69f4947da4585e6951c5f0c2ee196a1c10b858", @"/Views/OrderDetals/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b215e98a6ad750c14dffef89b4c27c357a9e3b89", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoV.Service.DataModel.OrderDetailsViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAll", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(128, 93, true);
            WriteLiteral("\n <div class=\"row\">\n        <div class=\"col-12\">\n            <h1 style=\"text-align: center\" >");
            EndContext();
            BeginContext(221, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e69f4947da4585e6951c5f0c2ee196a1c10b8585359", async() => {
                BeginContext(270, 19, true);
                WriteLiteral("Danh sách đơn hàng ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(293, 809, true);
            WriteLiteral(@"</h1>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-sm-12 table-responsive"">
            <table  id=""ShowClass"" class=""table table-bordered table-hover"">
                <thead class=""thead-light"">       
                <tr style=""background-color: darkgrey"">
                    <td >Tên khách hàng </td>
                    <td >Số điện thoại </td>
                    <td >Tên sản phẩm </td>
                    <td >Số lượng</td>
                    <td > Tổng tiền </td>
                    <td >Địa chỉ</td>
                    <td >Ngày đặt</td>
                    <td >Trạng thái</td>
                    <td style=""text-align: center"">Cập nhật</td>
                    <td style=""text-align: center"">Xóa</td>
                </tr>
                
                <tbody>
");
            EndContext();
#line 31 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                 foreach(var item in Model)
                { 

#line default
#line hidden
            BeginContext(1165, 83, true);
            WriteLiteral("                    <tr style=\"text-align: center\" > \n                        <td >");
            EndContext();
            BeginContext(1249, 17, false);
#line 34 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                        Write(item.NameCustomer);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 36, true);
            WriteLiteral("</td> \n                        <td >");
            EndContext();
            BeginContext(1303, 16, false);
#line 35 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                        Write(item.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 36, true);
            WriteLiteral("</td> \n                        <td >");
            EndContext();
            BeginContext(1356, 16, false);
#line 36 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                        Write(item.NameProduct);

#line default
#line hidden
            EndContext();
            BeginContext(1372, 36, true);
            WriteLiteral("</td> \n                        <td >");
            EndContext();
            BeginContext(1409, 18, false);
#line 37 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                        Write(item.NumberProduct);

#line default
#line hidden
            EndContext();
            BeginContext(1427, 39, true);
            WriteLiteral(" SP</td> \n                        <td >");
            EndContext();
            BeginContext(1467, 15, false);
#line 38 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                        Write(item.TotalMoney);

#line default
#line hidden
            EndContext();
            BeginContext(1482, 36, true);
            WriteLiteral("</td> \n                        <td >");
            EndContext();
            BeginContext(1519, 12, false);
#line 39 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                        Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1531, 36, true);
            WriteLiteral("</td> \n                        <td >");
            EndContext();
            BeginContext(1568, 15, false);
#line 40 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                        Write(item.CreateDate);

#line default
#line hidden
            EndContext();
            BeginContext(1583, 63, true);
            WriteLiteral("</td> \n                        <td style=\"color: blue\" ><button");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1646, "\"", 1659, 1);
#line 41 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
WriteAttributeValue("", 1651, item.Id, 1651, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1660, 33, true);
            WriteLiteral(" class=\" btn btn-primary status\">");
            EndContext();
            BeginContext(1694, 23, false);
#line 41 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                                                                                                  Write(item.StatusOrder.Status);

#line default
#line hidden
            EndContext();
            BeginContext(1717, 103, true);
            WriteLiteral(" </button> </td> \n                        <td style=\"text-align: center\"> \n                            ");
            EndContext();
            BeginContext(1820, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e69f4947da4585e6951c5f0c2ee196a1c10b85811643", async() => {
                BeginContext(1875, 9, true);
                WriteLiteral("Chi tiết ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                                                           WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1888, 118, true);
            WriteLiteral(" \n                        </td> \n                        <td style=\"text-align: center\"> \n                            ");
            EndContext();
            BeginContext(2006, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e69f4947da4585e6951c5f0c2ee196a1c10b85813960", async() => {
                BeginContext(2105, 51, true);
                WriteLiteral("<i style=\"color: red\" class=\"fas fa-trash-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2160, 60, true);
            WriteLiteral(" \n                        </td> \n                    </tr> \n");
            EndContext();
#line 49 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                } 

#line default
#line hidden
            BeginContext(2239, 99, true);
            WriteLiteral("                </tbody>\n                </thead>\n            </table>\n        </div>\n    </div>\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2355, 308, true);
                WriteLiteral(@"
    <script>    
        $(document).ready(function() {
          
            $("".status"").on('click',
                function(e) {
                    e.preventDefault();
                    //id order
                    var id = e.target.id;

                    $.ajax({
                        url: '");
                EndContext();
                BeginContext(2664, 41, false);
#line 68 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/OrderDetals/Index.cshtml"
                         Write(Url.Action("UpdateStatus", "OrderDetals"));

#line default
#line hidden
                EndContext();
                BeginContext(2705, 594, true);
                WriteLiteral(@"',
                        type: ""GET"",
                        contentType: ""application/json; charset=utf-8"",
                        dataType: ""json"",
                        data: { 'id': id},
                        async: true,
                        cache: false,
                        success: function() {
                            $('#' + id).text(""Đang chờ Shipper"");
                            $('#' + id).css(""background-color"",""red"");
                        }
                    });
                });
            $('#ShowClass').DataTable();

        });
    </script>

");
                EndContext();
            }
            );
            BeginContext(3301, 1, true);
            WriteLiteral("\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoV.Service.DataModel.OrderDetailsViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
