#pragma checksum "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b428205cb012c75fca579c6528f4f73140b138bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookListRazor.Pages.BookList.Pages_BookList_Index), @"mvc.1.0.razor-page", @"/Pages/BookList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/BookList/Index.cshtml", typeof(BookListRazor.Pages.BookList.Pages_BookList_Index), null)]
namespace BookListRazor.Pages.BookList
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\_ViewImports.cshtml"
using BookListRazor;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b428205cb012c75fca579c6528f4f73140b138bf", @"/Pages/BookList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61eeec048b07d9cebb7c677f29d03bb0b044966d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_BookList_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 166, true);
            WriteLiteral("\r\n<br />\r\n<div class=\"container row\">\r\n    <div class=\"col-6\">\r\n        <h1 class=\"text-info\">Book List</h1>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            EndContext();
            BeginContext(262, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b428205cb012c75fca579c6528f4f73140b138bf6623", async() => {
                BeginContext(307, 15, true);
                WriteLiteral("Create New Book");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(326, 26, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
#line 18 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
 if(Model.Message != null)
{

#line default
#line hidden
            BeginContext(383, 233, true);
            WriteLiteral("    <div class=\"alert alert-info alert-dismissible\" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n        ");
            EndContext();
            BeginContext(617, 13, false);
#line 24 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(630, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 26 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
}

#line default
#line hidden
            BeginContext(647, 20, true);
            WriteLiteral("                \r\n\r\n");
            EndContext();
            BeginContext(667, 1546, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b428205cb012c75fca579c6528f4f73140b138bf9290", async() => {
                BeginContext(687, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 30 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
     if (Model.Books.Count() > 0)
    {

#line default
#line hidden
                BeginContext(731, 152, true);
                WriteLiteral("        <br />\r\n        <table class=\"table table-striped border\">\r\n            <tr class=\"table-secondary\">\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(884, 55, false);
#line 36 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Books.FirstOrDefault().Name));

#line default
#line hidden
                EndContext();
                BeginContext(939, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1007, 57, false);
#line 39 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Books.FirstOrDefault().Author));

#line default
#line hidden
                EndContext();
                BeginContext(1064, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1132, 55, false);
#line 42 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
               Write(Html.DisplayNameFor(m => m.Books.FirstOrDefault().ISBN));

#line default
#line hidden
                EndContext();
                BeginContext(1187, 71, true);
                WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n");
                EndContext();
#line 46 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
             foreach (var item in Model.Books)
            {

#line default
#line hidden
                BeginContext(1321, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1394, 31, false);
#line 50 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1425, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1505, 33, false);
#line 53 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
                   Write(Html.DisplayFor(m => item.Author));

#line default
#line hidden
                EndContext();
                BeginContext(1538, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1618, 31, false);
#line 56 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
                   Write(Html.DisplayFor(m => item.ISBN));

#line default
#line hidden
                EndContext();
                BeginContext(1649, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1728, 215, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b428205cb012c75fca579c6528f4f73140b138bf13482", async() => {
                    BeginContext(1928, 6, true);
                    WriteLiteral("Delete");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 59 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
                                                            WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1943, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1969, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b428205cb012c75fca579c6528f4f73140b138bf16218", async() => {
                    BeginContext(2043, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 62 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
                             WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2051, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 65 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2118, 18, true);
                WriteLiteral("        </table>\r\n");
                EndContext();
#line 67 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"

    }
    else
    {

#line default
#line hidden
                BeginContext(2162, 35, true);
                WriteLiteral("        <p>NO BOOKS AVAILABLE</p>\r\n");
                EndContext();
#line 72 "C:\Users\jmendoza\Desktop\DemoCode\BookListRazor\BookListRazor\BookListRazor\Pages\BookList\Index.cshtml"
    }

#line default
#line hidden
                BeginContext(2204, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2213, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookListRazor.Pages.BookList.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookListRazor.Pages.BookList.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookListRazor.Pages.BookList.IndexModel>)PageContext?.ViewData;
        public BookListRazor.Pages.BookList.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
