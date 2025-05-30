using Microsoft.AspNetCore.SignalR;
using SignalR.DataAccessLayer.Context;

namespace SignalRProjectRestaurant.API.Hubs
{
    public class SignalRHub : Hub
    {
        ProjectContext context = new ProjectContext();
        public async Task SendCategoryCount()
        {
            var value = context.Categories.Count();
            await Clients.All.SendAsync("ReceiveCategoryCount", value);
        }
    }
}
