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
       
        public Form1()
        {
            InitializeComponent();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new ByIndex() { Dock = DockStyle.Fill });  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new ByItem() { Dock = DockStyle.Fill });
        }
      

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new DataSourceByIndex() { Dock = DockStyle.Fill });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(new DataSourceByItem() { Dock = DockStyle.Fill });
        }
    }
}
