#pragma checksum "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5401c40a0ff6f06a8ac73380d0b2c19897fcefca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Pictoload.Pages.Userdashboard.Pages_Userdashboard_DeleteImage), @"mvc.1.0.razor-page", @"/Pages/Userdashboard/DeleteImage.cshtml")]
namespace Pictoload.Pages.Userdashboard
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
#line 1 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\_ViewImports.cshtml"
using Pictoload;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\_ViewImports.cshtml"
using Pictoload.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\_ViewImports.cshtml"
using Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\_ViewImports.cshtml"
using Application.Album.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\_ViewImports.cshtml"
using Application.Album.Queries;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\_ViewImports.cshtml"
using Application.Album.Commands;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5401c40a0ff6f06a8ac73380d0b2c19897fcefca", @"/Pages/Userdashboard/DeleteImage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac11d8fec60ea0cb5455c253ab8c25f9f2930eed", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Userdashboard_DeleteImage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
  
    ViewData["Title"] = "DeleteImage";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>DeleteImage</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Photo</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayFor(model => model.Photo.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo.Geolocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayFor(model => model.Photo.Geolocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo.DateCaptured));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayFor(model => model.Photo.DateCaptured));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo.CapturedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayFor(model => model.Photo.CapturedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayFor(model => model.Photo.ImagePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
       Write(Html.DisplayFor(model => model.Photo.User.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5401c40a0ff6f06a8ac73380d0b2c19897fcefca10481", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5401c40a0ff6f06a8ac73380d0b2c19897fcefca10748", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 55 "C:\Studies 2021\Semester2\ITdevelopments_323\Project_2\PitcoLoad323\Pictoload\Pages\Userdashboard\DeleteImage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Photo.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5401c40a0ff6f06a8ac73380d0b2c19897fcefca12578", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebUI.Pages.Userdashboard.DeleteImageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebUI.Pages.Userdashboard.DeleteImageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebUI.Pages.Userdashboard.DeleteImageModel>)PageContext?.ViewData;
        public WebUI.Pages.Userdashboard.DeleteImageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
