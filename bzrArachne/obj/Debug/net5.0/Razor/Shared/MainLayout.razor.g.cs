#pragma checksum "D:\Arachne\bzrArachne\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2131ca5408aaae8b6110b48d91d524635488a50"
// <auto-generated/>
#pragma warning disable 1591
namespace bzrArachne.Shared
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
#line 16 "D:\Arachne\bzrArachne\_Imports.razor"
using BlazorNumericTextBox;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
using bzrArachne.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
using Blazored.Toast.Configuration;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Blazor.AdminLte.NavBar>(0);
            __builder.AddAttribute(1, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazor.AdminLte.NavBarLeft>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 12 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
         if (!navBarLeftInjectableMenu.OverrideParentContent)
        { }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(4, 
#nullable restore
#line 14 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
         navBarLeftInjectableMenu.content

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Blazor.AdminLte.NavBarRight>(6);
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazor.AdminLte.NavBarDropDown>(8);
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(10, "<a href=\"/\" class=\"btn btn-block btn-danger btn-sm\" b-swioexuvpg>Log Out</a>");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenComponent<Blazor.AdminLte.SideBarContainer>(12);
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazor.AdminLte.BrandLogo>(14);
                __builder2.AddAttribute(15, "Link", "https://adminlte.io/");
                __builder2.AddAttribute(16, "Logo", "../dist/img/AdminLTELogo.png");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "Arachne");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenComponent<Blazor.AdminLte.SideBar>(20);
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Blazor.AdminLte.SideBarUserPanel>(22);
                    __builder3.AddAttribute(23, "ImageEffect", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor.AdminLte.ImageEffect>(
#nullable restore
#line 26 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
                                       ImageEffect.Circle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "Link", "starter-pages/user-page");
                    __builder3.AddAttribute(25, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazor.AdminLte.Elevation>(
#nullable restore
#line 26 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
                                                                                                     Elevation.Three

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(26, "UserImage", "../dist/img/user2-160x160.jpg");
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(28, 
#nullable restore
#line 26 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
                                                                                                                                                                 user.Nama

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n    ");
                    __builder3.OpenComponent<Blazor.AdminLte.SideBarMenu>(30);
                    __builder3.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<Blazor.AdminLte.SideBarMenuItem>(32);
                        __builder4.AddAttribute(33, "Link", "dataBarang");
                        __builder4.AddAttribute(34, "Icon", "fas fa-th");
                        __builder4.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(36, "\r\n            Data Barang\r\n        ");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.OpenComponent<Blazor.AdminLte.ContentWrapper>(38);
            __builder.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Blazored.Toast.BlazoredToasts>(40);
                __builder2.AddAttribute(41, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.Configuration.ToastPosition>(
#nullable restore
#line 36 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
                              ToastPosition.BottomRight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "Timeout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 37 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
                             2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "IconType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazored.Toast.IconType?>(
#nullable restore
#line 38 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
                              IconType.FontAwesome

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "SuccessClass", "success-toast-override");
                __builder2.AddAttribute(45, "SuccessIcon", "fa fa-thumbs-up");
                __builder2.AddAttribute(46, "ErrorIcon", "fa fa-bug");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudThemeProvider>(48);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDialogProvider>(50);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudSnackbarProvider>(52);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.AddContent(54, 
#nullable restore
#line 45 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
     Body

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
       
    private DataUser user = new DataUser();
    protected override async Task OnInitializedAsync()
    {
        user = DataService.User;
    }
    void MoveToFormPenawaran()
    {
        DataService.SetNullBarangDipilih();
        NavigationManager.NavigateTo("penawaranBaru");
    }
    protected override void OnParametersSet()
    {
        // content = null; for refreshing custom menu injectables per page.
        // no override; reset default to show parent menu content items.
        navBarLeftInjectableMenu.SetContent(null, false);
    }

    private DateTime dt = DateTime.Now;

    private void SeeAllMessages(Tuple<IDropdownFooter, MouseEventArgs> args)
    {
        NavigationManager.NavigateTo("messages/see-all-messages");
    }

    private void HandleContent(Tuple<INavBarMenuItem, MouseEventArgs> args)
    {
        NavigationManager.NavigateTo("messages/see-all-messages");
    }

    private void SeeAllNotifications(Tuple<IDropdownFooter, MouseEventArgs> args)
    {
        NavigationManager.NavigateTo("messages/see-all-notifications");
    }

    protected override void OnAfterRender(bool isFirstRender)
    {
        layoutManager.IsFooterFixed = true;
        layoutManager.IsNavBarFixed = true;
        layoutManager.IsSideBarFixed = true;
        base.OnAfterRender(isFirstRender);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataService DataService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavBarLeftInjectableMenu navBarLeftInjectableMenu { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILayoutManager layoutManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
