#pragma checksum "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8dd75b6dd45c62f917896523b1088d4f3fc44a45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clubs_Details), @"mvc.1.0.view", @"/Views/Clubs/Details.cshtml")]
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
#line 1 "C:\Users\zacks\source\repos\racesmiths\Views\_ViewImports.cshtml"
using racesmiths;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zacks\source\repos\racesmiths\Views\_ViewImports.cshtml"
using racesmiths.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dd75b6dd45c62f917896523b1088d4f3fc44a45", @"/Views/Clubs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a553fd2d836cedda3529fdce8cabba0f1db1ccda", @"/Views/_ViewImports.cshtml")]
    public class Views_Clubs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<racesmiths.Models.Club>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#createChamp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Champs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Clubs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssignUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link upcoming-track"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row my-center\">\r\n    <h1>");
#nullable restore
#line 7 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
   Write(Model.ClubName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><hr />\r\n");
#nullable restore
#line 8 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
     if (User.IsInRole("ClubManager") || User.IsInRole("Admin"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"float-right\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd75b6dd45c62f917896523b1088d4f3fc44a458521", async() => {
                WriteLiteral("\r\n                Create Championship\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
                                                                                                                                             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd75b6dd45c62f917896523b1088d4f3fc44a4511475", async() => {
                WriteLiteral("\r\n                Assign Users\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 14 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
                                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd75b6dd45c62f917896523b1088d4f3fc44a4514214", async() => {
                WriteLiteral("\r\n                Remove Users\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
                                                                                                  WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </span>\r\n");
#nullable restore
#line 21 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"row my-center\">\r\n    <h2>Current Championships</h2>\r\n</div>\r\n<hr />\r\n");
#nullable restore
#line 28 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
 if (Model.Champs.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row my-center upcoming-track\">\r\n        No scheduled Championships\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
     foreach (var item in Model.Champs)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row my-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd75b6dd45c62f917896523b1088d4f3fc44a4518008", async() => {
                WriteLiteral("\r\n                <span>\r\n                    ");
#nullable restore
#line 41 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.ChampName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </span>\r\n                <span class=\"game\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Game));

#line default
#line hidden
#nullable disable
                WriteLiteral("Project Cars 2\r\n                </span>\r\n                <span class=\"game\">\r\n                    | ");
#nullable restore
#line 47 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
                 Write(Html.DisplayFor(modelItem => item.System));

#line default
#line hidden
#nullable disable
                WriteLiteral("Xbox One X\r\n                </span><br />\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
                                                                                                  WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 51 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
     

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<hr />\r\n<div class=\"row\">\r\n");
#nullable restore
#line 56 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
     foreach (var user in Model.ClubUsers)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
   Write(user.Gamertag);

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
                      
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
            WriteLiteral(@"<div class=""modal fade silver"" id=""createChamp"" tabindex=""-1"" role=""dialog""
     aria-labelledby=""exampleModalScrollableTitle"" aria-hidden=""true"" data-animation=""makeway"">
    <div class=""modal-dialog modal-dialog-scrollable"" role=""document"">
        <div class=""modal-content my-modal"">
            <div class=""row my-center"">
                <div class=""my-modal-head"">
                    Create Championship
                </div>
            </div>
");
            WriteLiteral("            <div class=\"modal-body my-modal-div\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd75b6dd45c62f917896523b1088d4f3fc44a4523168", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"ClubId\"");
                BeginWriteAttribute("value", " value=\"", 2895, "\"", 2912, 1);
#nullable restore
#line 81 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
WriteAttributeValue("", 2903, Model.Id, 2903, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd75b6dd45c62f917896523b1088d4f3fc44a4523875", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 83 "C:\Users\zacks\source\repos\racesmiths\Views\Clubs\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    <div class=""form-group"">
                        Video Game
                        <input name=""Game"" class=""form-control bg-soft-dark"" placeholder=""Game"" />
                    </div>
                    <div class=""form-group"">
                        Gaming System
                        <input name=""System"" class=""form-control bg-soft-dark"" placeholder=""System"" />
                    </div>
                    <div class=""form-group"">
                        Name
                        <input name=""ChampName"" class=""form-control bg-soft-dark"" placeholder=""Championship Name"" />
                    </div>
                    <div class=""form-group"">
                        Rounds
                        <input name=""Rounds"" class=""form-control bg-soft-dark"" placeholder=""How Many Rounds?"" />
                    </div>
                    <div class=""form-group"">
                        First Race
                        <input type=""datetime"" name=""StartDate"" class=""");
                WriteLiteral(@"form-control bg-soft-dark"" placeholder=""Date and time"" />
                    </div>
                    <p>The following settings will be set across all Events in the championship.  Settings that will change from race to race will need to be left empty here. </p><hr />
                    <h2>Vehicle</h2>
                    <div class=""row modal-section my-center"">
                        Choose a Class with the option of excluding car(s)
                        <div class=""col-6 form-group"">
                            Vehicle Class
                            <input name=""VehicleClass"" class=""form-control bg-soft-dark"" placeholder=""Class..."" />
                        </div>
                        <div class=""col form-group"">
                            Exclude Vehicle(s)
                            <textarea name=""ExcludeVehicle"" class=""form-control bg-soft-dark"" placeholder=""Vehicle name(s)...""></textarea>
                        </div>
                    </div>
                    <div");
                WriteLiteral(@" class=""row my-center"">
                        OR
                    </div>
                    <div class=""row modal-section my-center"">
                        <div class=""form-group"">
                            All drivers in the same vehicle 
                            <input name=""Vehicle"" class=""form-control bg-soft-dark"" placeholder=""Vehicle name..."" />
                        </div>
                    </div>

                    <h2>Race</h2>
                    <div class=""row"">
                        <div class=""col-6 form-group"">
                            Laps
                            <input name=""Laps"" class=""form-control bg-soft-dark"" placeholder=""Laps"" />
                        </div>
                        <div class=""col form-group"">
                            Race length
                            <input name=""RaceLength"" class=""form-control bg-soft-dark"" placeholder=""Minutes"" />
                        </div>
                    </div>
                    ");
                WriteLiteral(@"<div class=""row"">
                        <div class=""col-6 form-group"">
                            In-Game Date:
                            <input name=""IGDate"" class=""form-control bg-soft-dark"" placeholder=""Season..."" />
                        </div>
                        <div class=""col form-group"">
                            In-Game time for Race
                            <input name=""IGTRace"" class=""form-control bg-soft-dark""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6527, "\"", 6541, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <h3>Weather forecast:</h3>
                    <div class=""row my-center"">
                        <div class=""col-3 form-group"">
                            Slot 1
                            <input name=""WeatherSlot1"" class=""form-control bg-soft-dark""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6884, "\"", 6898, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col-3 form-group\">\r\n                            Slot 2\r\n                            <input name=\"WeatherSlot2\" class=\"form-control bg-soft-dark\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 7116, "\"", 7130, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col-3 form-group\">\r\n                            Slot 3\r\n                            <input name=\"WeatherSlot3\" class=\"form-control bg-soft-dark\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 7348, "\"", 7362, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col form-group\">\r\n                            Slot 4\r\n                            <input name=\"WeatherSlot4\" class=\"form-control bg-soft-dark\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 7578, "\"", 7592, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <h2>Qualifying:</h2>
                    <div class=""row"">
                        <div class=""col-6 form-group"">
                            Qualifying length
                            <input name=""QualifyLength"" class=""form-control bg-soft-dark"" placeholder=""Minutes"" />
                        </div>
                        <div class=""col form-group"">
                            In-Game time for Qualifying
                            <input name=""IGTQualify"" class=""form-control bg-soft-dark""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 8187, "\"", 8201, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <h3>Qualifying Weather Forecast:</h3>
                    <div class=""row my-center"">
                        <div class=""col-3 form-group"">
                            Slot1
                            <input name=""QualWeatherSlot1"" class=""form-control bg-soft-dark""");
                BeginWriteAttribute("placeholder", " placeholder=\"", 8558, "\"", 8572, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col-3 form-group\">\r\n                            Slot2\r\n                            <input name=\"QualWeatherSlot2\" class=\"form-control bg-soft-dark\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 8793, "\"", 8807, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col-3 form-group\">\r\n                            Slot3\r\n                            <input name=\"QualWeatherSlot3\" class=\"form-control bg-soft-dark\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 9028, "\"", 9042, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        </div>\r\n                        <div class=\"col-3 form-group\">\r\n                            Slot4\r\n                            <input name=\"QualWeatherSlot4\" class=\"form-control bg-soft-dark\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 9263, "\"", 9277, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                        </div>
                    </div>
                    <div class=""form-group"">
                        Rules
                        <textarea name=""Rules"" class=""form-control bg-soft-dark"" placeholder=""Rules""></textarea>
                    </div>
                    <div class=""form-group"">
                        Description &Aacute; Additional Information
                        <textarea name=""Description"" class=""form-control bg-soft-dark"" id=""mytextarea"" placeholder=""Description""></textarea>
                    </div>

                    <div class=""form-group"">
                        <input type=""submit"" value=""Create"" class=""btn btn-dark form-control silver-4"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<racesmiths.Models.Club> Html { get; private set; }
    }
}
#pragma warning restore 1591
