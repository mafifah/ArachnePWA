using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Hubs
{
    public class ChatHub : Hub
    {
        public const string HubUrl = "/chatHub";

        public async Task Broadcast(string username, string divisi, string message)
        {
            //await Clients.All.SendAsync("Broadcast", username, divisi, message);
            await Clients.Group(divisi).SendAsync("Broadcast", username, divisi, message);
        }

        public override Task OnConnectedAsync()
        {
            Console.WriteLine($"{Context.ConnectionId} connected");
            return base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception e)
        {
            Console.WriteLine($"Disconnected {e?.Message} {Context.ConnectionId}");
            await base.OnDisconnectedAsync(e);
        }
    }
}
