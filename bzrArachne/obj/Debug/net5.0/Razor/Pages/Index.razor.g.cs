#pragma checksum "D:\Arachne\bzrArachne\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c58e7b4f013b87f9c824d026403147aaa6d619fe"
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
#line 3 "D:\Arachne\bzrArachne\Pages\Index.razor"
using bzrArachne.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Arachne\bzrArachne\Pages\Index.razor"
using bzrArachne.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "login-box");
            __builder.AddMarkupContent(2, "<div class=\"login-logo\"><a><b>Arachne</b></a></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body login-card-body");
            __builder.AddMarkupContent(7, "<p class=\"login-box-msg\">Sign in to start your session</p>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "D:\Arachne\bzrArachne\Pages\Index.razor"
                              user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "D:\Arachne\bzrArachne\Pages\Index.razor"
                                                    GetLogin

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "input-group mb-3");
                __builder2.OpenElement(14, "input");
                __builder2.AddAttribute(15, "autofocus", "");
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "placeholder", "Username");
                __builder2.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "D:\Arachne\bzrArachne\Pages\Index.razor"
                                                           user.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserName = __value, user.UserName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                    ");
                __builder2.AddMarkupContent(22, "<div class=\"input-group-append\"><div class=\"input-group-text\"><span class=\"fas fa-user\"></span></div></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "row");
                __builder2.AddAttribute(26, "style", "text-align:left; font-size:10px; color:red; margin-left:-5px;");
                __builder2.OpenElement(27, "span");
                __builder2.AddAttribute(28, "class", "col-lg-12");
                __builder2.AddAttribute(29, "style", "margin-top:-13px;");
                __builder2.AddContent(30, 
#nullable restore
#line 24 "D:\Arachne\bzrArachne\Pages\Index.razor"
                                                                       ValidationMesssage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 26 "D:\Arachne\bzrArachne\Pages\Index.razor"
                 if (ValidationMesssage != null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(31, "<br>");
#nullable restore
#line 29 "D:\Arachne\bzrArachne\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "input-group mb-3");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "password");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "placeholder", "Password");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "D:\Arachne\bzrArachne\Pages\Index.razor"
                                                  user.UserPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserPassword = __value, user.UserPassword));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                    ");
                __builder2.AddMarkupContent(41, "<div class=\"input-group-append\"><div class=\"input-group-text\"><span class=\"fas fa-lock\"></span></div></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "row");
                __builder2.AddMarkupContent(45, "<div class=\"col-4\"><button type=\"submit\" class=\"btn btn-primary btn-block\">Log In</button></div>\r\n                    ");
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "col-8");
                __builder2.OpenElement(48, "label");
                __builder2.AddAttribute(49, "style", "color:red; font-size:12px;");
                __builder2.AddContent(50, 
#nullable restore
#line 44 "D:\Arachne\bzrArachne\Pages\Index.razor"
                             LoginMesssage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "D:\Arachne\bzrArachne\Pages\Index.razor"
       
    private DataUser user = new DataUser();
    public string LoginMesssage { get; set; }
    public string ValidationMesssage { get; set; }
    protected override async Task OnInitializedAsync()
    {
         DataService.GetLogOut();
    }
    private async Task GetLogin()
    {
        if (String.IsNullOrEmpty(user.UserName))
        {
            ValidationMesssage = "Username tidak boleh kosong";
        }
        else
        {
            var currentUser = await DataService.GetLogin(user);
            if (currentUser.Nama != null)
            {
                NavigationManager.NavigateTo("/dataBarang");
                //LoginMesssage = $"Berhasil login IdUser: {currentUser.IdUser} UserName:{currentUser.UserName}";
            }
            else
            {
                LoginMesssage = "Username atau password salah";
            }
        }
        //return await Task.FromResult(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataService DataService { get; set; }
    }
}
#pragma warning restore 1591
