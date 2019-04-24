window.getContext = function (canvas) {
    return canvas ? canvas.getContext('2d') : null;
};

window.drawCanvas = function (ctx, previousX, previousY, x, y, color) {
    if (ctx) {
        ctx.beginPath();
        ctx.globalCompositeOperation = 'source-over';
        ctx.strokeStyle = color;
        ctx.lineWidth = 3;
        ctx.moveTo(previousX, previousY);
        ctx.lineTo(x, y);
        ctx.lineJoin = ctx.lineCap = 'round';
        ctx.stroke();
    }
};