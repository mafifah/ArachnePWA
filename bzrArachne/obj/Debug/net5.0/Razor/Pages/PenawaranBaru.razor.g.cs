#pragma checksum "D:\Arachne\bzrArachne\Pages\PenawaranBaru.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8437cd56bf4ec74a0bcaa88871b97751bf0882b3"
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
#line 2 "D:\Arachne\bzrArachne\Pages\PenawaranBaru.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Arachne\bzrArachne\Pages\PenawaranBaru.razor"
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
            __builder.AddMarkupContent(3, "<div class=\"card-header\"><h2 class=\"card-title\">Penawaran Baru</h2></div>\r\n    \r\n    \r\n    ");
            __builder.OpenElement(4, "form");
            __builder.AddMarkupContent(5, @"<div class=""card-body""><div class=""form-group row""><label class=""col-sm-2 col-form-label"" for=""IdKurs"">Kurs</label>
                <div class=""col-sm-4""><input type=""text"" placeholder=""Kurs"" class=""form-control"" name=""IdKurs"" id=""IdKurs""></div></div>
            <div class=""form-group row""><label class=""col-sm-2 col-form-label"" for=""Nama"">Satuan</label>
                <div class=""col-sm-4""><input type=""text"" class=""form-control"" name=""Satuan"" id=""Satuan""></div></div>
            <div class=""form-group row""><label class=""col-sm-2 col-form-label"" for=""Nama"">Nama Barang</label>
                <div class=""col-sm-4""><input type=""text"" class=""form-control"" name=""Nama"" id=""Nama""></div></div>
            <div class=""form-group row""><label class=""col-sm-2 col-form-label"" for=""Jumlah"">Jumlah</label>
                <div class=""col-sm-4""><input type=""number"" placeholder=""Jumlah"" class=""form-control"" name=""Jumlah"" id=""Jumlah""></div></div>
            <div class=""form-group row""><label class=""col-sm-2 col-form-label"" for=""Berat"">Berat</label>
                <div class=""col-sm-4""><input type=""number"" placeholder=""Berat"" class=""form-control"" name=""Berat"" id=""Berat""></div></div>
            <div class=""form-group row""><label class=""col-sm-2 col-form-label"" for=""Berat"">Harga</label>
                <div class=""col-sm-4""><input type=""number"" placeholder=""Harga"" class=""form-control"" name=""Harga"" id=""Harga""></div></div></div>

        
        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-footer");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "D:\Arachne\bzrArachne\Pages\PenawaranBaru.razor"
                                            (()=>BackToBarang())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "btn btn-default");
            __builder.AddContent(12, "Batal");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.AddMarkupContent(14, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "D:\Arachne\bzrArachne\Pages\PenawaranBaru.razor"
       
    protected DataBarang Item { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Item = null;
        Item = DataService._barangDipilih;
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
