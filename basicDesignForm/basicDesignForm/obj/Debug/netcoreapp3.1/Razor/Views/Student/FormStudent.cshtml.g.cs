#pragma checksum "E:\C#\CShape_Code_From_Youtube\basicDesignForm\basicDesignForm\Views\Student\FormStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04b158fe82e28452e26922a1ba5341fb280588b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_FormStudent), @"mvc.1.0.view", @"/Views/Student/FormStudent.cshtml")]
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
#line 1 "E:\C#\CShape_Code_From_Youtube\basicDesignForm\basicDesignForm\Views\_ViewImports.cshtml"
using basicDesignForm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C#\CShape_Code_From_Youtube\basicDesignForm\basicDesignForm\Views\_ViewImports.cshtml"
using basicDesignForm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04b158fe82e28452e26922a1ba5341fb280588b9", @"/Views/Student/FormStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d764d0c7239918ed07ee71f788a814cf345000a", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_FormStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "M", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "F", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "O", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\C#\CShape_Code_From_Youtube\basicDesignForm\basicDesignForm\Views\Student\FormStudent.cshtml"
  
    ViewData["Title"] = "FormStudent";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container"">
    <h2 class=""h2"">Form The student </h2>
    <hr />
    <div class=""row"">
        <div class=""col-sm-6"">
            IDCard:
            <input type=""password"" class=""form-control"" id=""idCard"" />
            Name:
            <input type=""text"" class=""form-control"" id=""idName"" />
            Gender
            <select class=""form-control"" id=""idGender"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04b158fe82e28452e26922a1ba5341fb280588b95227", async() => {
                WriteLiteral("Male");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04b158fe82e28452e26922a1ba5341fb280588b96400", async() => {
                WriteLiteral("Female");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04b158fe82e28452e26922a1ba5341fb280588b97575", async() => {
                WriteLiteral("Other");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
            Address:
            <textarea class=""form-control"" id=""idAddress"" rows=""4"">
    
            </textarea>
        </div>
        <div class=""col-sm-6"">
            Phone:
            <input type=""text"" class=""form-control"" id=""idPhone"" />
            DOB:
            <input type=""date"" class=""form-control"" id=""iddate"" />


        </div>
    </div>

    <hr />
    <div class=""row"">
        <div class=""col-sm-12"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>No.</th>
                        <th>Level</th>
                        <th>Price</th>
                        <th>Time</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>1</td>
                        <td>Laravel</td>
                        <td>100</td>
                        <td>11:00PM -> 12:00 </td>

                    </tr>

      ");
            WriteLiteral(@"              <tr>
                        <td>2</td>
                        <td>C#</td>
                        <td>100</td>
                        <td>11:00PM -> 12:00 </td>

                    </tr>
                </tbody>
            </table>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-sm-12"">
          <button class=""btn btn-outline-primary w-100 mt-2"" id=""save"">Save</button>
        </div>
    </div> 





</div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04b158fe82e28452e26922a1ba5341fb280588b910301", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script type=""text/javascript"">
    $(document).ready(function () {

        //$(""#save"").click(function () {
        //    //$('#idPhone').val(""015844712"");
        //    //$('#idName').val(""015844712"");
        //    //$('#idpw').val(""015844712"");
        //    //var textH2 = $(""h2"").text();
        //    //alert(textH2);


        //})

        //$('#iddate').on('change', function () {
        //    var a = $(this).val();
        //    $(""h2"").text(a);
        // })

        //$(""#idGender"").change(function () {
        //    /*var text = $(this).val();*/
        //    /*$(""h2"").text(text);*/
        //    alert($(this).val() + "" - "" + $(""#idGender option:selected"").text());

        //})

        $(""#save"").click(function () {
            var objStudent = {};
            var ListStudent = [];



            objStudent.IDCard = $(""#idCard"").val();
            objStudent.Name = $(""#idName"").val();
            objStudent.Gender = $(""#idGender"").val();
            objStuden");
            WriteLiteral(@"t.Address = $(""#idAddress"").val();
            objStudent.Phone = $(""#idPhone"").val();
            objStudent.DOB = $(""#iddate"").val();
            objStudent.Name = $(""#idName"").val();

            var ObjLevel = {};
            var ListLevel = [];

            ObjLevel.LevelName = ""C#"";
            ObjLevel.Price = 45.15;
            ObjLevel.Time = ""11:00PM -> 12:15PM"";
            ListLevel.push(ObjLevel);

            ObjLevel.LevelName = ""Laravel"";
            ObjLevel.Price = 42.00;
            ObjLevel.Time = ""10:00PM -> 12:15PM"";
            ListLevel.push(ObjLevel);
            objStudent.levels = ListLevel;

           
            
            //console.log(objStudent);
            ListStudent.push(objStudent); //thiss add object to array


            //using ajax for send data to controller
            //ajax data by object
            $.ajax({
                url: '");
#nullable restore
#line 145 "E:\C#\CShape_Code_From_Youtube\basicDesignForm\basicDesignForm\Views\Student\FormStudent.cshtml"
                 Write(Url.Action("PostStudent", "Student"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"', //send data to controller
                method: ""POST"",
                dataType: ""JSON"",
                data: {
                    obj: objStudent
                },
                success: function(obj){
                    //$(""#idAddress"").val(data.address);
                    //alert(data.ErrorMsg + '-' + data.ErrorCode);
                    console.log(obj);
                    alert(""Insert Success => "" + obj.errorCode + ""--"" + obj.errorMsg);
                }

            })


            //ajax data by array
");
            WriteLiteral("\r\n            //})\r\n        })\r\n    });\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
