// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "D:\Arachne\bzrArachne\Shared\MainLayout.razor"
       
    private DataUser user = new DataUser();
    protected override async Task OnInitializedAsync()
    {
        user = DataService.User;
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
