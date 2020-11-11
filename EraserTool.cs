using System;

namespace StatePattern
{
    /// <summary>
    /// The eraser tool.
    /// </summary>
    public class EraserTool : Tool
    {
        /// <summary>
        /// Fires a mouse down event on the canvas.
        /// </summary>
        public void MouseDown()
        {
            Console.WriteLine("Mouse down for Eraser tool.");
        }

        /// <summary>
        /// Fires a mouse up event on the canvas.
        /// </summary>
        public void MouseUp()
        {
            Console.WriteLine("Mouse up for Eraser tool.");
        }
    }
}