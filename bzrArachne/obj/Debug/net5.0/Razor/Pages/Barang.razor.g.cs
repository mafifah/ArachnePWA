#pragma checksum "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e30229b925559724c6964be3aa21a7c09ef5acc9"
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
#line 1 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using bzrArachne;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using bzrArachne.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using Blazor.AdminLte;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\mafif\source\repos\Arachne\bzrArachne\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
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
#line 25 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
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
#line 41 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
                                 foreach (var item in FilteredBarang)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "tr");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 45 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
                                             item.Nama

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 46 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
                                             if (item.Stok <= item.Minimum)
                                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<i style=\"color:red; padding:8px;\" class=\"fa fa-exclamation-circle\" aria-hidden=\"true\"></i>");
#nullable restore
#line 47 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
                                                                                                                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                        ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 49 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
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
#line 50 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
                                             item.Stok

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                                        ");
            __builder.OpenElement(43, "td");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "type", "button");
            __builder.AddAttribute(46, "class", "btn btn-block btn-primary btn-sm");
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
                                                                                                                (()=>ModalShow(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "\r\n                                                Buat Penawaran\r\n                                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
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
#nullable restore
#line 65 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
     if (showModal)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "modal fade show");
            __builder.AddAttribute(51, "id", "modal-default");
            __builder.AddAttribute(52, "style", "display: block; padding-right: 17px;");
            __builder.AddAttribute(53, "aria-modal", "true");
            __builder.AddAttribute(54, "role", "dialog");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "modal-dialog");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "modal-content");
            __builder.AddMarkupContent(59, "<div class=\"modal-header\"><h4 class=\"modal-title\">Form Penawaran</h4></div>\r\n                    ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "modal-body");
            __builder.OpenElement(62, "form");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "form-group");
            __builder.AddMarkupContent(65, "<label>Nama Barang</label>\r\n                                ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "text");
            __builder.AddAttribute(68, "class", "form-control");
            __builder.AddAttribute(69, "value", 
#nullable restore
#line 77 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
                                                                                BarangDipilih.Nama

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                            ");
            __builder.AddMarkupContent(71, "<div class=\"form-group\"><label>Jumlah Barang</label>\r\n                                <input type=\"text\" class=\"form-control\" placeholder=\"200\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "modal-footer justify-content-between");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "type", "button");
            __builder.AddAttribute(77, "class", "btn btn-default");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
                                                                                 ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(79, "Batal");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                        ");
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "type", "button");
            __builder.AddAttribute(83, "class", "btn btn-primary");
            __builder.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
                                                                                 ModalSubmit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(85, "Simpan");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 92 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\mafif\source\repos\Arachne\bzrArachne\Pages\Barang.razor"
       
    private DataUser user = new DataUser();
    private List<DataBarang> _daftarBarang = new List<DataBarang>();
    DataBarang BarangDipilih = new DataBarang();
    bool showModal = false;
    string SearchTerm { get; set; } = "";
    List<DataBarang> FilteredBarang => _daftarBarang.Where(i => i.Nama.ToLower().Contains(SearchTerm)).ToList();
    List<DataBarang> StokBarang => _daftarBarang.Where(i => i.Stok <= i.Minimum).ToList();

    protected override async Task OnInitializedAsync()
    {
        user = DataService.User;
        var Token = DataService.Token;
        if (!String.IsNullOrEmpty(Token))
        {
            //_daftarBarang = await DataService.GetDataBarang();
            //base.OnInitialized();
            var timer = new System.Threading.Timer((_) =>
            {
                InvokeAsync(async () =>
                {
                    StokBarang.Clear();
                    _daftarBarang = await DataService.GetDataBarang();
                    foreach (var item in StokBarang)
                    {
                        ToastService.ShowWarning($"{item.Nama} dengan satuan {item.Satuan} hampir habis");
                    }
                    StateHasChanged();
                });
            }, null, 0, 5000);

        }
        else
        {
            NavigationManager.NavigateTo("/");
        }
    }

    void ModalShow(DataBarang item)
    {
        BarangDipilih = item;
        showModal = true;

    }
    void ModalCancel() => showModal = false;
    void ModalSubmit()
    {
        Console.WriteLine("Modal ok");
        showModal = false;
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
