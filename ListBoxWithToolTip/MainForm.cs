using System;
using System.Windows.Forms;

namespace ListBoxWithToolTip
{
    internal partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // Create list of random items
            ListBoxItem[] items = new ListBoxItem[]
            {
                new ListBoxItem("Apple",     "Malus pumila"),
                new ListBoxItem("Banana",    "Porcelia macrocarpa"),
                new ListBoxItem("Kiwi",      "Actinidia deliciosa"),
                new ListBoxItem("Papaya",    "Carica papaya"),
                new ListBoxItem("Mango",     "Mangifera indica"),
                new ListBoxItem("Tomato",    "Lycopersicon esculentum"),
                new ListBoxItem("Lychee",    "Litchi chinensis"),
                new ListBoxItem("Coconut",   "Cocos nucifera"),
                new ListBoxItem("Tangerine", "Citrus reticulata"),
                new ListBoxItem("Avocado",   "Persea americana"),
            };

            // Populate list box
            toolTipListBox.Items.AddRange(items);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
