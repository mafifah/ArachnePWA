#pragma checksum "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "006cb6a6601c51e4e3310dd344cbdc0010b90c83"
// <auto-generated/>
#pragma warning disable 1591
namespace bzrArachne.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using bzrArachne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using bzrArachne.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using Blazor.AdminLte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
using bzrArachne.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/formPenawaran")]
    public partial class FormPenawaran : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card card-dark ml-4 mr-4");
            __builder.AddMarkupContent(3, "<div class=\"card-header\"><h2 class=\"card-title\">Penawaran Baru</h2></div>\r\n    ");
            __builder.OpenElement(4, "form");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "<div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\" for=\"IdKurs\">Kurs</label>\r\n                <div class=\"col-sm-4\"><input type=\"text\" placeholder=\"Kurs\" class=\"form-control\" name=\"IdKurs\" id=\"IdKurs\"></div></div>\r\n            ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group row");
            __builder.AddMarkupContent(10, "<label class=\"col-sm-2 col-form-label\">Satuan</label>\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-sm-4");
            __builder.OpenElement(13, "select");
            __builder.AddAttribute(14, "class", "form-control");
#nullable restore
#line 24 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                         foreach (var item in _daftarBarang)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "option");
            __builder.AddAttribute(16, "value", 
#nullable restore
#line 26 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                            item.Satuan

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(17, 
#nullable restore
#line 26 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                                          item.Satuan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group row");
            __builder.AddMarkupContent(21, "<label class=\"col-sm-2 col-form-label\">Nama Barang</label>\r\n                ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-sm-4");
            __builder.OpenElement(24, "select");
            __builder.AddAttribute(25, "class", "form-control");
#nullable restore
#line 35 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                         foreach (var item in _daftarBarang)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", 
#nullable restore
#line 37 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                            item.IdBarang

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, 
#nullable restore
#line 37 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                                            item.Nama

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group row");
            __builder.AddMarkupContent(32, "<label class=\"col-sm-2 col-form-label\">Jumlah</label>\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-sm-4");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "number");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                                Jumlah

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Jumlah = __value, Jumlah, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n            ");
            __builder.AddMarkupContent(41, "<div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\" for=\"Berat\">Berat</label>\r\n                <div class=\"col-sm-4\"><input type=\"number\" placeholder=\"Berat\" class=\"form-control\" name=\"Berat\" id=\"Berat\"></div></div>\r\n            ");
            __builder.AddMarkupContent(42, "<div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\" for=\"Berat\">Harga</label>\r\n                <div class=\"col-sm-4\"><input type=\"number\" placeholder=\"Harga\" class=\"form-control\" name=\"Harga\" id=\"Harga\"></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "  \r\n        \r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "card-footer");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                            (()=>BackToBarang())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "class", "btn btn-default");
            __builder.AddContent(50, "Batal");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.AddMarkupContent(52, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
       
    public string ValidationMesssage { get; set; }
    int Jumlah { get; set; } = 0;
    protected DataBarang Item { get; set; }
    private List<DataBarang> _daftarBarang = new List<DataBarang>();

    protected override async Task OnInitializedAsync()
    {
        
        Item = DataService._barangDipilih;
        _daftarBarang = await DataService.GetDataBarang();
    }

    void BackToBarang()
    {
        DataService.SetNullBarangDipilih();
        Item = null;
        NavigationManager.NavigateTo("dataBarang");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataService DataService { get; set; }
    }
}
#pragma warning restore 1591
