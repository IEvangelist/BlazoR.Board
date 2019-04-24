using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace IEvangelist.BlazoR.Board.Client.Components
{
    public class CanvasBase : ComponentBase
    {
        private bool _isMouseDown = false;
        private long _canvasX = 0;
        private long _canvasY = 0;
        private long _lastMouseX = 0;
        private long _lastMouseY = 0;
        private long _mouseX = 0;
        private long _mouseY = 0;

        protected string Id { get; } = Guid.NewGuid().ToString();

        [Inject]
        internal IJSRuntime JSRuntime { get; set; }

        [Parameter]
        protected long Height { get; set; } = 600;

        [Parameter]
        protected long Width { get; set; } = 800;

        protected ElementRef CanvasRef { get; set; }

        protected override async Task OnInitAsync()
        {
            await base.OnInitAsync();
        }

        protected void OnMouseDown(UIMouseEventArgs args)
        {
            _lastMouseX = _mouseX = args.ClientX - _canvasX;
            _lastMouseY = _mouseY = args.ClientY - _canvasY;
            _isMouseDown = true;
        }

        protected void OnMouseUp(UIMouseEventArgs args)
        {
            _isMouseDown = false;
        }

        protected void OnMouseMove(UIMouseEventArgs args)
        {
            _mouseX = args.ClientX - _canvasX;
            _mouseY = args.ClientY - _canvasY;
            
            // var clr = $('select[id=color]').val()
            if (_lastMouseX > 0 && _lastMouseY > 0 && _isMouseDown)
            {
                // DrawCanvas(_mouseX, _mouseY, _lastMouseX, _lastMouseY, "red");
                // connection.invoke('draw', last_mousex, last_mousey, mousex, mousey, clr);
            }

            _lastMouseX = _mouseX;
            _lastMouseY = _mouseY;
        }

        protected void OnMouseOut(UIMouseEventArgs args)
        {

        }

        void DrawCanvas()
        {

        }

        class Canvas2DContext
        {

        }
    }
}