using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace Cards.Front.Hubs
{
    public class CardsHub : Hub
    {
        public async Task NewMessageAsync(long username, string message)
        {
            await Clients.All.SendAsync("messageReceived", username, message);
        }
    }
}
