namespace Latihan_2_1
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
            this.Calendar1 = new System.Windows.Forms.MonthCalendar();
            this.DomUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.NumUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Calendar1
            // 
            this.Calendar1.Location = new System.Drawing.Point(95, 75);
            this.Calendar1.Name = "Calendar1";
            this.Calendar1.TabIndex = 0;
            // 
            // DomUpDown1
            // 
            this.DomUpDown1.Location = new System.Drawing.Point(216, 22);
            this.DomUpDown1.Name = "DomUpDown1";
            this.DomUpDown1.Size = new System.Drawing.Size(120, 20);
            this.DomUpDown1.TabIndex = 2;
            this.DomUpDown1.Text = "Bulan";
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(382, 22);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(75, 23);
            this.btn_tambah.TabIndex = 3;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(478, 22);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // NumUpDown1
            // 
            this.NumUpDown1.Location = new System.Drawing.Point(74, 22);
            this.NumUpDown1.Name = "NumUpDown1";
            this.NumUpDown1.Size = new System.Drawing.Size(69, 20);
            this.NumUpDown1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 420);
            this.Controls.Add(this.NumUpDown1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.DomUpDown1);
            this.Controls.Add(this.Calendar1);
            this.Name = "Form1";
            this.Text = "Latihan_2_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendar1;
        private System.Windows.Forms.DomainUpDown DomUpDown1;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.NumericUpDown NumUpDown1;
    }
}

