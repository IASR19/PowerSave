#pragma checksum "C:\Visual Stuido 17\KipWeb5\Views\Gudstjeneste\_GudstjenesteNy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "310390b4cb6652ce9b7bc7a07690c10b6c9b8d1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gudstjeneste__GudstjenesteNy), @"mvc.1.0.view", @"/Views/Gudstjeneste/_GudstjenesteNy.cshtml")]
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
#line 1 "C:\Visual Stuido 17\KipWeb5\Views\Gudstjeneste\_GudstjenesteNy.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"310390b4cb6652ce9b7bc7a07690c10b6c9b8d1d", @"/Views/Gudstjeneste/_GudstjenesteNy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec4a0d041100f1c7f5b87fd2c1f80209d75b00ee", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Gudstjeneste__GudstjenesteNy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KipWeb5.Models.Gudstjeneste.GudstjenesteModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"panel with-nav-tabs panel-default\" id=\"dataenter\" style=\"height: 480px; margin-bottom: 0px;\">\r\n\r\n        ");
#nullable restore
#line 9 "C:\Visual Stuido 17\KipWeb5\Views\Gudstjeneste\_GudstjenesteNy.cshtml"
    Write(Html.Kendo().Wizard()
            .Name("wizard")
            .Events(ev => ev.Done("LagreNyGudstjeneste"))
            .Tag("form")
            .HtmlAttributes(new { autocomplete = "off" })
            .Steps(s =>
            {
                s.Add<KipWeb5.Models.Gudstjeneste.GudstjenesteModel>()
                    .Title(Localizer["Sokn"].Value)
                    .Form(f => f
                    .Items(items =>
                    {
                        items.Add()
                            .Field(p => p.NyeGudstjenester.SoknId)
                            .Id("GudstjenesteSoknId")
                            .Label(l => l.Text(Localizer["Sokn"].Value + ":"))
                            .InputHtmlAttributes(new { style = "width: 320px;" })
                            .Hint(Localizer["InfoVelgSokn"].Value)
                            .Editor(e => {
                                e.DropDownList()
                                    .DataTextField("SoknNavn")
                                    .DataValueField("SoknId")
                                    .Events(e => e .Select("friskoppSeremonisted").DataBound("sermDataboundSelectFirst"))
                                    .DataSource(source => source
                                        .Ajax()
                                        .Read(read => read.Action("GetAktiveSoknListe", "Sokn"))
                                        );
                            });

                        items.Add()
                            .Name("Seremonisteder")
                            .Id("Seremonisteder")
                            .Field(p => p.NyeGudstjenester.Kirke)
                            .Label(l => l.Text(Localizer["Seremonisted"].Value + ":"))
                            .InputHtmlAttributes(new { style = "width: 320px;" })
                            .Editor(e =>
                            {
                                e.DropDownList()
                                    .Name("KirkeRessursGuid")
                                    .DataTextField("Navn")
                                    .DataValueField("RessursGuid")
                                    .DataSource(source => source
                                        .Ajax()
                                        .Read(read => read.Action("getSeremonisteder", "Ressurs").Data("filterSoknId"))
                                        );
                            });
                    })
                    )
                .Buttons(b =>
                {
                    b.Next().Text(Localizer["Neste"].Value);
                });

                s.Add<KipWeb5.Models.Gudstjeneste.GudstjenesteModel>()
                .Title(Localizer["Gudstjeneste"].Value)
                .Form(f => f
                    .Layout("grid")
                    .Grid(g => g.Cols(2).Gutter(10))
                    .Items(items =>
                    {
                        items.AddGroup()
                            .Label(Localizer["Gudstjeneste"].Value)
                            .Layout("grid")
                            .Grid(g => g.Cols(2).Gutter(10))
                            .Items(items =>
                            {
                                items.Add()
                                .Name("Liturgi")
                                .Field(p => p.NyeGudstjenester.Liturgi)
                                .ColSpan(2)
                                .Label(l => l.Text(Localizer["Liturgi"].Value + ":"))
                                .InputHtmlAttributes(new { style = "width: 320px;" })
                                .Editor(e =>
                                {
                                    e.DropDownList()
                                        .Name("LiturgiGuid")
                                        .DataTextField("Navn")
                                        .DataValueField("LiturgiGuid")
                                        .DataSource(source => source
                                            .Ajax()
                                            .Read(read => read.Action("getLiturgiListe", "Gudstjeneste"))
                                            );
                                });

                                items.Add()
                                .Name("LiturgiType")
                                .Field(p => p.NyeGudstjenester.LiturgiType)
                                .ColSpan(2)
                                .Label(l => l.Text(Localizer["Type (statistikk)"].Value + ":"))
                                .InputHtmlAttributes(new { style = "width: 320px;" })
                                .Editor(e =>
                                {
                                    e.DropDownList()
                                        .Name("LiturgiType")
                                        .DataTextField("Navn")
                                        .DataValueField("LiturgiTypeGuid")
                                        .DataSource(source => source
                                            .Ajax()
                                            .Read(read => read.Action("getLiturgiTypeListe", "Gudstjeneste"))
                                            );
                                });
                            });

                        items.AddGroup()
                          .Label(Localizer["Tidspunkt"].Value)
                          .Layout("grid")
                          .Grid(g => g.Cols(2).Gutter(10))
                          .Items(items =>
                          {
                              items.Add()
                                .Field(p => p.NyeGudstjenester.FraDato)
                                .Label(l => l.Text(Localizer["Dato"].Value + ":"))
                                .ColSpan(1)
                                .InputHtmlAttributes(new { style = "width: 120px;" })
                                .Editor( e =>
                                {
                                    e.DatePicker().Format("dd.MM.yyyy");
                                });

                              items.Add()
                                  .Field(p => p.NyeGudstjenester.Tid)
                                  .Label(l => l.Text(Localizer["Starttidspunkt"].Value + ":"))
                                  .ColSpan(1)
                                  .InputHtmlAttributes(new { style = "width: 120px;" })
                                  .Editor( e =>
                                  {
                                      e.TimePicker().Format("hh:mm");
                                  });

                              items.Add()
                                  .Field(p => p.NyeGudstjenester.Planlagt)
                                  .Label(l => l.Text(Localizer["Sett som planlagt"].Value + ":"))
                                  .ColSpan(1)
                                  .InputHtmlAttributes(new { style = "width: 120px;" })
                                  .Editor(e =>
                                  {
                                      e.RadioGroup()
                                      .Items(i =>
                                      {
                                          i.Add().Label("Ja").Value("1");
                                          i.Add().Label(Localizer["Nei"].Value).Value("0");
                                      })
                                      .Value("1");
                                  });

                              
                          });

                    })
                    )
                    .Buttons(b =>
                    {
                        b.Previous().Text(Localizer["Forrige"].Value);
                        b.Done().Text(Localizer["Opprett"].Value);
                    });

            })
        );

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KipWeb5.Models.Gudstjeneste.GudstjenesteModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
