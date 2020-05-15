#pragma checksum "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da8abdc966791bf71982ca26a0d7241dc0838f58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout02_Checkout02), @"mvc.1.0.view", @"/Views/Checkout02/Checkout02.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Checkout02/Checkout02.cshtml", typeof(AspNetCore.Views_Checkout02_Checkout02))]
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
#line 1 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
using CoV.Service.DataModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da8abdc966791bf71982ca26a0d7241dc0838f58", @"/Views/Checkout02/Checkout02.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b215e98a6ad750c14dffef89b4c27c357a9e3b89", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout02_Checkout02 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sl-payment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_FrontEndLayout";
	var cart = (IEnumerable<CartViewModel>) ViewBag.cart;
	var customer = (CustomerViewModel) ViewBag.customer;
	var totalPrice = (int) ViewBag.totalprice;

#line default
#line hidden
            BeginContext(248, 500, true);
            WriteLiteral(@"		<section class=""breadcrumb"">
			<div class=""container p-0"">
				<div class=""col-md-12"">
					<ul>
						<li>
							<a href=""#"">
								Trang chủ
							</a>
						</li>
						<li>
							Thanh toán
						</li>
					</ul>
				</div>
			</div>
		</section>

		<section class='box-checkout-02'>
			<div class='container p-0'>
				<div class='row m-0 bd-top'>
					<div class=""col-md-12 mt-3"">
						<h2 class=""title-page"">
							Thanh toán
						</h2>
					</div>
					<div class='col-md-6'>
						");
            EndContext();
            BeginContext(748, 3799, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da8abdc966791bf71982ca26a0d7241dc0838f586652", async() => {
                BeginContext(865, 3675, true);
                WriteLiteral(@"
							<div class='list-ship'>
								<h2 class='title-sl-payment'>1. Chọn hình thức vận chuyển</h2>
								
								<div class='item-payment m-border'>
									<label class='radio-guide radio-guide-payment'>
										Giao hàng tiêu chuẩn
										<input name='htship' type='radio' value=""1"">
										<span class='checkmark show-info-payment'></span>
									</label>
									<div class='info-payment'>
										Giao hàng tiêu chuẩn là hình thức giao hàng thông thường mà các đơn vị vận chuyển cung cấp, bưu phẩm sẽ được chuyển đi theo thời gian định sẵn. Điều thu hút ở dịch vụ này đó là giá thành phải chăng và cực kỳ hợp lí. Với mức cước phí thấp như vậy, tốc độ giao hàng sẽ không thể bảo đảm nhanh chóng mà phải tuân theo trình tự lần lượt. Vì thế, dịch vụ này sẽ phù hợp cho những người không gấp gáp về mặt thời gian nhận hàng và ưu tiên chi phí rẻ.
									</div>
								</div>
								<div class='item-payment m-border'>
									<label class='radio-guide radio-guide-payment'>
										Giao hàng COD
");
                WriteLiteral(@"										<input name='htship' type='radio'>
										<span class='checkmark show-info-payment'></span>
									</label>
									<div class='info-payment'>
										Khách hàng sẽ được xem hàng, nếu ưng ý mới phải trả tiền cho món đồ mình chọn mua. Còn không người mua sẽ có quyền từ chối nhận hàng và chuyển hàng trả lại người bán. (Việc được thử hàng hay bóc gói hàng sẽ phụ thuộc và người bán hàng quyết định, có rất nhiều khách hàng đồng ý cho xem bên ngoài bao bì của hàng nhưng không được bóc tem mác của sản phẩm…)
									</div>
								</div>
							</div>
							<div class='list-htpayment'>
								<h2 class='title-sl-payment'>2. Chọn hình thức thanh toán</h2>
								<div class='item-payment m-border m-border-blue'>
									<label class='radio-guide radio-guide-payment'>
										Thanh toán tiền mặt khi nhận hàng
										<input checked='checked' name='htpayment' type='radio'>
										<span class='checkmark show-info-payment'></span>
									</label>
									<div class='info-payment onblock'>
");
                WriteLiteral(@"										Tiết kiệm chi phí vận chuyển giao hàng thu tiền toàn quốc với Shipchung.vn. Tra cứu & so sánh phí vận chuyển của nhiều hãng ngay lập tức, chính xác.Thường xuyên có các chương trình khuyến mãi, ưu đãi tích điểm nhận quà.
									</div>
								</div>
								<div class='item-payment m-border'>
									<label class='radio-guide radio-guide-payment'>
										Thanh toán bằng thể quốc tế Visa, Master Card
										<input name='htpayment' type='radio'>
										<span class='checkmark show-info-payment'></span>
									</label>
									<div class='info-payment'>
										Tiết kiệm chi phí vận chuyển giao hàng thu tiền toàn quốc với Shipchung.vn. Tra cứu & so sánh phí vận chuyển của nhiều hãng ngay lập tức, chính xác.Thường xuyên có các chương trình khuyến mãi, ưu đãi tích điểm nhận quà.
									</div>
								</div>
								<div class='item-payment m-border'>
									<label class='radio-guide radio-guide-payment'>
										Thanh toán ATM nội đia, Internet Banking (Miễn phí thanh toán)
									");
                WriteLiteral(@"	<input name='htpayment' type='radio'>
										<span class='checkmark show-info-payment'></span>
									</label>
									<div class='info-payment'>
										Tiết kiệm chi phí vận chuyển giao hàng thu tiền toàn quốc với Shipchung.vn. Tra cứu & so sánh phí vận chuyển của nhiều hãng ngay lập tức, chính xác.Thường xuyên có các chương trình khuyến mãi, ưu đãi tích điểm nhận quà.
									</div>
								</div>
							</div>
						
								<a class='to-checkout'  >
									<button class='btn-blue w-100 mt-2' type='submit'>
										Hoàn tất đơn hàng
									</button>
								</a>
							
						");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4547, 127, true);
            WriteLiteral("\n\t\t\t\t\t</div>\n\t\t\t\t\t<div class=\'moffset-1 col-md-5\'>\n\t\t\t\t\t\t<div class=\'list-ordered\'>\n\t\t\t\t\t\t\t<h2 class=\'title-ordered\'>Đơn hàng: ");
            EndContext();
            BeginContext(4675, 12, false);
#line 104 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
                                                           Write(cart.Count());

#line default
#line hidden
            EndContext();
            BeginContext(4687, 15, true);
            WriteLiteral(" sản phẩm</h2>\n");
            EndContext();
#line 105 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
                             foreach (var item in cart)
							{

#line default
#line hidden
            BeginContext(4746, 84, true);
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\'row item-ordered\'>\n\t\t\t\t\t\t\t\t\t<div class=\'img-ordered\'>\n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(4830, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "da8abdc966791bf71982ca26a0d7241dc0838f5813562", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            AddHtmlAttributeValue("", 4847, "~/Images/", 4847, 9, true);
#line 109 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
AddHtmlAttributeValue("", 4856, item.Product.AvatarDetails, 4856, 27, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4885, 88, true);
            WriteLiteral("\n\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t<div class=\'info-ordered\'>\n\t\t\t\t\t\t\t\t\t\t<h3 class=\'namr-ordered\'>");
            EndContext();
            BeginContext(4974, 17, false);
#line 112 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
                                                            Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4991, 35, true);
            WriteLiteral("</h3>\n\t\t\t\t\t\t\t\t\t\t<div class=\'price\'>");
            EndContext();
            BeginContext(5027, 18, false);
#line 113 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
                                                      Write(item.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(5045, 35, true);
            WriteLiteral(" đ</div>\n\t\t\t\t\t\t\t\t\t\t<div ><b> Size: ");
            EndContext();
            BeginContext(5081, 9, false);
#line 114 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
                                                   Write(item.Size);

#line default
#line hidden
            EndContext();
            BeginContext(5090, 11, true);
            WriteLiteral("</b></div>\n");
            EndContext();
            BeginContext(5212, 48, true);
            WriteLiteral("\t\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t\t\t<div class=\'qty\' ><b>X ");
            EndContext();
            BeginContext(5261, 13, false);
#line 119 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
                                                      Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(5274, 26, true);
            WriteLiteral("</b></div>\n\t\t\t\t\t\t\t\t</div>\n");
            EndContext();
#line 121 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
							}

#line default
#line hidden
            BeginContext(5309, 342, true);
            WriteLiteral(@"							
							
							<div class='row m-0 mt-3'>
								<div class='col-md-6'>Phí shipping:</div>
								<div class='col-md-6 text-right'>30.000 đ</div>
							</div>
							<div class='row mt-1 bd-top pt-1'>
								<div class='col-md-6 fs-18'>Thành tiền:</div>
								<div class='col-md-6 text-right'>
									<b class=""formatPrice01"">");
            EndContext();
            BeginContext(5652, 10, false);
#line 131 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
                                                        Write(totalPrice);

#line default
#line hidden
            EndContext();
            BeginContext(5662, 192, true);
            WriteLiteral("</b>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t<div class=\'row m-0 mt-3\'>\n\t\t\t\t\t\t\t\t<div class=\'col-md-6\'>Tổng hóa đơn:</div>\n\t\t\t\t\t\t\t\t<div class=\'col-md-6 text-right\'>\n\t\t\t\t\t\t\t\t\t<b class=\"formatPrice\">");
            EndContext();
            BeginContext(5856, 16, false);
#line 137 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
                                                       Write(totalPrice+30000);

#line default
#line hidden
            EndContext();
            BeginContext(5873, 197, true);
            WriteLiteral("</b>\n\t\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t\t<div class=\'list-ordered mt-2\'>\n\t\t\t\t\t\t\t<h3 class=\'title-address\'>Giao hàng đến</h3>\n\t\t\t\t\t\t\t<div class=\'txt-address\'>\n\t\t\t\t\t\t\t\t<b class=\"address\">");
            EndContext();
            BeginContext(6071, 16, false);
#line 144 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
                                              Write(customer.Address);

#line default
#line hidden
            EndContext();
            BeginContext(6087, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(6091, 13, false);
#line 144 "/home/cap/Desktop/ShoesStore/CoV.Web/CoV.Web/Views/Checkout02/Checkout02.cshtml"
                                                                  Write(customer.City);

#line default
#line hidden
            EndContext();
            BeginContext(6104, 80, true);
            WriteLiteral(" </b>\n\t\t\t\t\t\t\t</div>\n\t\t\t\t\t\t</div>\n\t\t\t\t\t</div>\n\t\t\t\t</div>\n\t\t\t</div>\n\t\t</section>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6202, 628, true);
                WriteLiteral(@"
	<script>
	    //format jquery format number to currency
	    var input= $("".formatPrice"").html();
	    var output=parseInt(input).toLocaleString();
	    $("".formatPrice"").text(output +"" VND"");
		
	    var input01= $("".formatPrice01"").html();
	    var output01=parseInt(input01).toLocaleString();
	    $("".formatPrice01"").text(output01 +"" VND"");
		
	    function ucwords (str) {
	        return (str + '').replace(/^([a-z])|\s+([a-z])/g, function ($1) {
	            return $1.toUpperCase();
	        });
	    }
	    var oldstring = $("".address"").html();
	    $("".address"").text(ucwords(oldstring.toLowerCase())) ;

	</script>
");
                EndContext();
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
