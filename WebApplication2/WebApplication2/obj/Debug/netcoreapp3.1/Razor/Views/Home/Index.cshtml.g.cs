#pragma checksum "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a57ef2f9477d933cb8653458a35e6342c42b1ade"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a57ef2f9477d933cb8653458a35e6342c42b1ade", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n");
#nullable restore
#line 3 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
  
   
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a57ef2f9477d933cb8653458a35e6342c42b1ade3379", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 11 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
   Write(Html.HiddenFor(model => Model[i]));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
                                          
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    \r\n");
#nullable restore
#line 16 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-md-2\">\r\n                ");
#nullable restore
#line 20 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <input");
                BeginWriteAttribute("id", " id=", 428, "", 450, 2);
                WriteAttributeValue("", 432, "T+", 432, 2, true);
#nullable restore
#line 23 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 434, item.EmployeeId, 434, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=", 450, "", 474, 2);
                WriteAttributeValue("", 456, "T+", 456, 2, true);
#nullable restore
#line 23 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 458, item.EmployeeId, 458, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" readonly=\"readonly\"");
                BeginWriteAttribute("value", " value=\"", 506, "\"", 532, 1);
#nullable restore
#line 23 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 514, item.employeeType, 514, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                \r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <input");
                BeginWriteAttribute("id", " id=", 634, "", 654, 1);
#nullable restore
#line 27 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 638, item.EmployeeId, 638, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", "  name=\"", 654, "\"", 678, 1);
#nullable restore
#line 27 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 662, item.EmployeeId, 662, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" min=\"0\" max=\"260\"");
                BeginWriteAttribute("value", " value=\"", 711, "\"", 733, 1);
#nullable restore
#line 27 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 719, item.WorkDays, 719, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <input");
                BeginWriteAttribute("id", " id=", 816, "", 838, 2);
                WriteAttributeValue("", 820, "V+", 820, 2, true);
#nullable restore
#line 30 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 822, item.EmployeeId, 822, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("name", " name=", 838, "", 862, 2);
                WriteAttributeValue("", 844, "V+", 844, 2, true);
#nullable restore
#line 30 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 846, item.EmployeeId, 846, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" min=\"0\" max=\"30\"");
                BeginWriteAttribute("value", " value=\"", 893, "\"", 919, 1);
#nullable restore
#line 30 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 901, item.VacationDays, 901, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1018, "\"", 1063, 3);
                WriteAttributeValue("", 1028, "GetVacationDays(\'", 1028, 17, true);
#nullable restore
#line 33 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1045, item.EmployeeId, 1045, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1061, "\')", 1061, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Work</button>\r\n            </div>\r\n            <div class=\"col-md-2\">\r\n                <button type=\"button\"");
                BeginWriteAttribute("onclick", " onclick=\"", 1173, "\"", 1215, 3);
                WriteAttributeValue("", 1183, "TakeVacation(\'", 1183, 14, true);
#nullable restore
#line 36 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"
WriteAttributeValue("", 1197, item.EmployeeId, 1197, 16, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1213, "\')", 1213, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Take Vacation</button>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 39 "C:\Users\Nares\source\repos\WebApplication2\WebApplication2\Views\Home\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"



<script type=""text/javascript"">
    function GetVacationDays(id) {
        var daysWorked = document.getElementById(id).value;
        if (daysWorked < 0 || daysWorked > 260) {
            alert(""Work days out of range"");
        } else {
            $.ajax({

                url: ""Home/Work"",
                // data: JSON.stringify(obj),
                data: { ""employeeId"": id, ""workDays"": daysWorked },
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",

                success: function () {
                    location.reload();
                }
            });
        }
   
    }

    function TakeVacation(id) {
        var name = 'V+' + id;
        var typeName = 'T+' + id;
        var vacationDays = document.getElementById(name).value;
        var employeeType = document.getElementById(typeName).value;
        if (employeeType == ""Hourly"" && (vacationDays > 10 || vacationDays < 0)) {
            alert(""Vacation days out");
                WriteLiteral(@" of range"");
        } else if (employeeType == ""Salaried"" && (vacationDays > 15 || vacationDays < 0)) {
            alert(""Vacation days out of range"");
        }
        else if (employeeType == ""Salaried"" && (vacationDays > 30 || vacationDays < 0)) {
            alert(""Vacation days out of range"");
        }
        else {
            $.ajax({

                url: ""Home/TakeVacation"",
                // data: JSON.stringify(obj),
                data: { ""employeeId"": id, ""workDays"": vacationDays },
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",

                success: function () {
                    location.reload();
                }
            });
        }

}
</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
