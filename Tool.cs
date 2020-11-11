namespace StatePattern
{
    /// <summary>
    /// A tool base functionality.
    /// </summary>
    public interface Tool
    {
        /// <summary>
        /// Fires a mouse down event on the canvas.
        /// </summary>
        void MouseDown();

        /// <summary>
        /// Fires a mouse up event on the canvas.
        /// </summary>
        void MouseUp();
    }
}