#pragma checksum "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0de3f40dd21ed5cb6cff3399d608473fd8886315"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Wardrobe.Pages.Pages_Bag), @"mvc.1.0.razor-page", @"/Pages/Bag.cshtml")]
namespace Wardrobe.Pages
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
#line 1 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\_ViewImports.cshtml"
using Wardrobe;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{orderLevel:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0de3f40dd21ed5cb6cff3399d608473fd8886315", @"/Pages/Bag.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e85584d1540fa03bfb1a101eb1f54717b1c860a6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Bag : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "bag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("productList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Bag", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-orderLevel", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark text-uppercase rounded-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/All", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light border-0 rounded-0 text-uppercase"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
  
    ViewData["Title"] = "My Bag";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
 if (Model.OrderLevel == 2 && BagModel.IsEmpty == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <h1 class=\"text-uppercase text-center pt-5 mb-5\">Details and Submit</h1>\r\n        <div class=\"row m-0\">\r\n            <div class=\"col-lg-7 py-3\">\r\n                <div class=\"container\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0de3f40dd21ed5cb6cff3399d608473fd88863157820", async() => {
                WriteLiteral(@"
                        <div class=""mb-3"">
                            <label for=""email"" class=""form-label"">Email address*</label>
                            <input type=""email"" class=""form-control rounded-0"" id=""email"" name=""email"" aria-describedby=""emailHelp"" required>
                            <div id=""emailHelp"" class=""form-text"">We'll never share your email with anyone else.</div>
                        </div>
                        <div class=""row mb-3"">
                            <div class=""col-12 col-sm-6"">
                                <label for=""firstName"" class=""form-label"">First Name*</label>
                                <input type=""text"" pattern=""[A-Za-z]{1,50}"" class=""form-control rounded-0"" id=""firstName"" name=""firstName"" required>
                            </div>
                            <div class=""col-12 col-sm-6"">
                                <label for=""lastName"" class=""form-label"">Last Name*</label>
                                <input type=""text"" pa");
                WriteLiteral(@"ttern=""[A-Za-z]{1,50}"" class=""form-control rounded-0"" id=""lastName"" name=""lastName"" required>
                            </div>
                        </div>
                        <div class=""mb-3"">
                            <label for=""telephoneNumber"" class=""form-label"">Telephone Number*</label>
                            <input type=""tel"" pattern=""\d{9,15}"" class=""form-control rounded-0"" id=""telephoneNumber"" name=""telephoneNumber"" required>
                        </div>
                        <div class=""mb-3"">
                            <label for=""streetName"" class=""form-label"">Street Name*</label>
                            <input type=""text"" pattern=""[A-Za-z]{1,50}"" class=""form-control rounded-0"" id=""streetName"" name=""streetName"" required>
                        </div>
                        <div class=""row mb-3"">
                            <div class=""col-12 col-sm-6"">
                                <label for=""houseNumber"" class=""form-label"">House Number*</label>
        ");
                WriteLiteral(@"                        <input type=""text"" pattern=""\d{0,10}([A-z]|[a-z]){0,5}"" class=""form-control rounded-0"" id=""houseNumber"" name=""houseNumber"" required>
                            </div>
                            <div class=""col-12 col-sm-6"">
                                <label for=""apartmentNumber"" class=""form-label"">Apartment Number</label>
                                <input type=""text"" pattern=""\d{0,10}"" class=""form-control rounded-0"" id=""apartmentNumber"" name=""apartmentNumber"">
                            </div>
                        </div>
                        <div class=""row mb-3"">
                            <div class=""col-12 col-sm-6"">
                                <label for=""postal"" class=""form-label"">Postal*</label>
                                <input type=""text"" pattern=""\d{2}-\d{3}"" placeholder=""xx-xxx"" class=""form-control rounded-0"" id=""postal"" name=""postal"" required>
                            </div>
                            <div class=""col-12 col-sm-6"">");
                WriteLiteral(@"
                                <label for=""city"" class=""form-label"">City*</label>
                                <input type=""text"" pattern=""[A-Za-z]{1,50}"" class=""form-control rounded-0"" id=""city"" name=""city"" required>
                            </div>
                        </div>
                        <div class=""mb-3"">
                            <label for=""details"" class=""form-label"">Details</label>
                            <textarea class=""form-control rounded-0"" id=""details"" name=""details""></textarea>
                        </div>
                        <div class=""m-0 p-0 text-center text-sm-start"">
                            <button type=""submit"" class=""btn btn-dark rounded-0 text-uppercase"">Order Products</button>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"col-lg-5 text-center order-lg-1 order-0 px-3 mt-5 mt-lg-0\">\r\n                <h1 style=\"font-family: LaBelle\">Summary</h1>\r\n                <div class=\"container\">\r\n");
#nullable restore
#line 72 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                     foreach (var item in Model.bag)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row px-5 px-sm-3 py-2\">\r\n                            <div class=\"col-12 col-sm-8 pt-2 py-sm-0 my-auto px-3 text-start order-1 order-sm-0\">\r\n                                <h4>");
#nullable restore
#line 76 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                               Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                <h6>");
#nullable restore
#line 77 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                               Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 77 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                                                Write(item.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" GPB</h6>\r\n                                <p>Size: ");
#nullable restore
#line 78 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                                    Write(item.Product.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <div class=\"col-12 col-sm-4 my-auto p-0 order-0 order-sm-1\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 5203, "\"", 5228, 1);
#nullable restore
#line 81 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
WriteAttributeValue("", 5209, item.Product.Photo, 5209, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\" />\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 84 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""row m-5 pt-3 mb-0 border-top"">
                    <div class=""col text-start"">
                        <h6 class=""text-uppercase"">Products' Price</h6>
                    </div>
                    <div class=""col text-end"">
                        <p>");
#nullable restore
#line 91 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                      Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 97 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
}
else if (BagModel.IsEmpty == true)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\r\n        <h1 class=\"text-uppercase text-center pt-5 mb-5\">Products\' List</h1>\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-8 py-lg-3 px-lg-5 order-lg-0 order-1\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0de3f40dd21ed5cb6cff3399d608473fd888631517393", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" value=\"Update\" />\r\n");
#nullable restore
#line 106 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                     foreach (var item in Model.bag)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"row m-5\">\r\n                            <div class=\"col-md-4 mr-0 p-0\">\r\n                                <img");
                BeginWriteAttribute("src", " src=\"", 6398, "\"", 6423, 1);
#nullable restore
#line 110 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
WriteAttributeValue("", 6404, item.Product.Photo, 6404, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" class=""img-fluid"" />
                            </div>
                            <div class=""col-md-8 px-3 my-2 my-md-auto"">
                                <div class=""row"">
                                    <div class=""col-12 col-sm-10 text-md-start order-1 order-sm-0"">
                                        <h4>");
#nullable restore
#line 115 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                                       Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                                        <h6>");
#nullable restore
#line 116 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                                       Write(item.Product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" GPB</h6>\r\n                                        <p>Size: ");
#nullable restore
#line 117 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                                            Write(item.Product.Size);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"delete col-sm-2 order-0 order-sm-1 text-end\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0de3f40dd21ed5cb6cff3399d608473fd888631519915", async() => {
                    WriteLiteral(@"
                                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-x-lg"" viewBox=""0 0 16 16"">
                                                <path d=""M1.293 1.293a1 1 0 0 1 1.414 0L8 6.586l5.293-5.293a1 1 0 1 1 1.414 1.414L9.414 8l5.293 5.293a1 1 0 0 1-1.414 1.414L8 9.414l-5.293 5.293a1 1 0 0 1-1.414-1.414L6.586 8 1.293 2.707a1 1 0 0 1 0-1.414z"" />
                                            </svg>
                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 120 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                                                                                      WriteLiteral(item.Product.Id);

#line default
#line hidden
#nullable disable
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
                WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-12 col-sm-10 my-2 my-sm-0"">
                                        <input type=""number"" name=""quantities""");
                BeginWriteAttribute("value", " value=\"", 8000, "\"", 8022, 1);
#nullable restore
#line 129 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
WriteAttributeValue("", 8008, item.Quantity, 8008, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" min=""1"" style=""width: 50px;"" class=""rounded-0 border-0"" />
                                        <input type=""submit"" value=""Update"" class="" py-1 btn text-uppercase text-white rounded-0"" style=""background-color: rgba(237,176,176,1)"" />
                                    </div>
                                    <div class=""col-12 col-sm-2 text-sm-end"">
                                        <h6>");
#nullable restore
#line 133 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                                       Write(Math.Round(item.Product.Price * @item.Quantity, 2));

#line default
#line hidden
#nullable disable
                WriteLiteral(" GPB</h6>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 138 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
            <div class=""col-lg-4 text-center order-lg-1 order-0 px-3"">
                <h1 style=""font-family: LaBelle"">Summary</h1>
                <div class=""row px-5"">
                    <div class=""col text-start"">
                        <h6 class=""text-uppercase"">Products' Price</h6>
                    </div>
                    <div class=""col text-end"">
                        <p>");
#nullable restore
#line 149 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
                      Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"col-12\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0de3f40dd21ed5cb6cff3399d608473fd888631527160", async() => {
                WriteLiteral("Buy Products");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-orderLevel", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["orderLevel"] = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 160 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container pt-5"">
        <div class=""row"">
            <div class=""col-md-12 col-lg d-lg-flex text-center justify-content-lg-end"">
                <img src=""https://365psd.com/images/istock/previews/9090/90902769-set-of-fashion-models-sketch-vector-illustration.jpg"" class=""img-fluid"" style=""opacity: 0.5"" />
            </div>
            <div class=""col-md-12 col-lg d-lg-flex justify-content-center"">
                <div class=""align-self-center text-center text-lg-start px-3"">
                    <h3>Your bag is empty</h3>
                    <h2 class=""mb-0 pb-0"" style=""font-family: LaBelle"">It's the perfect time to discover more</h2>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0de3f40dd21ed5cb6cff3399d608473fd888631529953", async() => {
                WriteLiteral("Let\'s begin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 177 "C:\Users\pauli\source\repos\ProgramowanieII\Wardrobe\Pages\Bag.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wardrobe.Pages.BagModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Wardrobe.Pages.BagModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Wardrobe.Pages.BagModel>)PageContext?.ViewData;
        public Wardrobe.Pages.BagModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
