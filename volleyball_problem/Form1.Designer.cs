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
            this.tb_A = new System.Windows.Forms.TextBox();
            this.tb_B = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.btn_Hitung = new System.Windows.Forms.Button();
            this.label_Hasil = new System.Windows.Forms.Label();
            this.tb_Hasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_A
            // 
            this.tb_A.Location = new System.Drawing.Point(83, 47);
            this.tb_A.Name = "tb_A";
            this.tb_A.Size = new System.Drawing.Size(198, 20);
            this.tb_A.TabIndex = 0;
            // 
            // tb_B
            // 
            this.tb_B.Location = new System.Drawing.Point(83, 87);
            this.tb_B.Name = "tb_B";
            this.tb_B.Size = new System.Drawing.Size(198, 20);
            this.tb_B.TabIndex = 1;
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
            // btn_Hitung
            // 
            this.btn_Hitung.Location = new System.Drawing.Point(55, 124);
            this.btn_Hitung.Name = "btn_Hitung";
            this.btn_Hitung.Size = new System.Drawing.Size(226, 23);
            this.btn_Hitung.TabIndex = 4;
            this.btn_Hitung.Text = "Hitung";
            this.btn_Hitung.UseVisualStyleBackColor = true;
            this.btn_Hitung.Click += new System.EventHandler(this.btn_Hitung_Click);
            // 
            // label_Hasil
            // 
            this.label_Hasil.AutoSize = true;
            this.label_Hasil.Location = new System.Drawing.Point(52, 167);
            this.label_Hasil.Name = "label_Hasil";
            this.label_Hasil.Size = new System.Drawing.Size(30, 13);
            this.label_Hasil.TabIndex = 5;
            this.label_Hasil.Text = "Hasil";
            // 
            // tb_Hasil
            // 
            this.tb_Hasil.Location = new System.Drawing.Point(83, 164);
            this.tb_Hasil.Name = "tb_Hasil";
            this.tb_Hasil.Size = new System.Drawing.Size(198, 20);
            this.tb_Hasil.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 262);
            this.Controls.Add(this.tb_Hasil);
            this.Controls.Add(this.label_Hasil);
            this.Controls.Add(this.btn_Hitung);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.label_A);
            this.Controls.Add(this.tb_B);
            this.Controls.Add(this.tb_A);
            this.Name = "Form1";
            this.Text = "volleyball_problem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_A;
        private System.Windows.Forms.TextBox tb_B;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Button btn_Hitung;
        private System.Windows.Forms.Label label_Hasil;
        private System.Windows.Forms.TextBox tb_Hasil;
    }
}

