// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
