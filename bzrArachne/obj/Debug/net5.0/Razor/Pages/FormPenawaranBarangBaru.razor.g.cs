#pragma checksum "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBarangBaru.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c10062e69ab845c0b74ae34e70ddf99fdf83c93f"
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
#line 15 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\_Imports.razor"
using BlazorNumericTextBox;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBarangBaru.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBarangBaru.razor"
using bzrArachne.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/formPenawaranBarangBaru")]
    public partial class FormPenawaranBarangBaru : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card card-dark ml-4 mr-4");
            __builder.AddMarkupContent(2, "<div class=\"card-header\"><h2 class=\"card-title\">Form Penawaran Barang Baru</h2></div>\r\n    \r\n    \r\n    ");
            __builder.OpenElement(3, "form");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group row");
            __builder.AddMarkupContent(8, "<label class=\"col-sm-2 col-form-label\">Supplier</label>\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-sm-4");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "disabled");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBarangBaru.razor"
                                               user.Nama

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Nama = __value, user.Nama));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBarangBaru.razor"
                  
                    Tanggal = DateTimeOffset.UtcNow.LocalDateTime;
                

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<label class=\"col-sm-1 col-form-label\">Tanggal</label>\r\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-sm-4");
            __builder.OpenElement(20, "input");
            __builder.AddAttribute(21, "disabled");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBarangBaru.razor"
                                           Tanggal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Tanggal = __value, Tanggal));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-group row");
            __builder.AddMarkupContent(28, "<label class=\"col-sm-2 col-form-label\">Alamat</label>\r\n                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-sm-4");
            __builder.OpenElement(31, "textarea");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "disabled");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBarangBaru.razor"
                                                  user.Alamat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Alamat = __value, user.Alamat));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n            <br>\r\n            <hr>\r\n            \r\n            ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "card card-dark");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "card-body");
            __builder.AddMarkupContent(42, "<h4 class=\"card-blue\">Detail Penawaran</h4>\r\n                    ");
            __builder.OpenElement(43, "table");
            __builder.AddAttribute(44, "style", "width: 100%");
            __builder.AddAttribute(45, "border", "1");
            __builder.AddMarkupContent(46, @"<thead><tr><th align=""center"" width=""3%""><label for=""No"">NO</label></th>
                                <th align=""center"" width=""7%""><label for=""Jumlah"">Jml</label></th>
                                <th align=""center"" width=""11%""><label for=""Catatan"">Catatan</label></th>
                                <th align=""center"" width=""10%""><label for=""Satuan"">Satuan</label></th>
                                <th align=""center"" width=""25%""><label for=""Nama"">Nama Barang</label></th>
                                <th align=""center"" width=""10%""><label for=""Harga"">Harga Satuan</label></th>
                                <th align=""center"" width=""5%""><label for=""DiskonNominal"">Diskon%</label></th>
                                <th align=""center"" width=""10%""><label for=""DiskonDetil"">Diskon Rp.</label></th>
                                <th align=""center"" width=""15%""><label for=""Total"">Total</label></th></tr></thead>
                        ");
            __builder.OpenElement(47, "tbody");
#nullable restore
#line 55 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBarangBaru.razor"
                              
                                var no = 1;


#line default
#line hidden
#nullable disable
            __builder.OpenElement(48, "tr");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 60 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBarangBaru.razor"
                                         no

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                    ");
            __builder.AddMarkupContent(52, "<td><div><input type=\"number\" class=\"form-control\"></div></td>\r\n                                    ");
            __builder.AddMarkupContent(53, "<td><div><textarea type=\"text\" class=\"form-control\"></textarea></div></td>\r\n                                    ");
            __builder.AddMarkupContent(54, "<td><div><input type=\"text\" disabled class=\"form-control\"></div></td>\r\n                                    ");
            __builder.AddMarkupContent(55, "<td><div><input type=\"text\" disabled class=\"form-control\"></div></td>\r\n                                    ");
            __builder.AddMarkupContent(56, "<td><div><input type=\"text\" class=\"form-control\"></div></td>\r\n                                    ");
            __builder.AddMarkupContent(57, "<td><div><input type=\"number\" class=\"form-control\"></div></td>\r\n                                    ");
            __builder.AddMarkupContent(58, "<td><div><input type=\"text\" disabled class=\"form-control\"></div></td>\r\n                                    ");
            __builder.AddMarkupContent(59, "<td><div><input type=\"number\" disabled class=\"form-control\"></div></td>");
            __builder.CloseElement();
#nullable restore
#line 107 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBarangBaru.razor"
                                no++;

                            

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                        ");
            __builder.AddMarkupContent(61, "<tfoot><tr><td align=\"right\" colspan=\"10\"><a class=\"btn btn-success rounded-circle\"><i class=\"oi oi-plus\"></i></a></td></tr></tfoot>");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                    ");
            __builder.AddMarkupContent(63, "<div class=\"form-group row\"><label class=\"col-sm-4 col-form-label border-danger\">Catatan Penawaran</label></div>\r\n                    ");
            __builder.AddMarkupContent(64, @"<div class=""form-group row""><div class=""col-sm-4""><textarea type=""text"" class=""form-control""></textarea></div>
                        <div class=""col-sm-8 align-items-end pull-right right right""><label class=""col-sm-4 col-form-label"">Total Penawaran (Rp.) : </label>
                            <input style=""text-align:center"" type=""number"" disabled class=""col-sm-4 col-form-label rounded-pill border border-success""></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.AddMarkupContent(66, "<div class=\"card-footer\"><button type=\"button\" class=\"btn btn-default\">Batal</button>\r\n                <a type=\"submit\" class=\"btn btn-primary\">Submit</a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBarangBaru.razor"
       
    DateTimeOffset Tanggal { get; set; }
    private DataUser user = new DataUser();
    protected override async Task OnInitializedAsync()
    {
        user = DataService.User;
        var Token = DataService.Token;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataService DataService { get; set; }
    }
}
#pragma warning restore 1591
