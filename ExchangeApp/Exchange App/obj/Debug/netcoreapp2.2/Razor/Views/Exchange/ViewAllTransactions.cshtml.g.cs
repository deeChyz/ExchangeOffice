#pragma checksum "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87150227d77b4974b6e57e3b256929a5f152824b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exchange_ViewAllTransactions), @"mvc.1.0.view", @"/Views/Exchange/ViewAllTransactions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exchange/ViewAllTransactions.cshtml", typeof(AspNetCore.Views_Exchange_ViewAllTransactions))]
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
#line 1 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\_ViewImports.cshtml"
using Exchange_App;

#line default
#line hidden
#line 2 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\_ViewImports.cshtml"
using Exchange_App.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87150227d77b4974b6e57e3b256929a5f152824b", @"/Views/Exchange/ViewAllTransactions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af4b3b9773ca0b74473438b8488c796df902b65", @"/Views/_ViewImports.cshtml")]
    public class Views_Exchange_ViewAllTransactions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Exchange_App.DAL.Entities.Exchange>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewTransaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
  
    ViewData["Title"] = "ViewAllTransactions";

#line default
#line hidden
            BeginContext(101, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 6 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
 foreach (var exchange in Model)
{

#line default
#line hidden
            BeginContext(137, 100, true);
            WriteLiteral("    <div class=\"currency_container\">\n        <div class=\"control-label\" align=\"center\">\n            ");
            EndContext();
            BeginContext(237, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "87150227d77b4974b6e57e3b256929a5f152824b4269", async() => {
                BeginContext(297, 26, true);
                WriteLiteral("<h1><b>Транзакция</b></h1>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 10 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
                                              WriteLiteral(exchange.Id);

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
            BeginContext(327, 130, true);
            WriteLiteral("\n        </div>\n\n        <div class=\"currency_info\">\n            <p>\n                <span>Cashier: </span>\n                <span>");
            EndContext();
            BeginContext(458, 16, false);
#line 16 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
                 Write(exchange.Cashier);

#line default
#line hidden
            EndContext();
            BeginContext(474, 101, true);
            WriteLiteral("</span>\n            </p>\n            <p>\n                <span>Client: </span>\n                <span>");
            EndContext();
            BeginContext(576, 20, false);
#line 20 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
                 Write(exchange.Client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(596, 30, true);
            WriteLiteral("</span>\n                <span>");
            EndContext();
            BeginContext(627, 23, false);
#line 21 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
                 Write(exchange.Client.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(650, 110, true);
            WriteLiteral("</span>\n            </p>\n            <p>\n                <span>Client Currency: </span>\n                <span>");
            EndContext();
            BeginContext(761, 36, false);
#line 25 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
                 Write(exchange.ClientCurrency.CurrencyName);

#line default
#line hidden
            EndContext();
            BeginContext(797, 30, true);
            WriteLiteral("</span>\n                <span>");
            EndContext();
            BeginContext(828, 36, false);
#line 26 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
                 Write(exchange.ClientCurrency.SellingPrice);

#line default
#line hidden
            EndContext();
            BeginContext(864, 30, true);
            WriteLiteral("</span>\n                <span>");
            EndContext();
            BeginContext(895, 29, false);
#line 27 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
                 Write(exchange.AmountClientCurrency);

#line default
#line hidden
            EndContext();
            BeginContext(924, 110, true);
            WriteLiteral("</span>\n            </p>\n            <p>\n                <span>Target Currency: </span>\n                <span>");
            EndContext();
            BeginContext(1035, 36, false);
#line 31 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
                 Write(exchange.TargetCurrency.CurrencyName);

#line default
#line hidden
            EndContext();
            BeginContext(1071, 30, true);
            WriteLiteral("</span>\n                <span>");
            EndContext();
            BeginContext(1102, 36, false);
#line 32 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
                 Write(exchange.TargetCurrency.SellingPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1138, 30, true);
            WriteLiteral("</span>\n                <span>");
            EndContext();
            BeginContext(1169, 29, false);
#line 33 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
                 Write(exchange.AmountTargetCurrency);

#line default
#line hidden
            EndContext();
            BeginContext(1198, 51, true);
            WriteLiteral("</span>\n            </p>\n        </div>\n    </div>\n");
            EndContext();
#line 37 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewAllTransactions.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Exchange_App.DAL.Entities.Exchange>> Html { get; private set; }
    }
}
#pragma warning restore 1591
