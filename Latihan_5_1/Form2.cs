using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;

namespace Latihan_5_1
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "BackgroundColor")
            {
                tabControl1.SelectedIndex = 1;
            }
            else
            {
                tabControl1.SelectedIndex = 0;
            }
            
        }

        private void Editor_Load(object sender, EventArgs e)
        {
            //cbxBackgroundColor.Hide();
            
            if (treeView1.Nodes.Count < 1)
            {
                treeView1.Nodes.Add("Theme");
                treeView1.Nodes[0].Nodes.Add("BackgroundColor");


                Color color = new Color();
                PropertyInfo[] infocolor = color.GetType().GetProperties();
                this.cbxBackgroundColor.DrawMode = DrawMode.OwnerDrawFixed;
                foreach (PropertyInfo i in infocolor)
                {
                    if (i.PropertyType == typeof(System.Drawing.Color))
                    {
                        cbxBackgroundColor.Items.Add(i.Name);
                    }
                }
                this.cbxBackgroundColor.DrawItem += new DrawItemEventHandler(cbxBackgroundColor_DrawItem);
            }
        }
        
        private void cbxBackgroundColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.cbxBackgroundColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 31, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 30, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 40, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }

        

    }
}
