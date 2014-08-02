using System;

namespace ListBoxWithToolTip
{
    /// <summary>
    /// Class used to represent each item in the listbox.
    /// </summary>
    internal class ListBoxItem : IToolTipDisplayer
    {
        /// <summary>
        /// Text that is displayed in the list box.
        /// </summary>
        public string DisplayText { get; private set; }

        /// <summary>
        /// Text that is displayed in a tooltip.
        /// </summary>
        public string ToolTipText { get; private set; }

        public ListBoxItem(string displayText, string toolTipText)
        {
            DisplayText = displayText;
            ToolTipText = toolTipText;
        }

        /// <summary>
        /// Returns the display text of this item.
        /// </summary>
        /// <returns>Display text of this item.</returns>
        public override string ToString()
        {
            return DisplayText;
        }

        /// <summary>
        /// Returns the tooltip text of this item.
        /// </summary>
        /// <returns>Tooltip text of this item.</returns>
        public string GetToolTipText()
        {
            return ToolTipText;
        }
    }
}
