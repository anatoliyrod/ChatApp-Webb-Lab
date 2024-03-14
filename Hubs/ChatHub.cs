using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chatty.Hubs
{
    // Clasa pentru gestionarea conversațiilor în timp real
    public class ChatHub : Hub
    {
        // Metoda pentru transmiterea mesajelor către toți clienții conectați
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
