using IEvangelist.BlazoR.Board.Shared;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace IEvangelist.BlazoR.Board.Client.Pages
{
    public class IndexComponent : ComponentBase
    {
        protected override async Task OnInitAsync()
        {
            var hubConnection = new HubConnection("/drawing");
            var proxy = hubConnection.CreateHubProxy("DrawingHub");

            proxy.On<Stroke>("Draw", OnDrawing);

            await hubConnection.Start();
        }

        void OnDrawing(Stroke stroke)
        {

        }
    }
}