#pragma checksum "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e55545c00fb87993b122b69cf652508ae22e72c"
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
#line 2 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
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
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group row");
            __builder.AddMarkupContent(9, "<label class=\"col-sm-2 col-form-label\">Nama Barang</label>\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-sm-4");
#nullable restore
#line 17 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                     if (Item != null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 19 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                                                   Item.Nama

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(15, "class", "form-control");
            __builder.AddAttribute(16, "name", "Nama");
            __builder.AddAttribute(17, "id", "Nama");
            __builder.CloseElement();
#nullable restore
#line 20 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "select");
            __builder.AddAttribute(19, "class", "form-control");
#nullable restore
#line 24 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                             foreach (var item in _daftarBarang)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", 
#nullable restore
#line 26 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                                                item.IdBarang

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, 
#nullable restore
#line 26 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                                                                item.Nama

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 29 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group row");
            __builder.AddMarkupContent(26, "<label class=\"col-sm-2 col-form-label\">Satuan</label>\r\n                ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "col-sm-4");
#nullable restore
#line 35 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                     if (Item != null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "text");
            __builder.AddAttribute(31, "value", 
#nullable restore
#line 37 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                                                   Item.Satuan

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "class", "form-control");
            __builder.CloseElement();
#nullable restore
#line 38 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "select");
            __builder.AddAttribute(34, "class", "form-control");
#nullable restore
#line 42 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                             foreach (var item in _daftarBarang)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", 
#nullable restore
#line 44 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                                                item.Satuan

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, 
#nullable restore
#line 44 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                                                              item.Satuan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 45 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 47 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.AddMarkupContent(39, "<div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\">Jumlah</label>\r\n                <div class=\"col-sm-4\"><input type=\"text\" class=\"form-control\"></div></div>\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-sm-4");
            __builder.AddAttribute(42, "style", "text-align: left; font-size: 10px; color: red; margin-left: 150px;");
            __builder.OpenElement(43, "span");
            __builder.AddAttribute(44, "style", "margin-top:0px;");
            __builder.AddContent(45, 
#nullable restore
#line 57 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                                               ValidationMesssage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            ");
            __builder.AddMarkupContent(47, "<div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\">Harga</label>\r\n                <div class=\"col-sm-4\"><input type=\"text\" class=\"form-control\"></div></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "  \r\n        \r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "card-footer");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
                                            (()=>BackToBarang())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(54, "class", "btn btn-default");
            __builder.AddContent(55, "Batal");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.AddMarkupContent(57, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
       
    public string ValidationMesssage { get; set; }
    protected DataBarang Item { get; set; }
    private List<DataBarang> _daftarBarang = new List<DataBarang>();

    protected override async Task OnInitializedAsync()
    {
        //ValidationMesssage = "Jumlah barang melebihi stok maksimum";
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
