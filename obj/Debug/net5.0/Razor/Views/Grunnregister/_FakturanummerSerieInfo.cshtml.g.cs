#pragma checksum "C:\Visual Stuido 17\KipWeb5\Views\Grunnregister\_FakturanummerSerieInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce4343c9dd8a1ac23aff63abde433c8d2fb253e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Grunnregister__FakturanummerSerieInfo), @"mvc.1.0.view", @"/Views/Grunnregister/_FakturanummerSerieInfo.cshtml")]
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
#line 1 "C:\Visual Stuido 17\KipWeb5\Views\Grunnregister\_FakturanummerSerieInfo.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce4343c9dd8a1ac23aff63abde433c8d2fb253e9", @"/Views/Grunnregister/_FakturanummerSerieInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4a0d041100f1c7f5b87fd2c1f80209d75b00ee", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Grunnregister__FakturanummerSerieInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KipWeb5.Models.Grunnregister.GrunnregisterModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control k-textbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container-fluid padding-0"" id=""FakturanrSerieInfoForm"">
    <div class=""col-12"" style=""margin-bottom: 0px; margin-top: 10px;"">
        <div class=""panel with-nav-tabs panel-default"" id=""dataenter"">
            <div class=""panel-body data padding-0"">
                <div class=""tab-content data"">
                    <div class=""panel-heading"" id=""Tab"">
                        <ul class=""nav nav-tabs"">
                            <li class=""nav-item""><a class=""nav-link active"" aria-current=""page"" href=""#tabInfo"" data-bs-toggle=""tab"">");
#nullable restore
#line 13 "C:\Visual Stuido 17\KipWeb5\Views\Grunnregister\_FakturanummerSerieInfo.cshtml"
                                                                                                                                Write(Localizer["Info"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a></li>
                        </ul>
                    </div>
                    <div class=""panel-body"">
                        <div class=""tab-content"" style=""margin-top: 10px;"">
                            <div class=""tab-pane fade show active"" style=""padding: 10px;"" role=""tabpanel"" id=""tabInfo"">

                                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ce4343c9dd8a1ac23aff63abde433c8d2fb253e95705", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 20 "C:\Visual Stuido 17\KipWeb5\Views\Grunnregister\_FakturanummerSerieInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FakturaSerie.Fellesraad);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                 <div class=\"row align-items-center\" style=\"display: flex; flex-direction: row;\">\r\n                                     <Label class=\"col-3 col-form-label\">");
#nullable restore
#line 22 "C:\Visual Stuido 17\KipWeb5\Views\Grunnregister\_FakturanummerSerieInfo.cshtml"
                                                                    Write(Localizer["Fakturanummer Serie"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                                     <div class=\"col-lg-3\">\r\n");
#nullable restore
#line 24 "C:\Visual Stuido 17\KipWeb5\Views\Grunnregister\_FakturanummerSerieInfo.cshtml"
                                           if (Model != null)
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Visual Stuido 17\KipWeb5\Views\Grunnregister\_FakturanummerSerieInfo.cshtml"
                                            Write(Html.Kendo().NumericTextBox<decimal>()
                                                  .Name("FakturaSerie.FakturaNrSerie")
                                                  .Format("n0")
                                                  .Min(0)
                                                  .Max(100)
                                                  .Value(Model.FakturaSerie.FakturaNrSerie)
                                                  .HtmlAttributes(new { style = "width: 100%"})
                                                );

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Visual Stuido 17\KipWeb5\Views\Grunnregister\_FakturanummerSerieInfo.cshtml"
                                                 
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                    <div class=""col-lg-5"">
                                        Angi 0 dersom du skal opprette en ny
                                    </div>
                                 </div>

                                 <div class=""row align-items-center"" style=""display: flex; flex-direction: row;"">
                                     <label class=""col-3 col-form-label"">Navn</label>
                                     <div class=""col-md-6"">
                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ce4343c9dd8a1ac23aff63abde433c8d2fb253e99974", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 44 "C:\Visual Stuido 17\KipWeb5\Views\Grunnregister\_FakturanummerSerieInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FakturaSerie.Navn);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                     </div>
                                 </div>

                                 <div class=""row align-items-center"" style=""display: flex; flex-direction: row;"">
                                     <label class=""col-3 col-form-label"">Eksport oppsett</label>
                                     <div class=""col-md-6"">
                                        ");
#nullable restore
#line 51 "C:\Visual Stuido 17\KipWeb5\Views\Grunnregister\_FakturanummerSerieInfo.cshtml"
                                    Write(Html.Kendo().DropDownList()
                                            .Name("FakturaSerie.FaktEkspGuid")
                                            .DataTextField("Navn")
                                            .DataValueField("FaktEksp_GUID")
                                            .OptionLabel(Localizer["Velg fra listen ..."].Value)
                                            .OptionLabelTemplate("<span style='color: gray'><i>" + Localizer["Velg fra listen"].Value + " ...</i></span>")
                                            .Value(Model.FakturaSerie.FaktEkspGuid)
                                            .HtmlAttributes(new { style = "width: 100%;" })
                                            .DataSource(dataSource => dataSource
                                                .Ajax()
                                                .Read(read => read.Action("getFakturaSystemerListe", "Grunnregister"))
                                            )
                                        );

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
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KipWeb5.Models.Grunnregister.GrunnregisterModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
