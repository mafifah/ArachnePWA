<<<<<<< HEAD
#pragma checksum "D:\Arachne\bzrArachne\Pages\PenawaranBaru.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2efe949c8653e162d5735a71a9da3644419bf79b"
=======
<<<<<<< HEAD
#pragma checksum "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2444a8fd1fa65677a07078c119e2d5aebf978f67"
=======
#pragma checksum "D:\Arachne\bzrArachne\Pages\PenawaranBaru.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2444a8fd1fa65677a07078c119e2d5aebf978f67"
>>>>>>> dd807e4debb88313e1d9187373f3b81276ed0fc2
>>>>>>> 3959f621c121a0e78e9b001edd842e61a0aa78e8
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
#line 2 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
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
<<<<<<< HEAD
            __builder.AddMarkupContent(1, "<div class=\"card card-primary ml-4 mr-4\"><div class=\"card-header\"><h2 class=\"card-title\">Penawaran Baru</h2></div>\r\n    \r\n    \r\n    <form><div class=\"card-body\"><div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\" for=\"IdKurs\">Kurs</label>\r\n                <div class=\"col-sm-4\"><input type=\"text\" placeholder=\"Kurs\" class=\"form-control\" name=\"IdKurs\" id=\"IdKurs\"></div></div>\r\n            <div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\" for=\"Nama\">Satuan</label>\r\n                <div class=\"col-sm-4\"><input type=\"text\" class=\"form-control\" name=\"Satuan\" id=\"Satuan\"></div></div>\r\n            <div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\" for=\"Nama\">Nama Barang</label>\r\n                <div class=\"col-sm-4\"><input type=\"text\" class=\"form-control\" name=\"Nama\" id=\"Nama\"></div></div>\r\n            <div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\" for=\"Jumlah\">Jumlah</label>\r\n                <div class=\"col-sm-4\"><input type=\"number\" placeholder=\"Jumlah\" class=\"form-control\" name=\"Jumlah\" id=\"Jumlah\"></div></div>\r\n            <div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\" for=\"Berat\">Berat</label>\r\n                <div class=\"col-sm-4\"><input type=\"number\" placeholder=\"Berat\" class=\"form-control\" name=\"Berat\" id=\"Berat\"></div></div>\r\n            <div class=\"form-group row\"><label class=\"col-sm-2 col-form-label\" for=\"Berat\">Harga</label>\r\n                <div class=\"col-sm-4\"><input type=\"number\" placeholder=\"Harga\" class=\"form-control\" name=\"Harga\" id=\"Harga\"></div></div></div>\r\n           \r\n        \r\n        <div class=\"card-footer\"><button type=\"submit\" class=\"btn btn-primary\">Submit</button></div></form></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 63 "D:\Arachne\bzrArachne\Pages\PenawaranBaru.razor"
=======
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card card-primary ml-4 mr-4");
            __builder.AddMarkupContent(3, "<div class=\"card-header\"><h2 class=\"card-title\">Penawaran Baru</h2></div>\r\n    \r\n    \r\n    ");
            __builder.OpenElement(4, "form");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
#nullable restore
#line 17 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
             if (Item != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group row");
            __builder.AddMarkupContent(9, "<label class=\"col-sm-2 col-form-label\" for=\"Nama\">Nama Barang</label>\r\n                    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-sm-4");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "type", "text");
            __builder.AddAttribute(14, "class", "form-control");
            __builder.AddAttribute(15, "name", "Nama");
            __builder.AddAttribute(16, "id", "Nama");
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                   Item.Nama

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Item.Nama = __value, Item.Nama));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group row");
            __builder.AddMarkupContent(22, "<label class=\"col-sm-2 col-form-label\" for=\"Nama\">Satuan</label>\r\n                    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "col-sm-4");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "text");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "name", "Satuan");
            __builder.AddAttribute(29, "id", "Satuan");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                   Item.Satuan

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Item.Satuan = __value, Item.Satuan));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group row");
            __builder.AddMarkupContent(35, "<label class=\"col-sm-2 col-form-label\" for=\"Stok\">Stok</label>\r\n                    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-sm-4");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "number");
            __builder.AddAttribute(40, "class", "form-control");
            __builder.AddAttribute(41, "id", "Stok");
            __builder.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
                                                     Item.Stok

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Item.Stok = __value, Item.Stok, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "<label class=\"col-sm-2 col-form-label\" for=\"Nama\">Satuan</label>");
#nullable restore
#line 41 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n           \r\n        \r\n        ");
            __builder.AddMarkupContent(46, "<div class=\"card-footer\"><button type=\"submit\" class=\"btn btn-primary\">Submit</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 52 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\PenawaranBaru.razor"
=======
#line 52 "D:\Arachne\bzrArachne\Pages\PenawaranBaru.razor"
>>>>>>> dd807e4debb88313e1d9187373f3b81276ed0fc2
>>>>>>> 3959f621c121a0e78e9b001edd842e61a0aa78e8
       
    protected DataBarang Item { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Item = null;
        Item = DataService._barangDipilih;
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataService DataService { get; set; }
    }
}
#pragma warning restore 1591
