#pragma checksum "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "265d008ab55a0536dee8400ea17ee05d55b23acf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoItem_Index), @"mvc.1.0.view", @"/Views/ToDoItem/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"265d008ab55a0536dee8400ea17ee05d55b23acf", @"/Views/ToDoItem/Index.cshtml")]
    public class Views_ToDoItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToDo.Models.ToDoItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItem\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\" asp-controller=\"ToDoItem\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItem\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Task));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItem\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 26 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItem\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 29 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Task));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItem\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Completed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 839, "\"", 862, 1);
#nullable restore
#line 35 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItem\Index.cshtml"
WriteAttributeValue("", 854, item.Id, 854, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 915, "\"", 938, 1);
#nullable restore
#line 36 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItem\Index.cshtml"
WriteAttributeValue("", 930, item.Id, 930, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 993, "\"", 1016, 1);
#nullable restore
#line 37 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItem\Index.cshtml"
WriteAttributeValue("", 1008, item.Id, 1008, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 40 "D:\UofA\DEMOS\VISUAL_STUDIO\ToDo\ToDo\Views\ToDoItem\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToDo.Models.ToDoItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
