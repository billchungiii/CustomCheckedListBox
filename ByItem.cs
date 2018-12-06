using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCheckedListBox
{
    public partial class ByItem : UserControl
    {
        MyCheckedListBox boxes;
        public ByItem()
        {
            InitializeComponent();
            boxes = BoxesCreator.CreateNewBoxes(panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxes.SetVisualState("A08", false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boxes.SetVisualState("A08", true);
        }
    }
}
