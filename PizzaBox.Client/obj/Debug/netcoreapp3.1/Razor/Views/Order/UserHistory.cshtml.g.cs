#pragma checksum "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/Order/UserHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb43785bb29cc9dc4e285e73b7a1ce692c8ac31b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_UserHistory), @"mvc.1.0.view", @"/Views/Order/UserHistory.cshtml")]
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
#line 1 "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb43785bb29cc9dc4e285e73b7a1ce692c8ac31b", @"/Views/Order/UserHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_UserHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.UserHistoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>\n");
#nullable restore
#line 4 "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/Order/UserHistory.cshtml"
   if(@Model.Orders != null)
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/Order/UserHistory.cshtml"
   foreach (var item in @Model.Orders)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("      <label>Order Number: </label>\n      <label>");
#nullable restore
#line 9 "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/Order/UserHistory.cshtml"
        Write(item.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n      <br>\n");
#nullable restore
#line 11 "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/Order/UserHistory.cshtml"
       foreach (var i in @Model.Pizzas)
      {
          if(i.Order == item)
          {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <label>");
#nullable restore
#line 15 "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/Order/UserHistory.cshtml"
              Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n            <label> Price: </label>\n            <label>");
#nullable restore
#line 17 "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/Order/UserHistory.cshtml"
              Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n            <br>\n");
#nullable restore
#line 19 "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/Order/UserHistory.cshtml"
          }
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/Order/UserHistory.cshtml"
       
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/home/dummer-isaiah/revature_projects/p1/p1-dummer-isaiah/PizzaBox.Client/Views/Order/UserHistory.cshtml"
 
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<div>\n  <a href=\"/order/gonav\"> go back to main menu</a>\n  \n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.UserHistoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
