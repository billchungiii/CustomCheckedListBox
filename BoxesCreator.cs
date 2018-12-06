using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCheckedListBox
{
    public static class BoxesCreator
    {
        public static MyCheckedListBox CreateNewBoxes(Panel panel)
        {
            panel.Controls.Clear(); 
            var boxes = new MyCheckedListBox();
            for (int i = 0; i < 10; i++)
            {
                boxes.Items.Add($"A0{i}");
            }

            panel.Controls.Add(boxes);
            boxes.Dock = DockStyle.Fill;
            return boxes;
        }

        public static MyCheckedListBox CreateDataSourceBoxes(Panel panel)
        {
            panel.Controls.Clear();
            var boxes = new MyCheckedListBox
            {
                DataSource = DataCreator.CreateData(),
                DisplayMember = "Student",
                Dock= DockStyle.Fill 
            };
            panel.Controls.Add(boxes);
            return boxes;
        }

    }
}
