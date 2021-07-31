using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace bzrArachnePWA.Server.Hubs
{
    public class BroadcastHub : Hub
    {
        public async Task SendMessage( string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
