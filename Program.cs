namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Default tool is selection.
            var canvas = new Canvas(new SelectionTool());
            canvas.MouseDown();
            canvas.MouseUp();

            // Change tool to brush.
            canvas.ChangeTool(new BrushTool());
            canvas.MouseDown();
            canvas.MouseUp();

            // Change tool to eraser.
            canvas.ChangeTool(new EraserTool());
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
