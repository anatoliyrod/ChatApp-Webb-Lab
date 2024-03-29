#pragma checksum "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor" "{8829d00f-11b8-4213-878b-770e8597ac16}" "abbfab53c96c4462b273c1f9a48f5692214e10f39a0f12949949e0f2b4dd8093"
// <auto-generated/>
#pragma warning disable 1591
namespace Chatty.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Chatty;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrator\Desktop\signalr-blazorserver\_Imports.razor"
using Chatty.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
using Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase, IAsyncDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container overflow-auto shadow-sm p-3 mb-5 bg-white rounded");
            __builder.AddAttribute(2, "style", "height: 500px;");
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
     if (!userMessages.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p>No messages yet, start chatting!</p>");
#nullable restore
#line 11 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
     foreach (var userMessage in userMessages)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row" + " mb-3" + " d-flex" + " " + (
#nullable restore
#line 15 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
                                      userMessage.CurrentUser ? "justify-content-end" : ""

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card" + " shadow" + " " + (
#nullable restore
#line 16 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
                                      userMessage.CurrentUser ? "color-green mr-5" : "ml-5"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "style", "width: 18rem;");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-header");
#nullable restore
#line 18 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
__builder.AddContent(11, userMessage.CurrentUser ? "You" : userMessage.Username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "list-group list-group-flush");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "list-group-item" + " " + (
#nullable restore
#line 21 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
                                                 userMessage.CurrentUser ? "color-green" : ""

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 21 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
__builder.AddContent(17, userMessage.Message);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-footer");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "class", "small");
#nullable restore
#line 24 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
__builder.AddContent(23, userMessage.DateSent.ToString("HH:mm | MMM dd"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "container");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "col-3");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "text");
            __builder.AddAttribute(33, "class", "form-control");
            __builder.AddAttribute(34, "placeholder", "Your name");
            __builder.AddAttribute(35, "readonly", 
#nullable restore
#line 34 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
                                                                                                             isUserReadonly

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
                          usernameInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => usernameInput = __value, usernameInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-6");
            __builder.OpenElement(41, "textarea");
            __builder.AddAttribute(42, "class", "form-control");
            __builder.AddAttribute(43, "placeholder", "Start typing...");
            __builder.AddAttribute(44, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
                             messageInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => messageInput = __value, messageInput));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "col-3");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
                                            Send

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "disabled", 
#nullable restore
#line 40 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
                                                              !IsConnected

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(53, "class", "btn btn-primary");
            __builder.AddContent(54, "Send");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Administrator\Desktop\signalr-blazorserver\Pages\Index.razor"
      
    private HubConnection hubConnection;
    private List<UserMessage> userMessages = new();
    private string usernameInput;
    private string messageInput;
    private bool isUserReadonly = false;

    public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

    protected override async Task OnInitializedAsync()
    {
        hubConnection = new HubConnectionBuilder()
            .WithUrl(NavigationManager.ToAbsoluteUri("/chathub"))
            .Build();

        hubConnection.On<string, string>("ReceiveMessage", (user, message) =>
        {
            userMessages.Add(new UserMessage { Username = user, Message = message, CurrentUser = user == usernameInput, DateSent = DateTime.Now });

            StateHasChanged();
        });

        await hubConnection.StartAsync();
    }

    private async Task Send()
    {
        if (!string.IsNullOrEmpty(usernameInput) && !string.IsNullOrEmpty(messageInput))
        {
            await hubConnection.SendAsync("SendMessage", usernameInput, messageInput);

            isUserReadonly = true;
            messageInput = string.Empty;
        }
    }

    public async ValueTask DisposeAsync()
    {
        if (hubConnection is not null)
        {
            await hubConnection.DisposeAsync();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
