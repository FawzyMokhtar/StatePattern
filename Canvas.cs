namespace StatePattern
{
    /// <summary>
    /// Represents a drawing canvas that should be behave differently according to the current selected drawing tool and event type.
    /// </summary>
    public class Canvas
    {
        /// <summary>
        /// Gets or sets the current selected tool.
        /// </summary>
        private Tool currentTool { get; set; }

        /// <summary>
        /// Creates a new instance of <typeparamref name="Tool"/> with a default selected tool.
        /// </summary>
        /// <param name="initialSelectedTool">The initial selected tool.</param>
        public Canvas(Tool initialSelectedTool)
        {
            currentTool = initialSelectedTool;
        }

        /// <summary>
        /// Switch to another tool on the convas.
        /// </summary>
        /// <param name="tool">The tool to be selected.</param>
        public void ChangeTool(Tool tool)
        {
            currentTool = tool;
        }

        /// <summary>
        /// Fires a mouse down event on the canvas, the behavior may differ from a tool to another.
        /// </summary>
        public void MouseDown()
        {
            currentTool.MouseDown();
        }

        /// <summary>
        /// Fires a mouse up event on the canvas, the behavior may differ from a tool to another.
        /// </summary>
        public void MouseUp()
        {
            currentTool.MouseUp();
        }
    }
}