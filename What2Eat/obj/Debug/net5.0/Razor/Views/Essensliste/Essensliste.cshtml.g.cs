#pragma checksum "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b349e0239592eff482fdd756945cc31087df7e34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Essensliste_Essensliste), @"mvc.1.0.view", @"/Views/Essensliste/Essensliste.cshtml")]
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
#line 1 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\_ViewImports.cshtml"
using What2Eat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\_ViewImports.cshtml"
using What2Eat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b349e0239592eff482fdd756945cc31087df7e34", @"/Views/Essensliste/Essensliste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"879f5ce33711c1a1a2518c6ccfdd4c42f99ecd96", @"/Views/_ViewImports.cshtml")]
    public class Views_Essensliste_Essensliste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EssenslisteModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
  
    ViewBag.Title = "Essensliste";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Essensliste</h1>\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>");
#nullable restore
#line 11 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 12 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 13 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
       Write(Html.DisplayNameFor(model => model.Janic));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 14 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
       Write(Html.DisplayNameFor(model => model.Oma));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        <th>");
#nullable restore
#line 15 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
       Write(Html.DisplayNameFor(model => model.Opa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 18 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 21 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
   Write(Html.DisplayFor(modelItem => item.Janic));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
   Write(Html.DisplayFor(modelItem => item.Oma));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
   Write(Html.DisplayFor(modelItem => item.Opa));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n</tr>\r\n");
#nullable restore
#line 27 "D:\PRODUKTIV\PROGRAMMIEREN\VisualStudio19\Projekte\What2Eat\What2Eat\Views\Essensliste\Essensliste.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EssenslisteModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
