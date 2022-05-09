using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortAlgorithms
{
    public class SortVisualization
    {
        public List<Label> labels = new List<Label>();

        public Label DrawLabel(string name)
        {
            if (labels.Count > 0 && !string.IsNullOrWhiteSpace(name))
            {
                for (int i = 1; i < labels.Count; i++)
                {
                    if (labels[i].Text.Equals(""))
                    {
                        labels[i].Invoke((Action)delegate { labels[i].Text = name; });
                        return labels[i];
                    }
                }
            }

            if (labels.Count == 0)
            {
                labels.Add(new Label());
            }
            var label = new Label()
            {
                AutoSize = true,
                Location = new System.Drawing.Point(25, 30 * labels.Count),
                Name = "label" + labels.Count,
                Size = new System.Drawing.Size(44, 16),
                TabIndex = labels.Count,
                Text = name
            };
            labels.Add(label);
            return label;
        }
        





        






    }
}
