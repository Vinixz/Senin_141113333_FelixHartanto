namespace Latihan_5_1
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.cbxBackgroundColor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(53, 53);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(148, 146);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // cbxBackgroundColor
            // 
            this.cbxBackgroundColor.FormattingEnabled = true;
            this.cbxBackgroundColor.Location = new System.Drawing.Point(218, 53);
            this.cbxBackgroundColor.Name = "cbxBackgroundColor";
            this.cbxBackgroundColor.Size = new System.Drawing.Size(121, 21);
            this.cbxBackgroundColor.TabIndex = 3;
            this.cbxBackgroundColor.Text = "White";
            
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 263);
            this.Controls.Add(this.cbxBackgroundColor);
            this.Controls.Add(this.treeView1);
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.ComboBox cbxBackgroundColor;
    }
}