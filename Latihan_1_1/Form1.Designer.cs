namespace Latihan_1_1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lmax = new System.Windows.Forms.Label();
            this.lmin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vsbarmax = new System.Windows.Forms.VScrollBar();
            this.vsbarmin = new System.Windows.Forms.VScrollBar();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtptanggal = new System.Windows.Forms.DateTimePicker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(32, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 324);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lmax);
            this.tabPage1.Controls.Add(this.lmin);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.vsbarmax);
            this.tabPage1.Controls.Add(this.vsbarmin);
            this.tabPage1.ImageIndex = 1;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lmax
            // 
            this.lmax.AutoSize = true;
            this.lmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmax.Location = new System.Drawing.Point(339, 104);
            this.lmax.Name = "lmax";
            this.lmax.Size = new System.Drawing.Size(65, 24);
            this.lmax.TabIndex = 7;
            this.lmax.Text = "l_max";
            // 
            // lmin
            // 
            this.lmin.AutoSize = true;
            this.lmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lmin.Location = new System.Drawing.Point(216, 104);
            this.lmin.Name = "lmin";
            this.lmin.Size = new System.Drawing.Size(60, 24);
            this.lmin.TabIndex = 6;
            this.lmin.Text = "l_min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(371, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "10";
            // 
            // vsbarmax
            // 
            this.vsbarmax.LargeChange = 1;
            this.vsbarmax.Location = new System.Drawing.Point(374, 51);
            this.vsbarmax.Maximum = 10;
            this.vsbarmax.Name = "vsbarmax";
            this.vsbarmax.Size = new System.Drawing.Size(17, 133);
            this.vsbarmax.TabIndex = 1;
            this.vsbarmax.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbarmax_Scroll);
            // 
            // vsbarmin
            // 
            this.vsbarmin.LargeChange = 1;
            this.vsbarmin.Location = new System.Drawing.Point(196, 51);
            this.vsbarmin.Maximum = 10;
            this.vsbarmin.Name = "vsbarmin";
            this.vsbarmin.Size = new System.Drawing.Size(17, 133);
            this.vsbarmin.TabIndex = 0;
            this.vsbarmin.Value = 10;
            this.vsbarmin.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbarmin_Scroll);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dtptanggal);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 297);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtptanggal
            // 
            this.dtptanggal.Location = new System.Drawing.Point(221, 66);
            this.dtptanggal.Name = "dtptanggal";
            this.dtptanggal.Size = new System.Drawing.Size(200, 20);
            this.dtptanggal.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Koala.jpg");
            this.imageList1.Images.SetKeyName(1, "Penguins.jpg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 406);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Latihan_1_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lmax;
        private System.Windows.Forms.Label lmin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.VScrollBar vsbarmax;
        private System.Windows.Forms.VScrollBar vsbarmin;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dtptanggal;
        private System.Windows.Forms.ImageList imageList1;

    }
}

