using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public static class SortVisualization
    {
        public static List<Label> labels = new List<Label>();
        public static List<CheckBox> checkBoxs = new List<CheckBox>();
        public static Label Array;

        public static void DrawArray(string text)
        {
            if (Array is null)
            {
                Array = new Label()
                {
                    AutoSize = true,
                    Location = new System.Drawing.Point(5, 30),
                    Name = "labelArray",
                    Size = new System.Drawing.Size(60, 16),
                    TabIndex = 0,
                    Text = text
                };
            }
            else
            {
                Array.Text = text;
            }
        }

        public static Label DrawLabel(string name)
        {
            var label = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(40, 60 + 30 * labels.Count),
                Name = "label" + labels.Count,
                Size = new System.Drawing.Size(60, 16),
                TabIndex = labels.Count,
                Text = name
            };
            labels.Add(label);
            return label;
        }
        
        public static CheckBox AddCheckBox(bool IsChecked)
        {
            var checkBox = new CheckBox()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(15, 60 + 30 * checkBoxs.Count),
                Name = "checkBox" + checkBoxs.Count,
                Size = new System.Drawing.Size(18, 17),
                TabIndex = 4,
                UseVisualStyleBackColor = true
            };
         
            checkBox.Checked = IsChecked;           
            checkBoxs.Add(checkBox);
            return checkBox;
        }

        public static void Clear()
        {
            labels.Clear();
            checkBoxs.Clear();
        }






    }
}
