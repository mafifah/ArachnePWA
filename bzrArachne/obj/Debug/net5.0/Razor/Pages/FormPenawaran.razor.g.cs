#pragma checksum "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59fc700bed2a8a427e8248fd16e311849720d280"
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
#line 1 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using bzrArachne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using bzrArachne.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using Blazor.AdminLte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
using bzrArachne.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/formPenawaran")]
    public partial class FormPenawaran : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card card-dark ml-4 mr-4");
            __builder.AddMarkupContent(3, "<div class=\"card-header\"><h2 class=\"card-title\">Penawaran Baru</h2></div>\r\n    ");
            __builder.OpenElement(4, "form");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group row");
            __builder.AddMarkupContent(9, "<label class=\"col-sm-2 col-form-label\">Barang</label>\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-sm-4");
            __Blazor.bzrArachne.Pages.FormPenawaran.TypeInference.CreateBlazoredTypeahead_0(__builder, 12, 13, 
#nullable restore
#line 19 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                                     AutoSearch

#line default
#line hidden
#nullable disable
            , 14, 
#nullable restore
#line 19 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                                                              Item

#line default
#line hidden
#nullable disable
            , 15, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Item = __value, Item)), 16, () => Item, 17, (context) => (__builder2) => {
                __builder2.AddContent(18, 
#nullable restore
#line 21 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                             context.Nama

#line default
#line hidden
#nullable disable
                );
            }
            , 19, (context) => (__builder2) => {
                __builder2.OpenElement(20, "b");
                __builder2.AddContent(21, 
#nullable restore
#line 24 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                context.Nama

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddContent(22, "-");
                __builder2.AddContent(23, 
#nullable restore
#line 24 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                                  context.Satuan

#line default
#line hidden
#nullable disable
                );
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group row");
            __builder.AddMarkupContent(27, "<label class=\"col-sm-2 col-form-label\">Satuan</label>\r\n                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-sm-4");
            __builder.OpenElement(30, "input");
            __builder.AddAttribute(31, "type", "text");
            __builder.AddAttribute(32, "class", "form-control");
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                              IdSatuan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => IdSatuan = __value, IdSatuan));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-group row");
            __builder.AddMarkupContent(38, "<label class=\"col-sm-2 col-form-label\">Jumlah</label>\r\n                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-sm-4");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "number");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                                Jumlah

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(45, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Jumlah = __value, Jumlah, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.AddMarkupContent(47, "<div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\" for=\"Berat\">Berat</label>\r\n                <div class=\"col-sm-4\"><input type=\"number\" placeholder=\"Berat\" class=\"form-control\" name=\"Berat\" id=\"Berat\"></div></div>\r\n            ");
            __builder.AddMarkupContent(48, "<div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\" for=\"Berat\">Harga</label>\r\n                <div class=\"col-sm-4\"><input type=\"number\" placeholder=\"Harga\" class=\"form-control\" name=\"Harga\" id=\"Harga\"></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        \r\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "card-footer");
            __builder.OpenElement(52, "button");
            __builder.AddAttribute(53, "type", "button");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                            (() => BackToBarang())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "class", "btn btn-default");
            __builder.AddContent(56, "Batal");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "type", "submit");
            __builder.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
                                            (() => SendDataPenawaran())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "class", "btn btn-primary");
            __builder.AddContent(62, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaran.razor"
  
    private DataUser user = new DataUser();
    long IdSatuan;
    public string ValidationMesssage { get; set; }
    int Jumlah { get; set; } = 0;
    protected DataBarang Item { get; set; }
    private List<DataBarang> _daftarBarang = new List<DataBarang>();
    //DataBarang itemdipilih { get; set; }
    protected override async Task OnInitializedAsync()
    {
        Item = DataService._barangDipilih;
        user = DataService.User;
        var Token = DataService.Token;
        if (!String.IsNullOrEmpty(Token))
        {

            var dataBarang = DataService.GetDataBarangWithStream();
            await foreach (var item in dataBarang)
            {
                _daftarBarang.Add(new DataBarang
                {
                    IdBarang = item.IdBarang,
                    IdDivisiBarang = item.IdDivisiBarang,
                    IdSubDivisiBarang = item.IdSubDivisiBarang,
                    IdKategoriBarang = item.IdKategoriBarang,
                    IdSubKategoriBarang = item.IdSubKategoriBarang,
                    IdSupplier = item.IdSupplier,
                    IdJenisSupplier = item.IdJenisSupplier,
                    IdSatuan = item.IdSatuan,
                    Nama = item.Nama,
                    Satuan = item.Satuan,
                    Stok = item.Stok,
                    Minimum = item.Minimum,
                    Maksimum = item.Maksimum,
                });
                this.StateHasChanged();
            }
        }

        else
        {
            NavigationManager.NavigateTo("/");
        }
    }
    private async Task<IEnumerable<DataBarang>> AutoSearch(string searchBarang)
    {
        return await Task.FromResult(_daftarBarang.Where(x => x.Nama.ToLower().Contains(searchBarang.ToLower())).ToList());
    }

    void BarangClicked()
    {
        _daftarBarang.Clear();
    }
    void BackToBarang()
    {
        DataService.SetNullBarangDipilih();
        Item = null;
        NavigationManager.NavigateTo("dataBarang");
    }

    void SendDataPenawaran()
    {

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataService DataService { get; set; }
    }
}
namespace __Blazor.bzrArachne.Pages.FormPenawaran
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateBlazoredTypeahead_0<TItem, TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Func<global::System.String, global::System.Threading.Tasks.Task<global::System.Collections.Generic.IEnumerable<TItem>>> __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TValue> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg5)
        {
        __builder.OpenComponent<global::Blazored.Typeahead.BlazoredTypeahead<TItem, TValue>>(seq);
        __builder.AddAttribute(__seq0, "SearchMethod", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "SelectedTemplate", __arg4);
        __builder.AddAttribute(__seq5, "ResultTemplate", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
