#pragma checksum "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6305e74bc36c3ca91da0f892a798a36289f0b870"
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
#line 2 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
using bzrArachne.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/penawaranBaru")]
    public partial class PenawaranBaru : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card card-dark ml-4 mr-4");
            __builder.AddMarkupContent(3, "<div class=\"card-header\"><h2 class=\"card-title\">Form Penawaran</h2></div>\r\n    \r\n    \r\n    ");
            __builder.OpenElement(4, "form");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group row");
            __builder.AddMarkupContent(9, "<label class=\"col-sm-2 col-form-label\">Supplier</label>\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-sm-4");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                              Item.NamaSupplier

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Item.NamaSupplier = __value, Item.NamaSupplier));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.AddMarkupContent(18, "<label class=\"col-sm-1 col-form-label\">Tanggal</label>\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "col-sm-4");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "date");
            __builder.AddAttribute(23, "disabled");
            __builder.AddAttribute(24, "class", "form-control");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                              dataPenawaran.Tanggal

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dataPenawaran.Tanggal = __value, dataPenawaran.Tanggal, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group row");
            __builder.AddMarkupContent(30, "<label class=\"col-sm-2 col-form-label\">Alamat</label>\r\n                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-sm-4");
            __builder.OpenElement(33, "textarea");
            __builder.AddAttribute(34, "type", "text");
            __builder.AddAttribute(35, "class", "form-control");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                 Item.AlamatSupplier

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Item.AlamatSupplier = __value, Item.AlamatSupplier));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        <br>\r\n        <hr>\r\n        \r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "card card-dark");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "card-body");
            __builder.AddMarkupContent(43, "<h4 class=\"card-blue\">Detail Penawaran</h4>\r\n                ");
            __builder.OpenElement(44, "table");
            __builder.AddAttribute(45, "style", "width: 100%");
            __builder.AddAttribute(46, "border", "1");
            __builder.AddMarkupContent(47, @"<thead><tr><th align=""center"" width=""10%""><label for=""Jumlah"">Jumlah</label></th>
                            <th align=""center"" width=""10%""><label for=""Satuan"">Satuan</label></th>
                            <th align=""center"" width=""20%""><label for=""Nama"">Nama Barang</label></th>
                            <th align=""center"" width=""20%""><label for=""Harga"">Harga Satuan</label></th>
                            <th align=""center"" width=""10%""><label for=""DiskonNominal"">Diskon%</label></th>
                            <th align=""center"" width=""10%""><label for=""DiskonDetil"">Diskon Rp.</label></th>
                            <th align=""center"" width=""10%""><label for=""Total"">Total</label></th>
                            <th align=""center"" width=""10%""><label for=""Opsi"">Opsi</label></th></tr></thead>
                    ");
            __builder.OpenElement(48, "tbody");
#nullable restore
#line 56 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                         foreach (var data in ListDataBarang)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(49, "tr");
            __builder.OpenElement(50, "td");
            __builder.OpenElement(51, "div");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "number");
            __builder.AddAttribute(54, "min", "1");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 61 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                                        dataPenawaran.Jumlah

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dataPenawaran.Jumlah = __value, dataPenawaran.Jumlah, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                            ");
            __builder.OpenElement(59, "td");
            __builder.OpenElement(60, "div");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "type", "text");
            __builder.AddAttribute(63, "min", "1");
            __builder.AddAttribute(64, "class", "form-control");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                                      data.Satuan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => data.Satuan = __value, data.Satuan));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                            ");
            __builder.OpenElement(68, "td");
            __builder.OpenElement(69, "div");
            __builder.OpenElement(70, "input");
            __builder.AddAttribute(71, "type", "text");
            __builder.AddAttribute(72, "min", "1");
            __builder.AddAttribute(73, "class", "form-control");
            __builder.AddAttribute(74, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 71 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                                      data.Nama

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => data.Nama = __value, data.Nama));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                            ");
            __builder.OpenElement(77, "td");
            __builder.OpenElement(78, "div");
            __builder.OpenElement(79, "input");
            __builder.AddAttribute(80, "type", "number");
            __builder.AddAttribute(81, "min", "1");
            __builder.AddAttribute(82, "class", "form-control");
            __builder.AddAttribute(83, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 76 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                                        dataPenawaran.Harga

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(84, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dataPenawaran.Harga = __value, dataPenawaran.Harga, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                            ");
            __builder.OpenElement(86, "td");
            __builder.OpenElement(87, "div");
            __builder.OpenElement(88, "input");
            __builder.AddAttribute(89, "type", "number");
            __builder.AddAttribute(90, "min", "1");
            __builder.AddAttribute(91, "class", "form-control");
            __builder.AddAttribute(92, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 81 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                                        dataPenawaran.DiskonNominal

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(93, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dataPenawaran.DiskonNominal = __value, dataPenawaran.DiskonNominal, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                            ");
            __builder.OpenElement(95, "td");
            __builder.OpenElement(96, "div");
            __builder.OpenElement(97, "input");
            __builder.AddAttribute(98, "type", "text");
            __builder.AddAttribute(99, "min", "1");
            __builder.AddAttribute(100, "class", "form-control");
            __builder.AddAttribute(101, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 86 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                                       dataPenawaran.DiskonDetil

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dataPenawaran.DiskonDetil = __value, dataPenawaran.DiskonDetil));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                            ");
            __builder.OpenElement(104, "td");
            __builder.OpenElement(105, "div");
            __builder.OpenElement(106, "input");
            __builder.AddAttribute(107, "type", "number");
            __builder.AddAttribute(108, "min", "1");
            __builder.AddAttribute(109, "class", "form-control");
            __builder.AddAttribute(110, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 91 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                                        totalharga

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(111, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => totalharga = __value, totalharga, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                            ");
            __builder.OpenElement(113, "td");
            __builder.OpenElement(114, "div");
            __builder.OpenElement(115, "button");
            __builder.AddAttribute(116, "class", "btn btn-danger");
            __builder.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                                              (() => HapusBarangDariList(data))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(118, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 100 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                    ");
            __builder.OpenElement(120, "tfoot");
            __builder.OpenElement(121, "tr");
            __builder.OpenElement(122, "td");
            __builder.AddAttribute(123, "align", "right");
            __builder.AddAttribute(124, "colspan", "8");
            __builder.OpenElement(125, "button");
            __builder.AddAttribute(126, "class", "btn btn-success");
            __builder.AddAttribute(127, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                                                                     ModalShow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(128, "<i class=\"oi oi-plus\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "col-sm-4");
            __builder.AddAttribute(132, "style", "text-align: left; font-size: 10px; color: red; margin-left: 150px;");
            __builder.OpenElement(133, "span");
            __builder.AddAttribute(134, "style", "margin-top:0px;");
            __builder.AddContent(135, 
#nullable restore
#line 109 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                   ValidationMesssage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n                ");
            __builder.AddMarkupContent(137, "<div class=\"form-group row\"><label class=\"col-sm-4 col-form-label\">Catatan Penawaran</label></div>\r\n                ");
            __builder.AddMarkupContent(138, "<div class=\"form-group row\"><div class=\"col-sm-4\"><textarea type=\"text\" class=\"form-control\"></textarea></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(139, "\r\n        ");
            __builder.OpenElement(140, "div");
            __builder.AddAttribute(141, "class", "card-footer");
            __builder.OpenElement(142, "button");
            __builder.AddAttribute(143, "type", "button");
            __builder.AddAttribute(144, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                            (() => BackToBarang())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(145, "class", "btn btn-default");
            __builder.AddContent(146, "Batal");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n            ");
            __builder.OpenElement(148, "button");
            __builder.AddAttribute(149, "type", "submit");
            __builder.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 123 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                            (() => SendDataPenawaran())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(151, "class", "btn btn-primary");
            __builder.AddContent(152, "Submit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 129 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
     if (showModal)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(153, "div");
            __builder.AddAttribute(154, "class", "modal fade show");
            __builder.AddAttribute(155, "id", "myModal");
            __builder.AddAttribute(156, "style", "display:block");
            __builder.AddAttribute(157, "aria-modal", "true");
            __builder.AddAttribute(158, "role", "dialog");
            __builder.OpenElement(159, "div");
            __builder.AddAttribute(160, "class", "modal-dialog modal-dialog-scrollable modal-lg");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, "class", "modal-content");
            __builder.AddMarkupContent(163, "<div class=\"modal-header\"><h4 class=\"modal-title\">Barang</h4></div>\r\n                    \r\n                    ");
            __builder.OpenElement(164, "div");
            __builder.AddAttribute(165, "class", "modal-body");
            __builder.OpenElement(166, "table");
            __builder.AddAttribute(167, "id", "example1");
            __builder.AddAttribute(168, "class", "table table-bordered table-striped dataTable dtr-inline");
            __builder.AddAttribute(169, "role", "grid");
            __builder.AddAttribute(170, "aria-describedby", "example1_info");
            __builder.AddMarkupContent(171, "<thead><tr><th> Nama </th>\r\n                                    <th> Satuan </th></tr></thead>\r\n                            ");
            __builder.OpenElement(172, "tbody");
#nullable restore
#line 149 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                 foreach (var ItemBaru in _daftarBarang)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(173, "tr");
            __builder.OpenElement(174, "td");
            __builder.AddContent(175, 
#nullable restore
#line 153 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                             ItemBaru.Nama

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n                                        ");
            __builder.OpenElement(177, "td");
            __builder.AddContent(178, 
#nullable restore
#line 155 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                             ItemBaru.Satuan

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n                                        ");
            __builder.OpenElement(180, "td");
            __builder.OpenElement(181, "a");
            __builder.AddAttribute(182, "tabindex", "_blank");
            __builder.AddAttribute(183, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 157 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                                           (() => TambahBarangKeList(ItemBaru))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(184, "class", "btn btn-block btn-primary btn-sm");
            __builder.AddMarkupContent(185, "\r\n                                                    ADD\r\n                                            ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 162 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(186, "\r\n\r\n                    \r\n                    ");
            __builder.OpenElement(187, "div");
            __builder.AddAttribute(188, "class", "modal-footer");
            __builder.OpenElement(189, "button");
            __builder.AddAttribute(190, "type", "button");
            __builder.AddAttribute(191, "class", "btn");
            __builder.AddAttribute(192, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 169 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                                     ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(193, "Tutup");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 175 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 182 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
       
    //MODAL
    bool showModal = false;
    void ModalShow() => showModal = true;
    void ModalCancel() => showModal = false;

    //MODAL
    private DataUser user = new DataUser();
    List<DataBarang> ListDataBarang = new List<DataBarang>();
    public string ValidationMesssage { get; set; }
    private DataBarang Item { get; set; }
    private DataBarang ItemBaru { get; set; }
    int Jumlah { get; set; } = 0;
    private double totalharga;
    private DataPenawaran dataPenawaran = new DataPenawaran();
    private List<DataBarang> _daftarBarang = new List<DataBarang>();

    void TambahBarangKeList(DataBarang ItemBaru)
    {
        DataService.SetBarangBaruDipilih(ItemBaru);
        ListDataBarang.Add(ItemBaru);
        ModalCancel();
    }

    void HapusBarangDariList(DataBarang Item)
    {
        DataService.SetNullBarangDipilih();
        DataService.SetBarangDipilih(Item);
        ListDataBarang.Remove(Item);
    }
    protected override async Task OnInitializedAsync()
    {
        Item = DataService._barangDipilih;
        ListDataBarang.Add(Item);
        user = DataService.User;
        var Token = DataService.Token;
        if (!String.IsNullOrEmpty(Token))
        {

            var dataBarang = DataService.GetDataBarangWithGroupBy();
            await foreach (var item in dataBarang)
            {
                if(item.Stok <= item.Minimum)
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
            }
        }
        else
        {
            NavigationManager.NavigateTo("/");
        }
    }

    void BackToBarang()
    {
        DataService.SetNullBarangDipilih();
        NavigationManager.NavigateTo("dataBarang");
    }

    async void SendDataPenawaran()
    {
        List<DataBarang> ListDataBarang;
        await Swal.FireAsync("Yeay!!!", "Data Berhasil Disimpan", "success");
        NavigationManager.NavigateTo("dataBarang");
    }
    void HitungHarga()
    {
        //totalharga = Item.Stok * dataPenawaran.Berat;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PenawaranService PenawaranService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataService DataService { get; set; }
    }
}
#pragma warning restore 1591
