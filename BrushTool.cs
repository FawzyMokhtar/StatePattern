using System;

namespace StatePattern
{
    /// <summary>
    /// The brush tool.
    /// </summary>
    public class BrushTool : Tool
    {
        /// <summary>
        /// Fires a mouse down event on the canvas.
        /// </summary>
        public void MouseDown()
        {
            Console.WriteLine("Mouse down for Brush tool.");
        }

        /// <summary>
        /// Fires a mouse up event on the canvas.
        /// </summary>
        public void MouseUp()
        {
            Console.WriteLine("Mouse up for Brush tool.");
        }
    }
}