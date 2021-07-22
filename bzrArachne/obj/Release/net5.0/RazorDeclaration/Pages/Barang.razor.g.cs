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
#line 2 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\mafif\Source\Repos\ArachneGWR\bzrArachne\Pages\Barang.razor"
       
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
