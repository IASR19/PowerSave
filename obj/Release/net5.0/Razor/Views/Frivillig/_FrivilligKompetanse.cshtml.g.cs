#pragma checksum "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32cc4dacc16070068b216e07f749ebf825a4b3b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Frivillig__FrivilligKompetanse), @"mvc.1.0.view", @"/Views/Frivillig/_FrivilligKompetanse.cshtml")]
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
#line 1 "C:\Visual Stuido 17\KipWeb5\Views\_ViewImports.cshtml"
using KipWeb5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Visual Stuido 17\KipWeb5\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32cc4dacc16070068b216e07f749ebf825a4b3b0", @"/Views/Frivillig/_FrivilligKompetanse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4a0d041100f1c7f5b87fd2c1f80209d75b00ee", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Frivillig__FrivilligKompetanse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KipWeb5.Models.Frivillig.FrivilligModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Lagre.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_kompetanse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32cc4dacc16070068b216e07f749ebf825a4b3b05362", async() => {
                WriteLiteral(@"

    <div class=""container-fluid padding-0"" id=""kompetanse_form"">
        <div class=""panel with-nav-tabs panel-default"">
            <div class=""panel-body"">
                <input type=""hidden"" name=""Kompetanse.RessursKompetanseGuid"" class=""form-control k-textbox"">

                <div class=""form-group row"">
                    <div class=""col-lg-2"">
                        <label>");
#nullable restore
#line 15 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
                          Write(Localizer["Dato"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        ");
#nullable restore
#line 18 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
                    Write(Html.Kendo().DatePicker()
                        .Name("Kompetanse.Dato")
                        .HtmlAttributes(new { style = "width: 120px"})
                        );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n\r\n");
                WriteLiteral("\r\n                <div class=\"form-group row\">\r\n                    <div class=\"col-lg-2\">\r\n                        <label>");
#nullable restore
#line 47 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
                          Write(Localizer["Kompetanse"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"col-lg-7\">\r\n                        ");
#nullable restore
#line 50 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
                    Write(Html.Kendo().DropDownList()
                            .Name("Kompetanse.RessursKompetanseGUID")
                            .HtmlAttributes(new { style = "width: calc(100% - 30px);" })
                            .DataTextField("Tittel")
                            .DataValueField("KompetanseGuid")
                            //.Value(Model.Kompetanse.KompetanseGuid)
                            .DataSource(dataSource => dataSource
                                .Ajax()
                                .Read(read => read.Action("Read_Kompetanse", "Foresporsel")
                                )
                            )
                            .AutoBind(false)
                            //.CascadeFrom("kategori")
                        );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"form-group row\">\r\n                    <div class=\"col-lg-2\">\r\n                        <label>");
#nullable restore
#line 69 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
                          Write(Localizer["Tittel"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                    </div>
                    <div class=""col-lg-7"">
                        <input name=""Kompetanse.Tittel"" class=""form-control k-textbox"">
                    </div>
                </div>

                <div class=""form-group row"">
                    <div class=""col-lg-2"">
                        <label>");
#nullable restore
#line 78 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
                          Write(Localizer["Gyldig"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                    <div class=\"col-lg-3\">\r\n                        ");
#nullable restore
#line 81 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
                    Write(Html.Kendo().NumericTextBox<decimal>()
                                    .Name("Kompetanse.Varighet")
                                    .Format("N0")
                                    .Min(0)
                                    .Max(100)
                                    .HtmlAttributes(new { style = "width: 100px", title = "currency" })
                                );

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        <label class=\"form-check-label\" style=\"margin-left: 10px;\">");
#nullable restore
#line 89 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
                                                                              Write(Localizer["Aar"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                    </div>
                </div>

                <div class=""form-group row"">
                    <div class=""col-lg-2""></div>
                    <div class=""col-lg-7"">
                        <div class=""form-check"">
                            ");
#nullable restore
#line 97 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
                        Write(Html.Kendo().CheckBox().Name("Kompetanse.Bekreftet").Label(Localizer["Bekreftet"].Value));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>

    <div class=""col-lg-8""></div>

    <div class=""col-lg-4"">
        <button name=""lagre"" class=""command"" style=""margin-bottom: 0px;"" onclick=""LagreKompetanse()"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32cc4dacc16070068b216e07f749ebf825a4b3b011436", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
#nullable restore
#line 111 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
       Write(Localizer["Lagre"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("Speichern\r\n            <p>");
#nullable restore
#line 112 "C:\Visual Stuido 17\KipWeb5\Views\Frivillig\_FrivilligKompetanse.cshtml"
          Write(Localizer["LagreInfo"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        </button>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
    function filterProducts() {
        var categories = $(""#kategori"").val();

        if (typeof categories == 'undefined') {
            categories = """";
        }

        return {
            kompKategoriGUID: categories
        }
    }
</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KipWeb5.Models.Frivillig.FrivilligModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
