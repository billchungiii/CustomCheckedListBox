using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCheckedListBox
{
    public partial class Form1 : Form
    {
        MyCheckedListbox boxes;
        public Form1()
        {
            InitializeComponent();
            boxes = new MyCheckedListbox();
            for (int i = 0; i < 10; i++)
            {
                boxes.Items.Add($"A0{i}");
            }

            panel2.Controls.Add(boxes);
            boxes.Dock = DockStyle.Fill; 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            boxes.SetVisualState(2, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boxes.SetVisualState(2, true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boxes.SetVisualState("A08", false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            boxes.SetVisualState("A08", true);
        }
    }
}
