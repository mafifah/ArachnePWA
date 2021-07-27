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
    [Microsoft.AspNetCore.Components.RouteAttribute("/penawaranBaru")]
    public partial class FormPenawaran : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 380 "D:\Arachne\bzrArachne\Pages\FormPenawaran.razor"
 
    //MODAL
    void CheckboxClicked(DataBarang ItemC, object checkedValue)
    {
        if ((bool)checkedValue)
        {
            if (!datachecked.Contains(ItemC))
            {
                datachecked.Add(ItemC);
            }
        }
        else
        {
            if (datachecked.Contains(ItemC))
            {
                datachecked.Remove(ItemC);
            }
        }
    }
    bool checkedValue { get; set; }
    DateTimeOffset Tanggal { get; set; }
    double _grandtotal { get; set; }
    double _grandDiskon { get; set; }
    double _grandDetil { get; set; }
    bool showModal = false;
    bool showModalBarang = false;
    void ModalShow() => showModal = true;
    void ModalCancel() => showModal = false;

    //
    async void ModalBarangShow()
    {
        divisiBarangs = await AtributService.GetDivisBarang();
        kategoriBarangs = await AtributService.GetkategoriBarang();
        showModal = false;
        showModalBarang = true;
    }

    void ModalBarangCancel() => showModalBarang = false;
    //
    List<M_DivisiBarang> divisiBarangs = new List<M_DivisiBarang>();
    List<M_KategoriBarang> kategoriBarangs = new List<M_KategoriBarang>();
    Random rnd = new Random();
    //filter
    bool showSearchNama = false;
    bool showSearchSatuan = false;
    string SearchNama { get; set; } = "";
    string SearchSatuan { get; set; } = "";
    List<DataBarang> FilteredBarang => _daftarBarang.Where(i => i.Nama.ToLower().Contains(SearchNama) && i.Satuan.ToLower().Contains(SearchSatuan)).ToList();
    List<DataBarang> datachecked { get; set; } = new List<DataBarang>();
    //filter
    private DataUser user = new DataUser();
    private DataBarang Item { get; set; }
    private DataPenawaran dataPenawaran = new DataPenawaran();
    private List<DataBarang> _daftarBarang = new List<DataBarang>();
    List<BarangPenawaran> barangPenawarans = new List<BarangPenawaran>();
    protected override async Task OnInitializedAsync()
    {

        user = DataService.User;
        var Token = DataService.Token;
        if (!String.IsNullOrEmpty(Token))
        {
            Item = DataService._barangDipilih;
            barangPenawarans.Add(new BarangPenawaran
            {
                IdBarang = Item.IdBarang,
                IdDetilPenawaranPembelian = rnd.Next(1, 1000),
                IdSatuan = Item.IdSatuan,
                IdDivisiBarang = Item.IdDivisiBarang,
                IdSubDivisiBarang = Item.IdSubDivisiBarang,
                IdKategoriBarang = Item.IdKategoriBarang,
                IdSubKategoriBarang = Item.IdSubKategoriBarang,
                Satuan = Item.Satuan,
                Nama = Item.Nama,
                Stok = Item.Stok,
                Minimum = Item.Minimum,
                Maksimum = Item.Maksimum,
                CatatanPenawaran = Item.CatatanPenawaran

            });
            var dataBarang = DataService.GetDataBarangWithGroupBy();
            foreach (var value in barangPenawarans)
            {
                await foreach (var item in dataBarang)
                {

                    if (item.Stok <= item.Minimum && item.IdBarang != value.IdBarang)
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

                    }
                }
            }
            this.StateHasChanged();
        }
        else
        {
            NavigationManager.NavigateTo("/");
        }
    }
    void TambahBarangKeList()
    {
        foreach (var data in datachecked)
        {
            barangPenawarans.Add(new BarangPenawaran
            {
                IdBarang = data.IdBarang,
                IdDetilPenawaranPembelian = rnd.Next(1, 1000),
                IdSatuan = data.IdSatuan,
                IdDivisiBarang = data.IdDivisiBarang,
                IdSubDivisiBarang = data.IdSubDivisiBarang,
                IdKategoriBarang = data.IdKategoriBarang,
                IdSubKategoriBarang = data.IdSubKategoriBarang,
                Satuan = data.Satuan,
                Nama = data.Nama,
                Stok = data.Stok,
                Minimum = data.Minimum,
                Maksimum = data.Maksimum

            });
            _daftarBarang.Add(data);
        }
        ModalCancel();
        datachecked.Clear();
    }
    void HapusBarangDariList(BarangPenawaran Item)
    {
        barangPenawarans.Remove(Item);
    }
    void BackToBarang()
    {
        DataService.SetNullBarangDipilih();
        NavigationManager.NavigateTo("dataBarang");
    }
    async Task SendDataPenawaran()
    {
        var check = barangPenawarans.Where(x => x.Stok + x.Jumlah > x.Maksimum || x.Harga == 0 || x.Jumlah == 0).ToList();
        if (check.Count == 0)
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
            Item = null;
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
        else
        {
            ToastService.ShowWarning($" Pastikan Jumlah dan harga Sudah terisi dengan Benar");
        }


    }
    void ShowSearchNama() => showSearchNama = true;
    void RemoveSearchNama() { SearchNama = ""; showSearchNama = false; }
    void ShowSearchSatuan() => showSearchSatuan = true;
    void RemoveSearchSatuan() { SearchSatuan = ""; showSearchSatuan = false; }
    void FormBarangBaru() => NavigationManager.NavigateTo("formPenawaranBarangBaru");

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PenawaranService PenawaranService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AtributService AtributService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataService DataService { get; set; }
    }
}
#pragma warning restore 1591
