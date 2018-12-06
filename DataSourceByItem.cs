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
    public partial class DataSourceByItem : UserControl
    {
        MyCheckedListBox boxes;
        public DataSourceByItem()
        {
            InitializeComponent();
            boxes = BoxesCreator.CreateDataSourceBoxes(panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxes.SetVisualState(boxes.Items[3], false); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boxes.SetVisualState(boxes.Items[3], true);
        }
    }
}
