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
#line 14 "D:\Arachne\bzrArachne\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Arachne\bzrArachne\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Arachne\bzrArachne\Pages\Barang.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Arachne\bzrArachne\Pages\Barang.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Arachne\bzrArachne\Pages\Barang.razor"
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
#line 117 "D:\Arachne\bzrArachne\Pages\Barang.razor"
       
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
    //List<DataBarang> StokBarang => FilteredBarang.Where(i => i.Stok <= i.Minimum).ToList();
    private NotificationMessages notificationMessage = new NotificationMessages();
    protected override async Task OnInitializedAsync()
    {
        user = DataService.User;
        var Token = DataService.Token;
        if (!String.IsNullOrEmpty(Token))
        {
            await GetBarang();
            var hubConnection = new HubConnectionBuilder().WithUrl(NavigationManager.ToAbsoluteUri("/notified")).Build();
            hubConnection.On<string>("ReceiveMessage", (msg) =>
            {
                notificationMessage.Msg = msg;
                StateHasChanged();
                GetDataById();
            });
            await hubConnection.StartAsync();
            var IsConnected = hubConnection.State;
        }
        else
        {
            NavigationManager.NavigateTo("/");
        }
    }

    async Task GetBarang()
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
        //foreach (var item in StokBarang)
        //{
        //    ToastService.ShowWarning($"{item.Nama} dengan satuan {item.Satuan} hampir habis");
        //}
    }

    async Task GetDataById()
    {
        var dataBarang = DataService.GetDataById(notificationMessage.Msg);
        await foreach (var item in dataBarang)
        {
            var data = _daftarBarang.Where(i => i.IdBarang == item.IdBarang && i.IdSatuan == item.IdSatuan).FirstOrDefault();
            data.Stok = item.Stok;
            StateHasChanged();
            if (data.Stok <= data.Minimum)
            {
                ToastService.ShowWarning($"{item.Nama} dengan satuan {item.Satuan} hampir habis");
            }
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
    void MoveToPenawaranBarangBaru()
    {
        NavigationManager.NavigateTo("penawaranBarangBaru");
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
