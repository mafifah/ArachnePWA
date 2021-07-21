#pragma checksum "D:\Arachne\bzrArachne\Pages\Barang.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b832bccb1f887b814062535092674951ad4b6d9"
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
#line 1 "D:\Arachne\bzrArachne\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Arachne\bzrArachne\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Arachne\bzrArachne\_Imports.razor"
using bzrArachne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Arachne\bzrArachne\_Imports.razor"
using bzrArachne.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Arachne\bzrArachne\_Imports.razor"
using Blazor.AdminLte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Arachne\bzrArachne\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Arachne\bzrArachne\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Arachne\bzrArachne\Pages\Barang.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Arachne\bzrArachne\Pages\Barang.razor"
using bzrArachne.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/dataBarang")]
    public partial class Barang : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<section class=\"content-header\"><div class=\"container-fluid\"><div class=\"row mb-2\"><div class=\"col-sm-6\"><h1>Data Barang</h1></div></div></div></section>\r\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "content");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "d-flex justify-content-between");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-title");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "search");
            __builder.AddAttribute(15, "class", "form-control form-control-sm");
            __builder.AddAttribute(16, "placeholder", "Cari Barang ...");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "D:\Arachne\bzrArachne\Pages\Barang.razor"
                                                          SearchTerm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchTerm = __value, SearchTerm));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-sm-12");
            __builder.AddMarkupContent(24, "<br>\r\n                        ");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "id", "example1");
            __builder.AddAttribute(27, "class", "table table-bordered table-striped dataTable dtr-inline");
            __builder.AddAttribute(28, "role", "grid");
            __builder.AddAttribute(29, "aria-describedby", "example1_info");
            __builder.AddMarkupContent(30, "<thead><tr><th>Nama</th>\r\n                                    <th>Satuan</th>\r\n                                    <th>Stok</th>\r\n                                    <th>Opsi</th></tr></thead>\r\n                            ");
            __builder.OpenElement(31, "tbody");
#nullable restore
#line 38 "D:\Arachne\bzrArachne\Pages\Barang.razor"
                                 foreach (var item in FilteredBarang)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "tr");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 42 "D:\Arachne\bzrArachne\Pages\Barang.razor"
                                             item.Nama

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 43 "D:\Arachne\bzrArachne\Pages\Barang.razor"
                                             if (item.Stok <= item.Minimum)
                                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<i style=\"color:red; padding:8px;\" class=\"fa fa-exclamation-circle\" aria-hidden=\"true\"></i>");
#nullable restore
#line 44 "D:\Arachne\bzrArachne\Pages\Barang.razor"
                                                                                                                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                        ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 46 "D:\Arachne\bzrArachne\Pages\Barang.razor"
                                             item.Satuan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                                        ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 47 "D:\Arachne\bzrArachne\Pages\Barang.razor"
                                             item.Stok

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                        ");
            __builder.OpenElement(43, "td");
#nullable restore
#line 49 "D:\Arachne\bzrArachne\Pages\Barang.razor"
                                             if (item.Stok <= item.Minimum)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "tabindex", "_blank");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "D:\Arachne\bzrArachne\Pages\Barang.razor"
                                                                            (()=>MoveToPenawaran(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "class", "btn btn-block btn-primary btn-sm");
            __builder.AddMarkupContent(48, "\r\n                                                Buat Penawaran\r\n                                            ");
            __builder.CloseElement();
#nullable restore
#line 52 "D:\Arachne\bzrArachne\Pages\Barang.razor"
                                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "D:\Arachne\bzrArachne\Pages\Barang.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "D:\Arachne\bzrArachne\Pages\Barang.razor"
       
    private DataUser user = new DataUser();
    private List<DataBarang> _daftarBarang = new List<DataBarang>();
    DataBarang BarangDipilih = new DataBarang();
    string SearchTerm { get; set; } = "";
    List<DataBarang> FilteredBarang => _daftarBarang.Where(i => i.Nama.ToLower().Contains(SearchTerm)).ToList();
    List<DataBarang> StokBarang => _daftarBarang.Where(i => i.Stok <= i.Minimum).ToList();

    protected override async Task OnInitializedAsync()
    {
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
                    Nama = item.Nama,
                    Satuan = item.Satuan,
                    Stok = item.Stok,
                    Minimum = item.Minimum,
                    Maksimum = item.Maksimum,
                });
                this.StateHasChanged();
            }
            foreach (var item in StokBarang)
            {
                ToastService.ShowWarning($"{item.Nama} dengan satuan {item.Satuan} hampir habis");
            }
        }
        else
        {
            NavigationManager.NavigateTo("/");
        }


    }
    void MoveToPenawaran(DataBarang Item)
    {
        DataService.SetBarangDipilih(Item);
        NavigationManager.NavigateTo("penawaranBaru");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataService DataService { get; set; }
    }
}
#pragma warning restore 1591
