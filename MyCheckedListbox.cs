using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace CustomCheckedListBox
{
    public class MyCheckedListBox : CheckedListBox
    {
        private readonly List<DisabledItem> _disabledItems;

        public MyCheckedListBox()
        {
            _disabledItems = new List<DisabledItem>();

        }
        public void SetVisualState(int index, bool enabled)
        {
            if (index < 0 || index >= this.Items.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            SetVisualState(Items[index], enabled);
        }


        public void SetVisualState(object item, bool enabled)
        {
            var targetItem = _disabledItems.FirstOrDefault((x) => x.Item.Equals(item));
            RefreshItems(item, enabled, targetItem);
        }

        private void RefreshItems(object item, bool enabled, DisabledItem targetItem)
        {
            if (enabled)
            {
                RemoveDisabledItem(targetItem);
            }
            else
            {
                AddDisabledItem(item, targetItem);
            }
            this.Refresh();
        }

        private void AddDisabledItem(object item, DisabledItem targetItem)
        {
            if (targetItem == null)
            {
                bool isChecked = this.CheckedItems.Contains(item);
                var addItem = new DisabledItem { Item = item, Checked = isChecked };
                _disabledItems.Add(addItem);
            }
        }

        private void RemoveDisabledItem(DisabledItem targetItem)
        {
            if (targetItem != null)
            {
                _disabledItems.Remove(targetItem);
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            var item = Items[e.Index];
            var targetItem = _disabledItems.FirstOrDefault((x) => x.Item.Equals(item));
            if (targetItem != null)
            {
                CheckBoxState state = CheckBoxState.UncheckedDisabled;
                if (targetItem.Checked)
                {
                    state = CheckBoxState.CheckedDisabled;
                }
                Size glyphSize = CheckBoxRenderer.GetGlyphSize(e.Graphics, state);
                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.X + 1, e.Bounds.Y + 1),
                    new Rectangle(new Point(e.Bounds.X + glyphSize.Width + 3, e.Bounds.Y), new Size(e.Bounds.Width - glyphSize.Width, e.Bounds.Height)),
                      GetItemText(item), this.Font, TextFormatFlags.Left, false, state);
            }
            else
            {
                base.OnDrawItem(e);
            }
        }
        private class DisabledItem
        {
            internal object Item { get; set; }
            internal bool Checked { get; set; }
        }
    }
}
