using IEvangelist.BlazoR.Board.Shared;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace IEvangelist.BlazoR.Board.Server.Hubs
{
    public interface IDrawingHub
    {
        Task DrawAsync(Stroke stroke);
    }

    public class DrawingHub : Hub<IDrawingHub>
    {
        public Task Draw(Stroke stroke) 
            => Clients.Others.DrawAsync(stroke);
    }
}