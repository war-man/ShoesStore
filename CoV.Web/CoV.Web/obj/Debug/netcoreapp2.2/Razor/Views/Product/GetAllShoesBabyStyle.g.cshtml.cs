#pragma checksum "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70b531a3837faeac399aed55a858eed26bd35a42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetAllShoesBabyStyle), @"mvc.1.0.view", @"/Views/Product/GetAllShoesBabyStyle.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/GetAllShoesBabyStyle.cshtml", typeof(AspNetCore.Views_Product_GetAllShoesBabyStyle))]
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
#line 1 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml"
using CoV.Service.DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70b531a3837faeac399aed55a858eed26bd35a42", @"/Views/Product/GetAllShoesBabyStyle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b215e98a6ad750c14dffef89b4c27c357a9e3b89", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetAllShoesBabyStyle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_FrontEndLayout";
    var product = (List<ProductViewModel>) ViewBag.product;

#line default
#line hidden
            BeginContext(156, 152, true);
            WriteLiteral("\n<section class=\"breadcrumb\">\n    <div class=\"container p-0\">\n        <div class=\"col-md-12\">\n            <ul>\n                <li>\n                    ");
            EndContext();
            BeginContext(308, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b531a3837faeac399aed55a858eed26bd35a426558", async() => {
                BeginContext(351, 55, true);
                WriteLiteral("\n                        Trang chủ\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(410, 465, true);
            WriteLiteral(@"
                </li>
                <li>
                    Giành cho trẻ em phong cách 
                </li>
            </ul>
        </div>
    </div>
</section>

<section class=""product-ss product-page"">
<div class=""container p-0"">
<div class=""row align-items-center"">
    <div class=""col-md-9"">
        <h2 class=""name-cate mb-0"">
            Giành cho trẻ em

        </h2>
    </div>
    <div class=""col-md-3"">
        <div class='sort-by'>
            ");
            EndContext();
            BeginContext(875, 771, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b531a3837faeac399aed55a858eed26bd35a428638", async() => {
                BeginContext(892, 112, true);
                WriteLiteral("\n                <div class=\'select\'>\n                    <select class=\'form-control\'>\n                        ");
                EndContext();
                BeginContext(1004, 94, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b531a3837faeac399aed55a858eed26bd35a429132", async() => {
                    BeginContext(1021, 68, true);
                    WriteLiteral("\n                            Giá thấp trước\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1098, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(1123, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b531a3837faeac399aed55a858eed26bd35a4210662", async() => {
                    BeginContext(1140, 67, true);
                    WriteLiteral("\n                            Giá Cao trước\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1216, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(1241, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b531a3837faeac399aed55a858eed26bd35a4212192", async() => {
                    BeginContext(1258, 60, true);
                    WriteLiteral("\n                            Từ A-Z\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1327, 25, true);
                WriteLiteral("\n                        ");
                EndContext();
                BeginContext(1352, 86, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b531a3837faeac399aed55a858eed26bd35a4213715", async() => {
                    BeginContext(1369, 60, true);
                    WriteLiteral("\n                            Từ Z-A\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1438, 201, true);
                WriteLiteral("\n                    </select>\n                    <span class=\'icon-select\'>\n                        <i class=\'fas fa-chevron-down\'></i>\n                    </span>\n                </div>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1646, 5840, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""row product_slide"">
<div class=""col-md-3"">
    <div class='side-bar-product'>
        <div class='item-bar'>
            <h3 class='title-side-ba'>
                Giành cho nam
            </h3>
            <ul class=""list-inline"">
                <li>
                    <a href='product-list.html'>
                        Thời trang
                        <span class='count-cate'>
                            (9)
                        </span>
                    </a>
                </li>
                <li>
                    <a href='product-list.html'>
                        Thời trang nam
                        <span class='count-cate'>
                            (9)
                        </span>
                    </a>
                </li>
                <li>
                    <a href='product-list.html'>
                        Thời trang nữ
                        <span class='count-cate'>
                            (9)
                   ");
            WriteLiteral(@"     </span>
                    </a>
                </li>
                <li>
                    <a href='product-list.html'>
                        Phụ kiện nam
                        <span class='count-cate'>
                            (9)
                        </span>
                    </a>
                </li>
                <li>
                    <a href='product-list.html'>
                        Phụ kiện nữ
                        <span class='count-cate'>
                            (9)
                        </span>
                    </a>
                </li>
            </ul>
        </div>

        <div class='item-bar mt-3'>
            <h3 class='title-side-ba'>
                Size
            </h3>
            <ul class=""list-tb"">
                <li>
                    <a href='#'>
                        34
                    </a>
                </li>
                <li>
                    <a href='#'>
                        35
                    </a>
              ");
            WriteLiteral(@"  </li>
                <li>
                    <a href='#'>
                        36
                    </a>
                </li>
                <li>
                    <a href='#'>
                        37
                    </a>
                </li>
                <li>
                    <a href='#'>
                        38
                    </a>
                </li>
                <li>
                    <a href='#'>
                        39
                    </a>
                </li>
                <li>
                    <a href='#'>
                        40
                    </a>
                </li>
                <li>
                    <a href='#'>
                        41
                    </a>
                </li>
                <li>
                    <a href='#'>
                        42
                    </a>
                </li>
                <li>
                    <a href='#'>
                        42
                    </a>
              ");
            WriteLiteral(@"  </li>
            </ul>
        </div>

        <div class='item-bar mt-3'>
            <h3 class='title-side-ba'>
                Màu sắc
            </h3>
            <ul class=""list-cl"">
                <li class="""" style=""background-color: #ff6600;"">
                    <a href='#'>
                        &nbsp;
                    </a>
                </li>

                <li class="""" style=""background-color: #000;"">
                    <a href='#'>
                        &nbsp;
                    </a>
                </li>

                <li class="""" style=""background-color: #cc0000;"">
                    <a href='#'>
                        &nbsp;
                    </a>
                </li>

                <li class="""" style=""background-color: #ff0000;"">
                    <a href='#'>
                        &nbsp;
                    </a>
                </li>
                <li class="""" style=""background-color: #ffff00;"">
                    <a href='#'>
                        &nbsp;");
            WriteLiteral(@"
                    </a>
                </li>

                <li class="""" style=""background-color: #fff;"">
                    <a href='#'>
                        &nbsp;
                    </a>
                </li>

                <li class="""" style=""background-color: red;"">
                    <a href='#'>
                        &nbsp;
                    </a>
                </li>

                <li class="""" style=""background-color: blue;"">
                    <a href='#'>
                        &nbsp;
                    </a>
                </li>
            </ul>
        </div>
        <div class='item-bar mt-3'>
            <h3 class='title-side-ba'>
                Khoảng giá
            </h3>
            <ul class=""list-inline"">
                <li>
                    <a href='#'>
                        100.000 đ - 500.000 đ
                    </a>
                </li>
                <li>
                    <a href='#'>
                        500.000 đ - 1.000.000 đ
                ");
            WriteLiteral(@"    </a>
                </li>
                <li>
                    <a href='#'>
                        1.000.000 đ - 3.000.000 đ
                    </a>
                </li>
                <li>
                    <a href='#'>
                        3.000.000 đ - 5.000.000 đ
                    </a>
                </li>
                <li>
                    <a href='#'>
                        5.000.000 đ - 7.000.000 đ
                    </a>
                </li>
                <li>
                    <a href='#'>
                        > 7.000.000 đ
                    </a>
                </li>
            </ul>
        </div>
    </div>
</div>

<div class=""col-md-9 p-0"">
<div class=""row"">
");
            EndContext();
#line 265 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml"
 foreach (var item in product)
{

#line default
#line hidden
            BeginContext(7519, 117, true);
            WriteLiteral("    <div class=\"col-md-4 p-0\">\n        <div class=\"item-product\">\n            <div class=\"img-item\">\n                ");
            EndContext();
            BeginContext(7636, 166, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b531a3837faeac399aed55a858eed26bd35a4222983", async() => {
                BeginContext(7713, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(7734, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "70b531a3837faeac399aed55a858eed26bd35a4223378", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 7744, "~/Images/", 7744, 9, true);
#line 271 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml"
AddHtmlAttributeValue("", 7753, item.AvatarDetails, 7753, 19, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7781, 17, true);
                WriteLiteral("\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 270 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml"
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
            BeginContext(7802, 680, true);
            WriteLiteral(@"
            </div>
            <div class=""box-size"">
                <div class=""count-size"">
                    +7 size
                </div>
                <div class=""list-size"">
                    <span>35</span>
                    <span>36</span>
                    <span>47</span>
                    <span>38</span>
                    <span>39</span>
                    <span>40</span>
                    <span>41</span>
                    <span>42</span>
                    <span>43</span>
                    <span>44</span>
                    <span>45</span>
                </div>
            </div>

            <h3 class=""name-product"">
                ");
            EndContext();
            BeginContext(8482, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b531a3837faeac399aed55a858eed26bd35a4227981", async() => {
                BeginContext(8559, 24, true);
                WriteLiteral("\n                    <b>");
                EndContext();
                BeginContext(8584, 9, false);
#line 295 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml"
                  Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(8593, 21, true);
                WriteLiteral("</b>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 294 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml"
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
            BeginContext(8618, 81, true);
            WriteLiteral("\n            </h3>\n            <div class=\"price-product\">\n                <span>");
            EndContext();
            BeginContext(8700, 10, false);
#line 299 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml"
                 Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(8710, 52, true);
            WriteLiteral(" đ</span>\n                <del>\n                    ");
            EndContext();
            BeginContext(8763, 13, false);
#line 301 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml"
               Write(item.PriceNew);

#line default
#line hidden
            EndContext();
            BeginContext(8776, 99, true);
            WriteLiteral(" đ\n                </del>\n            </div>\n            <div class=\"add-to-cart\">\n                ");
            EndContext();
            BeginContext(8875, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70b531a3837faeac399aed55a858eed26bd35a4231814", async() => {
                BeginContext(8953, 46, true);
                WriteLiteral("\n                    Mua hàng\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 305 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml"
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
            BeginContext(9003, 46, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 311 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Product/GetAllShoesBabyStyle.cshtml"
}

#line default
#line hidden
            BeginContext(9051, 856, true);
            WriteLiteral(@"


<div class=""col-md-12"">
    <div class='pagination pt-1'>
        <ul>
            <li>
                <a href='#'>
                    <i class='fas fa-arrow-left'></i>
                </a>
            </li>
            <li class='active'>
                <a href='#'>1</a>
            </li>
            <li>
                <a href='#'>2</a>
            </li>
            <li>
                <a href='#'>3</a>
            </li>
            <li>
                <a href='#'>...</a>
            </li>
            <li>
                <a href='#'>4</a>
            </li>
            <li>
                <a href='#'>5</a>
            </li>
            <li>
                <a href='#'>
                    <i class='fas fa-arrow-right'></i>
                </a>
            </li>
        </ul>
    </div>
</div>
</div>
</div>


</div>
</div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
