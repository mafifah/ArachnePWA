#pragma checksum "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db9370e836901912cbd874562203a958b4db9474"
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
#line 2 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
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
            __builder.AddAttribute(10, "class", "row");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-sm-12");
            __builder.AddMarkupContent(13, "<br>\r\n                        ");
            __builder.OpenElement(14, "table");
            __builder.AddAttribute(15, "id", "example1");
            __builder.AddAttribute(16, "class", "table table-bordered table-striped dataTable dtr-inline");
            __builder.AddAttribute(17, "role", "grid");
            __builder.AddAttribute(18, "aria-describedby", "example1_info");
            __builder.OpenElement(19, "thead");
            __builder.OpenElement(20, "tr");
            __builder.OpenElement(21, "th");
            __builder.AddMarkupContent(22, "\r\n                                        Nama\r\n                                        ");
            __builder.OpenElement(23, "a");
            __builder.AddAttribute(24, "type", "button");
            __builder.AddAttribute(25, "style", "float:right");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                                                        ShowSearchNama

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "<i class=\"fas fa-angle-down\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                    ");
            __builder.OpenElement(29, "th");
            __builder.AddMarkupContent(30, "\r\n                                        Satuan\r\n                                        ");
            __builder.OpenElement(31, "a");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "style", "float:right");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                                                        ShowSearchSatuan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "<i class=\"fas fa-angle-down\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                    ");
            __builder.OpenElement(37, "th");
            __builder.AddMarkupContent(38, "\r\n                                        Stok\r\n                                        ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "style", "float:right");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                                                        ShowSearchStok

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(43, "<i class=\"fas fa-angle-down\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                    ");
            __builder.AddMarkupContent(45, "<th>Opsi</th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.OpenElement(47, "tbody");
            __builder.OpenElement(48, "tr");
#nullable restore
#line 49 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                     if (showSearchNama)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "td");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "input-group mb-3");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "class", "form-control");
            __builder.AddAttribute(55, "placeholder", "Cari Barang ...");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 53 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                                                SearchNama

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchNama = __value, SearchNama));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "input-group-append");
            __builder.OpenElement(61, "a");
            __builder.AddAttribute(62, "type", "button");
            __builder.AddAttribute(63, "class", "input-group-text btn-danger");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                                                                                    RemoveSearchNama

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "X");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                     if (showSearchSatuan)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(66, "td");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "input-group mb-3");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "type", "text");
            __builder.AddAttribute(71, "class", "form-control");
            __builder.AddAttribute(72, "placeholder", "Cari Satuan ...");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 64 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                                                SearchSatuan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchSatuan = __value, SearchSatuan));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                                ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "input-group-append");
            __builder.OpenElement(78, "a");
            __builder.AddAttribute(79, "type", "button");
            __builder.AddAttribute(80, "class", "input-group-text btn-danger");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                                                                                    RemoveSearchSatuan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(82, "X");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                     if (showSearchStok)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(83, "td");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "input-group mb-3");
            __builder.OpenElement(86, "input");
            __builder.AddAttribute(87, "type", "number");
            __builder.AddAttribute(88, "class", "form-control");
            __builder.AddAttribute(89, "placeholder", "Cari Stok ...");
            __builder.AddAttribute(90, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                                                  SearchStok

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(91, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchStok = __value, SearchStok, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                                                ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "input-group-append");
            __builder.OpenElement(95, "a");
            __builder.AddAttribute(96, "type", "button");
            __builder.AddAttribute(97, "class", "input-group-text btn-danger");
            __builder.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                                                                                    RemoveSearchStok

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(99, "X");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 81 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 83 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                 foreach (var item in FilteredBarang)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(100, "tr");
            __builder.OpenElement(101, "td");
            __builder.AddContent(102, 
#nullable restore
#line 87 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                             item.Nama

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 88 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                             if (item.Stok <= item.Minimum)
                                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(103, "<i style=\"color:red; padding:8px;\" class=\"fa fa-exclamation-circle\" aria-hidden=\"true\"></i>");
#nullable restore
#line 89 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                                                                                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n                                        ");
            __builder.OpenElement(105, "td");
            __builder.AddContent(106, 
#nullable restore
#line 91 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                             item.Satuan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                                        ");
            __builder.OpenElement(108, "td");
            __builder.AddContent(109, 
#nullable restore
#line 92 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                             item.Stok

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                                        ");
            __builder.OpenElement(111, "td");
#nullable restore
#line 94 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                             if (item.Stok <= item.Minimum)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(112, "a");
            __builder.AddAttribute(113, "tabindex", "_blank");
            __builder.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                                            (() => MoveToPenawaran(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(115, "class", "btn btn-block btn-primary btn-sm");
            __builder.AddMarkupContent(116, "\r\n                                                    Buat Penawaran\r\n                                                ");
            __builder.CloseElement();
#nullable restore
#line 97 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
                                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 100 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
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
#line 109 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
       
    private DataUser user = new DataUser();
    private List<DataBarang> _daftarBarang = new List<DataBarang>();
    DataBarang BarangDipilih = new DataBarang();
    string SearchNama { get; set; } = "";
    string SearchSatuan { get; set; } = "";
    int SearchStok { get; set; } = 1000;
    bool showSearchNama = false;
    bool showSearchSatuan = false;
    bool showSearchStok = false;
    List<DataBarang> FilteredBarang => _daftarBarang.Where(i => i.Nama.ToLower().Contains(SearchNama) && i.Satuan.ToLower().Contains(SearchSatuan) && i.Stok <= SearchStok).ToList();
    List<DataBarang> StokBarang => FilteredBarang.Where(i => i.Stok <= i.Minimum).ToList();
    protected override async Task OnInitializedAsync()
    {
        user = DataService.User;
        var Token = DataService.Token;
        if (!String.IsNullOrEmpty(Token))
        {
            var dataBarang = DataService.GetDataBarangWithGroupBy();
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
                    NamaSupplier = item.NamaSupplier
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
    void ShowSearchNama() => showSearchNama = true;
    void RemoveSearchNama() { SearchNama = ""; showSearchNama = false; }
    void ShowSearchSatuan() => showSearchSatuan = true;
    void RemoveSearchSatuan() { SearchSatuan = ""; showSearchSatuan = false; }
    void ShowSearchStok() => showSearchStok = true;
    void RemoveSearchStok() { SearchStok = 1000; showSearchStok = false; }
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
