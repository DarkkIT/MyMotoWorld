#pragma checksum "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d3c147e734e82f1991660d64a78ed3dbdaf2128"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Details), @"mvc.1.0.view", @"/Views/Store/Details.cshtml")]
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
#line 1 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\_ViewImports.cshtml"
using MyMotoWorld.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\_ViewImports.cshtml"
using MyMotoWorld.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
using MyMotoWorld.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d3c147e734e82f1991660d64a78ed3dbdaf2128", @"/Views/Store/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d91716792cdd750882fa7df904d5f2db26c4c59", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyMotoWorld.Web.ViewModels.MotorBike.MotorBikeFullInfoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/storeditailscss.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark mr-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToFavorit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("antiForgeryForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
  
    this.ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3c147e734e82f1991660d64a78ed3dbdaf21287495", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2d3c147e734e82f1991660d64a78ed3dbdaf21287757", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 9 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link href=\"https://fonts.googleapis.com/css2?family=Ultra&display=swap\" rel=\"stylesheet\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n    <div>\r\n        <h1 class=\"text-center\">");
#nullable restore
#line 17 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <h2 class=\"text-center\">");
#nullable restore
#line 18 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                           Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n\r\n    <div class=\"thumbnail\">\r\n        <img class=\"card-img\"");
            BeginWriteAttribute("src", " src=", 644, "", 674, 1);
#nullable restore
#line 22 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
WriteAttributeValue("", 649, this.Model.MainImagePath, 649, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"bike\">\r\n    </div>\r\n\r\n    <div class=\"row justify-content-between\">\r\n\r\n        <div class=\"ml-5\">\r\n            <h4 class=\"card-title mt-2\">");
#nullable restore
#line 28 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                   Write(this.Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                                     Write(Model.EngineCapacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p class=\"card-text text-black-10\"><i class=\"fas fa-euro-sign\"></i>");
#nullable restore
#line 29 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                                                          Write(this.Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div>\r\n            <ul class=\"row list-unstyled mt-3\">\r\n");
#nullable restore
#line 34 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                 if (Model.AvarageVote > 0.4)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li id=\"star\" class=\"star-fill ml-2\" data-vote=\"1\"><i class=\"fas fa-star fa-2x\" style=\"color: #e8cd1c\"></i></li>\r\n");
#nullable restore
#line 37 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li id=\"star\" class=\"star-fill ml-2\" data-vote=\"1\"><i class=\"fas fa-star fa-2x\"></i></li>\r\n");
#nullable restore
#line 41 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 43 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                 if (Model.AvarageVote > 1.4)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li id=\"star\" class=\"star-fill ml-2\" data-vote=\"2\"><i class=\"fas fa-star fa-2x\" style=\"color: #e8cd1c\"></i></li>\r\n");
#nullable restore
#line 46 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li id=\"star\" class=\"star-fill ml-2\" data-vote=\"2\"><i class=\"fas fa-star fa-2x\"></i></li>\r\n");
#nullable restore
#line 50 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 52 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                 if (Model.AvarageVote > 2.4)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li id=\"star\" class=\"star-fill ml-2\" data-vote=\"3\"><i class=\"fas fa-star fa-2x\" style=\"color: #e8cd1c\"></i></li>\r\n");
#nullable restore
#line 55 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li id=\"star\" class=\"star-fill ml-2\" data-vote=\"3\"><i class=\"fas fa-star fa-2x\"></i></li>\r\n");
#nullable restore
#line 59 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 61 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                 if (Model.AvarageVote > 3.4)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li id=\"star\" class=\"star-fill ml-2\" data-vote=\"4\"><i class=\"fas fa-star fa-2x\" style=\"color: #e8cd1c\"></i></li>\r\n");
#nullable restore
#line 64 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li id=\"star\" class=\"star-fill ml-2\" data-vote=\"4\"><i class=\"fas fa-star fa-2x\"></i></li>\r\n");
#nullable restore
#line 68 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 70 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                 if (Model.AvarageVote > 4.8)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li id=\"star\" class=\"star-fill ml-2\" data-vote=\"5\"><i class=\"fas fa-star fa-2x\" style=\"color: #e8cd1c\"></i></li>\r\n");
#nullable restore
#line 73 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li id=\"star\" class=\"star-fill ml-2\" data-vote=\"5\"><i class=\"fas fa-star fa-2x\"></i></li>\r\n");
#nullable restore
#line 77 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                <li class=\"ml-2\"><span id=\"avarageVoteValue\" style=\"font-size: 25px; font-family: Ultra\">");
#nullable restore
#line 81 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                                                                                    Write(Model.AvarageVote.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span style=\"font-family: Ultra\"> / 5</span> </li>\r\n\r\n            </ul>\r\n        </div>\r\n\r\n        <div class=\"mr-5\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3c147e734e82f1991660d64a78ed3dbdaf212818364", async() => {
                WriteLiteral("Add to Card");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"row justify-content-end\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3c147e734e82f1991660d64a78ed3dbdaf212820109", async() => {
                WriteLiteral("AddToFavorit<i class=\"far fa-star ml-1\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>

    <div class=""card-columns mt-5"">

        <div class=""card mb-3"">
            <div class=""card-body"">
                <h5 class=""card-title"">SUZUKI PROTECTION PLAN</h5>
                <p class=""card-text"">
                    Suzuki Protection Plan is a comprehensive plan that covers all major components,
                    parts and electrical/computer systems along with all seals and gaskets and shocks on your Suzuki Motorcycle or ATV.
                    Only normal wear or maintenance items are not covered. We’ve built Suzuki Protection Plan around coverage, not exclusions.
                </p>
                <p class=""card-text""><small class=""text-muted""></small></p>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title text-center"">ENGINE</h5>
                <p class=""card-text"">");
#nullable restore
#line 113 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                Write(Model.EngineName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <p class=""card-text""><small class=""text-muted"">For Passions</small></p>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title text-center"">TRANSMISSION</h5>
                <p class=""card-text"">");
#nullable restore
#line 121 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                Write(Model.Transmission);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <p class=""card-text""><small class=""text-muted"">For Passions</small></p>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title text-center"">FRONT SUSPENSION</h5>
                <p class=""card-text"">");
#nullable restore
#line 129 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                Write(Model.FrontSuspension);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <p class=""card-text""><small class=""text-muted"">For Passions</small></p>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title text-center"">FRONT BREAKS</h5>
                <p class=""card-text"">");
#nullable restore
#line 137 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                Write(Model.FrontBrakes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <p class=""card-text""><small class=""text-muted"">For Passions</small></p>
            </div>
        </div>

        <div class=""card"">
            <img class=""card-img"" src=/images/bikes/logo.png alt=""bike"">
        </div>

        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title text-center"">REAR SUSPENSION</h5>
                <p class=""card-text"">");
#nullable restore
#line 149 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                Write(Model.RearSuspension);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <p class=""card-text""><small class=""text-muted"">For Passions</small></p>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title text-center"">REAR BRAKES</h5>
                <p class=""card-text"">");
#nullable restore
#line 157 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                Write(Model.RearBrakes);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <p class=""card-text""><small class=""text-muted"">For Passions</small></p>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title text-center"">BIKE TYPE</h5>
                <p class=""card-text"">");
#nullable restore
#line 165 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                Write(Model.BikeType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <p class=""card-text""><small class=""text-muted"">For Passions</small></p>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title text-center"">COOLING SYSTEM</h5>
                <p class=""card-text"">");
#nullable restore
#line 173 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                Write(Model.CoolingSystem);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                <p class=""card-text""><small class=""text-muted"">For Passions</small></p>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-body"">
                <h5 class=""card-title text-center"">ABOUT</h5>
                <p class=""card-text"">");
#nullable restore
#line 181 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                                Write(Model.Descrition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\"><small class=\"text-muted\">For Passions</small></p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"thumbnail\">\r\n        <img class=\"card-img\"");
            BeginWriteAttribute("src", " src=", 7471, "", 7503, 1);
#nullable restore
#line 188 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
WriteAttributeValue("", 7476, this.Model.SecondImagePath, 7476, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""bike"">
    </div>

    <div class=""card mb-3"">
        <div class=""card-body"">
            <h5 class=""card-title"">SUZUKI PROTECTION PLAN</h5>
            <p class=""card-text"">
                Suzuki Protection Plan is a comprehensive plan that covers all major components,
                parts and electrical/computer systems along with all seals and gaskets and shocks on your Suzuki Motorcycle or ATV.
                Only normal wear or maintenance items are not covered. We’ve built Suzuki Protection Plan around coverage, not exclusions.
            </p>
            <p class=""card-text""><small class=""text-muted""></small></p>
        </div>
    </div>

    <div class=""container my-4"">
        <hr>

        <div class=""embed-responsive embed-responsive-16by9"">
            <iframe class=""embed-responsive-item"" src=""https://youtu.be/cZr1MEmIQN8"" allowfullscreen></iframe>
        </div>
    </div>

</div>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d3c147e734e82f1991660d64a78ed3dbdaf212829186", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n        $(\"li[data-vote]\").each(function (el) {\r\n            $(this).click(function () {\r\n                var vote = $(this).attr(\"data-vote\");\r\n                var value = parseInt(vote);\r\n                var motorBikeId = ");
#nullable restore
#line 220 "D:\VisualStudio\MyMotoWorld\Web\MyMotoWorld.Web\Views\Store\Details.cshtml"
                             Write(Model.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                var antiForgeryToken = $('#antiForgeryForm input[name=__RequestVerificationToken]').val();
                var data = { motorBikeId: motorBikeId, value: value };
                $.ajax({
                    type: ""POST"",
                    url: ""/api/Votes"",
                    data: JSON.stringify(data),
                    headers: { 'X-CSRT-TOKEN': antiForgeryToken },
                    success: function (data) {
                        $('#avarageVoteValue').html(data.avarageVotes.toFixed(1));
                    },
                    contentType: 'application/json',
                });

            })

        });

    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyMotoWorld.Web.ViewModels.MotorBike.MotorBikeFullInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591