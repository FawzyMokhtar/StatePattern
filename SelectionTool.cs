using System;

namespace StatePattern
{
    /// <summary>
    /// The selection tool.
    /// </summary>
    public class SelectionTool : Tool
    {
        /// <summary>
        /// Fires a mouse down event on the canvas.
        /// </summary>
        public void MouseDown()
        {
            Console.WriteLine("Mouse down for Selection tool.");
        }

        /// <summary>
        /// Fires a mouse up event on the canvas.
        /// </summary>
        public void MouseUp()
        {
            Console.WriteLine("Mouse up for Selection tool.");
        }
    }
}