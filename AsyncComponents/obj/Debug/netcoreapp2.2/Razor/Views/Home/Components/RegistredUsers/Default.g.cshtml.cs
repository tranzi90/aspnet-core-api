#pragma checksum "D:\Google Drive\Course Development\ASP.NET Core. Building User Interface\Lesson 6. View Components\Samples\AsyncComponents\Views\Home\Components\RegistredUsers\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f294df3a2742be01e57e4bc4682a6c475bb6ee50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_RegistredUsers_Default), @"mvc.1.0.view", @"/Views/Home/Components/RegistredUsers/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/RegistredUsers/Default.cshtml", typeof(AspNetCore.Views_Home_Components_RegistredUsers_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f294df3a2742be01e57e4bc4682a6c475bb6ee50", @"/Views/Home/Components/RegistredUsers/Default.cshtml")]
    public class Views_Home_Components_RegistredUsers_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AsyncComponents.Model.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(41, 10, true);
            WriteLiteral("\r\n\r\n<ul>\r\n");
            EndContext();
#line 5 "D:\Google Drive\Course Development\ASP.NET Core. Building User Interface\Lesson 6. View Components\Samples\AsyncComponents\Views\Home\Components\RegistredUsers\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(92, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(105, 9, false);
#line 7 "D:\Google Drive\Course Development\ASP.NET Core. Building User Interface\Lesson 6. View Components\Samples\AsyncComponents\Views\Home\Components\RegistredUsers\Default.cshtml"
       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(114, 4, true);
            WriteLiteral(" (<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 118, "\"", 143, 2);
            WriteAttributeValue("", 125, "mailto:", 125, 7, true);
#line 7 "D:\Google Drive\Course Development\ASP.NET Core. Building User Interface\Lesson 6. View Components\Samples\AsyncComponents\Views\Home\Components\RegistredUsers\Default.cshtml"
WriteAttributeValue("", 132, item.Email, 132, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(144, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(146, 10, false);
#line 7 "D:\Google Drive\Course Development\ASP.NET Core. Building User Interface\Lesson 6. View Components\Samples\AsyncComponents\Views\Home\Components\RegistredUsers\Default.cshtml"
                                                Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(156, 12, true);
            WriteLiteral("</a>)</li>\r\n");
            EndContext();
#line 8 "D:\Google Drive\Course Development\ASP.NET Core. Building User Interface\Lesson 6. View Components\Samples\AsyncComponents\Views\Home\Components\RegistredUsers\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(175, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AsyncComponents.Model.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
