#pragma checksum "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9a3bf50a23c2a2ca30a180be399c94885a57e53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryList), @"mvc.1.0.view", @"/Views/Category/CategoryList.cshtml")]
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
#line 1 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\_ViewImports.cshtml"
using DigicelApps;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\_ViewImports.cshtml"
using DigicelApps.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\_ViewImports.cshtml"
using DigicelApps.Models.DTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9a3bf50a23c2a2ca30a180be399c94885a57e53", @"/Views/Category/CategoryList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cab98fbb95b7547e404797f5d6d20b9627473a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_CategoryList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    .message {
        color: black;
        font-weight: bold;
    }

    .message-error {
        color: red;
        font-weight: bold;
    }


    .close {
        font-weight: bold;
        color: black;
        position: relative;
        top: 15px;
        float: right;
        cursor: pointer;
        margin-right: 5px;
    }
</style>
");
            WriteLiteral("<br />\r\n<br />\r\n");
#nullable restore
#line 26 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
 if (ViewBag.success != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"alert-success text-center message\">");
#nullable restore
#line 28 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
                                             Write(ViewBag.success);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a id=\"close\" style=\"color:black\" class=\"close\">X</a></h1>\r\n");
#nullable restore
#line 29 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
 if (ViewBag.error != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1 class=\"alert-warning text-center message-error\">");
#nullable restore
#line 33 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
                                                   Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a id=\"close\" style=\"color:black\" class=\"close\">X</a></h1>\r\n");
#nullable restore
#line 34 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<h1>Lista de categorias</h1>
<br />

<div class=""row"">
    <div class=""col-md-1 col-sm-12"">

    </div>
    <div class=""col-md-10 col-sm-12"">
        <table id=""table"" class=""table table-striped table-bordered dt-responsive nowrap"" style=""width:100%"">
            <thead>
                <tr>
                    <th>Nombre</th>
                    <th>Descripcion</th>                    
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 52 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th>");
#nullable restore
#line 55 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <th>");
#nullable restore
#line 56 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>                       \r\n                        <th>\r\n                            <a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1515, "\"", 1570, 1);
#nullable restore
#line 58 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
WriteAttributeValue("", 1522, Url.Action("Edit","Category",new {id=item.Id }), 1522, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a>\r\n                            | <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1639, "\"", 1696, 1);
#nullable restore
#line 59 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
WriteAttributeValue("", 1646, Url.Action("Delete","Category",new {id=item.Id }), 1646, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Eliminar</a>\r\n                        </th>\r\n                    </tr>\r\n");
#nullable restore
#line 62 "C:\Users\pablo\Desktop\DigicelApps\DigicelApps\Views\Category\CategoryList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n    <div class=\"col-md-1 col-sm-12\">\r\n\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#table').DataTable();
            var table_filter = $(""#table_filter"").val();
            table_filter.addcss
        });

        var close = document.querySelector(""#close"");
        close.addEventListener(""click"", closeit);

        function closeit() {
            var message = document.querySelector("".message"");
            message.style.display = ""none"";
        }
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591