namespace volleyball_problem
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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.BtnHitung = new System.Windows.Forms.Button();
            this.label_Hasil = new System.Windows.Forms.Label();
            this.TxtHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(83, 47);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(118, 20);
            this.Txt1.TabIndex = 0;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(83, 87);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(118, 20);
            this.Txt2.TabIndex = 1;
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(52, 50);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(14, 13);
            this.label_A.TabIndex = 2;
            this.label_A.Text = "A";
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(52, 90);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(14, 13);
            this.label_B.TabIndex = 3;
            this.label_B.Text = "B";
            // 
            // BtnHitung
            // 
            this.BtnHitung.Location = new System.Drawing.Point(230, 45);
            this.BtnHitung.Name = "BtnHitung";
            this.BtnHitung.Size = new System.Drawing.Size(73, 23);
            this.BtnHitung.TabIndex = 4;
            this.BtnHitung.Text = "Hitung";
            this.BtnHitung.UseVisualStyleBackColor = true;
            this.BtnHitung.Click += new System.EventHandler(this.btn_Hitung_Click);
            // 
            // label_Hasil
            // 
            this.label_Hasil.AutoSize = true;
            this.label_Hasil.Location = new System.Drawing.Point(326, 53);
            this.label_Hasil.Name = "label_Hasil";
            this.label_Hasil.Size = new System.Drawing.Size(30, 13);
            this.label_Hasil.TabIndex = 5;
            this.label_Hasil.Text = "Hasil";
            // 
            // TxtHasil
            // 
            this.TxtHasil.Location = new System.Drawing.Point(357, 50);
            this.TxtHasil.Name = "TxtHasil";
            this.TxtHasil.Size = new System.Drawing.Size(118, 20);
            this.TxtHasil.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 162);
            this.Controls.Add(this.TxtHasil);
            this.Controls.Add(this.label_Hasil);
            this.Controls.Add(this.BtnHitung);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
            this.Name = "Form1";
            this.Text = "volleyball_problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Button BtnHitung;
        private System.Windows.Forms.Label label_Hasil;
        private System.Windows.Forms.TextBox TxtHasil;
    }
}

