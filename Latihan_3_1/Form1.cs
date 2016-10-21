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

namespace Latihan_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Edit_Text(string sfont)
        {
            if (sfont == "color")
            {
                rtbNotepad.SelectionColor = Color.FromName(cbFontColor.Text);
            }
            else
            {
                int ustart = rtbNotepad.SelectionStart;
                int ulength = rtbNotepad.SelectionLength;
                int start1, length1 ;
                start1  = ustart; length1 = 1;
                

                if (sfont == "family")
                {
                    string fontfamily = cbFontFamily.Text;
                    for (int i = ustart; i < ustart + ulength; i++)
                    {
                        rtbNotepad.Focus();
                        rtbNotepad.Select(i, length1);
                        
                    rtbNotepad.SelectionFont = new Font(fontfamily, rtbNotepad.SelectionFont.Size,
                    rtbNotepad.SelectionFont.Style);
                    }
                }
                else if (sfont == "size")
                {
                    float fontsize = Convert.ToSingle(cbFontSize.Text);
                    for (int i = ustart; i < ustart + ulength; i++)
                    {
                        rtbNotepad.Focus();
                        rtbNotepad.Select(i, length1);
                        
                    rtbNotepad.SelectionFont = new Font(rtbNotepad.SelectionFont.FontFamily, fontsize,
                    rtbNotepad.SelectionFont.Style);
                    }
                }
                else if (sfont == "bold")
                {
                    System.Drawing.Font currentFont = rtbNotepad.SelectionFont;
                    for (int i = ustart; i < ustart + ulength; i++)
                    {
                        rtbNotepad.Focus();
                        rtbNotepad.Select(i, length1);

                        System.Drawing.Font startFont = rtbNotepad.SelectionFont;

                        System.Drawing.FontStyle newFont = currentFont.Bold == false ? FontStyle.Bold : FontStyle.Regular;

                        newFont |= startFont.Italic == true ? FontStyle.Italic : FontStyle.Regular;
                        newFont |= startFont.Underline == true ? FontStyle.Underline : FontStyle.Regular;

                        rtbNotepad.SelectionFont = new Font(rtbNotepad.SelectionFont.FontFamily, rtbNotepad.SelectionFont.Size,
                    newFont);
                    }
                }
                else if (sfont == "italic")
                {
                    System.Drawing.Font currentFont = rtbNotepad.SelectionFont;
                    for (int i = ustart; i < ustart + ulength; i++)
                    {
                        rtbNotepad.Focus();
                        rtbNotepad.Select(i, length1);

                        System.Drawing.Font startFont = rtbNotepad.SelectionFont;
                        
                        System.Drawing.FontStyle newFont = currentFont.Italic == false ? FontStyle.Italic : FontStyle.Regular;

                        newFont |= startFont.Bold == true ? FontStyle.Bold : FontStyle.Regular;
                        newFont |= startFont.Underline == true ? FontStyle.Underline : FontStyle.Regular;

                        rtbNotepad.SelectionFont = new Font(rtbNotepad.SelectionFont.FontFamily, rtbNotepad.SelectionFont.Size,
                    newFont);
                    }
                }
                else if (sfont == "underline")
                {
                    System.Drawing.Font currentFont = rtbNotepad.SelectionFont;
                    for (int i = ustart; i < ustart + ulength; i++)
                    {
                        rtbNotepad.Focus();
                        rtbNotepad.Select(i, length1);

                        System.Drawing.Font startFont = rtbNotepad.SelectionFont;

                        System.Drawing.FontStyle newFont = currentFont.Underline == false ? FontStyle.Underline : FontStyle.Regular;

                        newFont |= startFont.Bold == true ? FontStyle.Bold : FontStyle.Regular;
                        newFont |= startFont.Italic == true ? FontStyle.Italic : FontStyle.Regular;
                        

                        rtbNotepad.SelectionFont = new Font(rtbNotepad.SelectionFont.FontFamily, rtbNotepad.SelectionFont.Size,
                    newFont);
                    }
                        
                }
                rtbNotepad.Focus();
                rtbNotepad.Select(ustart, ulength);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color color = new Color();
            PropertyInfo[] infocolor = color.GetType().GetProperties();

            InstalledFontCollection ifc = new InstalledFontCollection();
            FontFamily[] families = ifc.Families;

            for (int i = 7; i <= 72; i++)
            {
                cbFontSize.Items.Add(i);
            }

            foreach (FontFamily font in families)
            {
                cbFontFamily.Items.Add(font.Name);
            }

            this.cbFontColor.ComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            foreach (PropertyInfo i in infocolor)
            {
                if (i.PropertyType == typeof(System.Drawing.Color))
                {
                    cbFontColor.Items.Add(i.Name);
                }
            }

            cbFontSize.SelectedIndex = 5;
            cbFontFamily.Text = "Calibri";
            cbFontColor.Text = "Black";

            float fontSize;
            System.Drawing.FontStyle style = (btnBold.Checked) ? FontStyle.Bold : FontStyle.Regular;
            style |= (btnItalic.Checked) ? FontStyle.Italic : FontStyle.Regular;
            style |= (btnUnderline.Checked) ? FontStyle.Underline : FontStyle.Regular;
            fontSize = Convert.ToSingle(cbFontSize.Text);
            rtbNotepad.SelectionFont = new Font(cbFontFamily.Text,
                                             fontSize,
                                             style);
            rtbNotepad.SelectionColor = Color.FromName(cbFontColor.Text);
            this.cbFontColor.ComboBox.DrawItem += new DrawItemEventHandler(cbFontColor_DrawItem);
        }

        private void cbFontColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                Graphics g = e.Graphics;
                Brush brush = new SolidBrush(e.BackColor);
                Brush tBrush = new SolidBrush(e.ForeColor);
                g.FillRectangle(brush, e.Bounds);
                string s = (string)this.cbFontColor.Items[e.Index].ToString();
                SolidBrush b = new SolidBrush(Color.FromName(s));
                e.Graphics.DrawRectangle(Pens.Black, 2, e.Bounds.Top + 1, 31, 11);
                e.Graphics.FillRectangle(b, 3, e.Bounds.Top + 2, 30, 10);
                e.Graphics.DrawString(s, this.Font, Brushes.Black, 40, e.Bounds.Top);
                brush.Dispose();
                tBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }


        private void cbFontColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox combobox = (ToolStripComboBox)sender;
            if (!combobox.Focused)
            {
                return;
            }
            Edit_Text("color");
        }

        private void cbFontFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox combobox = (ToolStripComboBox)sender;
            if (!combobox.Focused)
            {
                return;
            }
            
            Edit_Text("family");
            
        }

        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ToolStripComboBox combobox = (ToolStripComboBox)sender;
            if (!combobox.Focused)
            {
                return;
            }
            Edit_Text("size");
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (btnBold.Checked == true)
            {
                btnBold.Checked = false;
            }
            else
            {
                btnBold.Checked = true;
            }
            Edit_Text("bold");
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (btnItalic.Checked == true)
            {
                btnItalic.Checked = false;
            }
            else
            {
                btnItalic.Checked = true;
            }
            Edit_Text("italic");
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (btnUnderline.Checked == true)
            {
                btnUnderline.Checked = false;
            }
            else
            {
                btnUnderline.Checked = true;
            }
            Edit_Text("underline");
        }

        private void rtbNotepad_SelectionChanged(object sender, EventArgs e)
        {
            btnBold.Checked = false;
            btnItalic.Checked = false;
            btnUnderline.Checked = false;
            if (rtbNotepad.SelectionFont != null)
            {
                cbFontFamily.Text = rtbNotepad.SelectionFont.FontFamily.Name;
                cbFontSize.Text = rtbNotepad.SelectionFont.Size.ToString();
                if (rtbNotepad.SelectionFont.Bold.ToString() == "True")
                {
                    btnBold.Checked = true;
                }
                if (rtbNotepad.SelectionFont.Italic.ToString() == "True")
                {
                    btnItalic.Checked = true;
                }
                if (rtbNotepad.SelectionFont.Underline.ToString() == "True")
                {
                    btnUnderline.Checked = true;
                }
            }
            else
            {
                cbFontFamily.Text = "";
                cbFontSize.Text = "";
            }
            if (rtbNotepad.SelectionColor.Name == "0")
                cbFontColor.Text = "";
            else
                cbFontColor.Text = rtbNotepad.SelectionColor.Name;
        }
    }
}