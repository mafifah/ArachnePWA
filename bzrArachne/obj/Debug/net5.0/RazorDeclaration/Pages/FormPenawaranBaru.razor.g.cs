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
#line 2 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBaru.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBaru.razor"
using bzrArachne.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/penawaranBarangBaru")]
    public partial class FormPenawaranBaru : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 254 "C:\Users\mafif\source\repos\ArachneGWR\bzrArachne\Pages\FormPenawaranBaru.razor"
       
    //MODAL
    DateTimeOffset Tanggal { get; set; }
    double _grandtotal { get; set; }
    double _grandDiskon { get; set; }
    double _grandDetil { get; set; }
    bool showModal = false;
    bool showModalBarang = false;
    void ModalShow() =>showModal = true;
    void ModalCancel() => showModal = false;
    //
    void ModalBarangShow() => showModalBarang = true;
    void ModalBarangCancel () => showModal = false;
    //
    Random rnd = new Random();
    bool showSearchNama = false;
    bool showSearchSatuan = false;
    string SearchNama { get; set; } = "";
    string SearchSatuan { get; set; } = "";
    List<DataBarang> FilteredBarang => _daftarBarang.Where(i => i.Nama.ToLower().Contains(SearchNama) && i.Satuan.ToLower().Contains(SearchSatuan)).ToList();
    private DataUser user = new DataUser();
    private DataPenawaran dataPenawaran = new DataPenawaran();
    private List<DataBarang> _daftarBarang = new List<DataBarang>();
    List<BarangPenawaran> barangPenawarans = new List<BarangPenawaran>();

    protected override async Task OnInitializedAsync()
    {
        user = DataService.User;
        var Token = DataService.Token;
        if (!String.IsNullOrEmpty(Token))
        {
            var dataBarang = DataService.GetDataBarangWithGroupBy();
            await foreach (var item in dataBarang)
            {
                if (item.Stok <= item.Minimum)
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
        }else
        {
            NavigationManager.NavigateTo("/");
        }

    }

    void TambahBarangKeList(DataBarang ItemBaru)
    {
        barangPenawarans.Add(new BarangPenawaran
        {
            IdBarang = ItemBaru.IdBarang,
            IdDetilPenawaranPembelian = rnd.Next(1, 1000),
            IdSatuan = ItemBaru.IdSatuan,
            IdDivisiBarang = ItemBaru.IdDivisiBarang,
            IdSubDivisiBarang = ItemBaru.IdSubDivisiBarang,
            IdKategoriBarang = ItemBaru.IdKategoriBarang,
            IdSubKategoriBarang = ItemBaru.IdSubKategoriBarang,
            Satuan = ItemBaru.Satuan,
            Nama = ItemBaru.Nama,
            Stok = ItemBaru.Stok,
            Minimum = ItemBaru.Minimum,
            Maksimum = ItemBaru.Maksimum
        });
        _daftarBarang.Remove(ItemBaru);
        ModalCancel();
    }

    void HapusBarangDariList(BarangPenawaran Item)
    {
        DataService.SetNullBarangDipilih();
        barangPenawarans.Remove(Item);
    }
    void BackToBarang()
    {
        DataService.SetNullBarangDipilih();
        NavigationManager.NavigateTo("dataBarang");
    }

    async void SendDataPenawaran()
    {
        dataPenawaran = new DataPenawaran
        {
            IdPenawaranPembelian = rnd.Next(1, 1000),
            IdJenisSupplier = user.IdJenisSupplier,
            IdSupplier = user.IdSupplier,
            IdCompanyPenerima = "GWR",
            BarangPenawaran = barangPenawarans,
            GrandTotal = _grandtotal,
            DiskonDetil = _grandDetil.ToString(),
            DiskonNominal = _grandDiskon
        };
        var send = await PenawaranService.InsertDataRepeated(dataPenawaran);
        DataService.SetNullBarangDipilih();
        barangPenawarans.Clear();
        dataPenawaran = null;
        if (send)
        {
            await Swal.FireAsync(
             "Sukses",
             "Data Penawaran Berhasil terkirim :)",
             SweetAlertIcon.Success
             );
            NavigationManager.NavigateTo("dataBarang");
        }
        else
        {
            await Swal.FireAsync(
            "Gagal",
            "Data Penawaran gagal terkirim :)",
            SweetAlertIcon.Error
            );
        }

    }
    void ShowSearchNama() => showSearchNama = true;
    void RemoveSearchNama() { SearchNama = ""; showSearchNama = false; }
    void ShowSearchSatuan() => showSearchSatuan = true;
    void RemoveSearchSatuan() { SearchSatuan = ""; showSearchSatuan = false; }

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
