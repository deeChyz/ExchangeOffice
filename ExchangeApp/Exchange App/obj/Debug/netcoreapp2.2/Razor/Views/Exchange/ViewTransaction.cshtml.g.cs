#pragma checksum "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewTransaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69b47b88c438802a496682e80c7ea9b7fd04357d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exchange_ViewTransaction), @"mvc.1.0.view", @"/Views/Exchange/ViewTransaction.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exchange/ViewTransaction.cshtml", typeof(AspNetCore.Views_Exchange_ViewTransaction))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69b47b88c438802a496682e80c7ea9b7fd04357d", @"/Views/Exchange/ViewTransaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3af4b3b9773ca0b74473438b8488c796df902b65", @"/Views/_ViewImports.cshtml")]
    public class Views_Exchange_ViewTransaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exchange_App.DAL.Entities.Exchange>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewTransaction.cshtml"
  
    ViewData["Title"] = "ViewTransaction";

#line default
#line hidden
            BeginContext(90, 131, true);
            WriteLiteral("\n<div class=\"currency_container\">\n    <div class=\"currency_info\">\n        <p>\n            <span>Cashier: </span>\n            <span>");
            EndContext();
            BeginContext(222, 13, false);
#line 10 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewTransaction.cshtml"
             Write(Model.Cashier);

#line default
#line hidden
            EndContext();
            BeginContext(235, 85, true);
            WriteLiteral("</span>\n        </p>\n        <p>\n            <span>Client: </span>\n            <span>");
            EndContext();
            BeginContext(321, 17, false);
#line 14 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewTransaction.cshtml"
             Write(Model.Client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(338, 26, true);
            WriteLiteral("</span>\n            <span>");
            EndContext();
            BeginContext(365, 20, false);
#line 15 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewTransaction.cshtml"
             Write(Model.Client.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(385, 94, true);
            WriteLiteral("</span>\n        </p>\n        <p>\n            <span>Client Currency: </span>\n            <span>");
            EndContext();
            BeginContext(480, 33, false);
#line 19 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewTransaction.cshtml"
             Write(Model.ClientCurrency.CurrencyName);

#line default
#line hidden
            EndContext();
            BeginContext(513, 26, true);
            WriteLiteral("</span>\n            <span>");
            EndContext();
            BeginContext(540, 33, false);
#line 20 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewTransaction.cshtml"
             Write(Model.ClientCurrency.SellingPrice);

#line default
#line hidden
            EndContext();
            BeginContext(573, 26, true);
            WriteLiteral("</span>\n            <span>");
            EndContext();
            BeginContext(600, 26, false);
#line 21 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewTransaction.cshtml"
             Write(Model.AmountClientCurrency);

#line default
#line hidden
            EndContext();
            BeginContext(626, 94, true);
            WriteLiteral("</span>\n        </p>\n        <p>\n            <span>Target Currency: </span>\n            <span>");
            EndContext();
            BeginContext(721, 33, false);
#line 25 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewTransaction.cshtml"
             Write(Model.TargetCurrency.CurrencyName);

#line default
#line hidden
            EndContext();
            BeginContext(754, 26, true);
            WriteLiteral("</span>\n            <span>");
            EndContext();
            BeginContext(781, 33, false);
#line 26 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewTransaction.cshtml"
             Write(Model.TargetCurrency.SellingPrice);

#line default
#line hidden
            EndContext();
            BeginContext(814, 26, true);
            WriteLiteral("</span>\n            <span>");
            EndContext();
            BeginContext(841, 26, false);
#line 27 "C:\Users\User-PC\Projects\ExchangeOffice\ExchangeApp\Exchange App\Views\Exchange\ViewTransaction.cshtml"
             Write(Model.AmountTargetCurrency);

#line default
#line hidden
            EndContext();
            BeginContext(867, 38, true);
            WriteLiteral("</span>\n        </p>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exchange_App.DAL.Entities.Exchange> Html { get; private set; }
    }
}
#pragma warning restore 1591
