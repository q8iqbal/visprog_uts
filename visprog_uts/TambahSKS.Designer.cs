
namespace visprog_uts
{
    partial class TambahSKS
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.tb_nrp = new System.Windows.Forms.TextBox();
            this.tb_jurusan = new System.Windows.Forms.TextBox();
            this.clb_mk = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(101, 10);
            this.btn_close.Margin = new System.Windows.Forms.Padding(2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(56, 19);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(9, 10);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(56, 19);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Simpan";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "NRP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jurusan";
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(58, 40);
            this.tb_nama.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.ReadOnly = true;
            this.tb_nama.Size = new System.Drawing.Size(101, 20);
            this.tb_nama.TabIndex = 5;
            // 
            // tb_nrp
            // 
            this.tb_nrp.Location = new System.Drawing.Point(58, 70);
            this.tb_nrp.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nrp.Name = "tb_nrp";
            this.tb_nrp.ReadOnly = true;
            this.tb_nrp.Size = new System.Drawing.Size(101, 20);
            this.tb_nrp.TabIndex = 6;
            // 
            // tb_jurusan
            // 
            this.tb_jurusan.Location = new System.Drawing.Point(58, 96);
            this.tb_jurusan.Margin = new System.Windows.Forms.Padding(2);
            this.tb_jurusan.Name = "tb_jurusan";
            this.tb_jurusan.ReadOnly = true;
            this.tb_jurusan.Size = new System.Drawing.Size(101, 20);
            this.tb_jurusan.TabIndex = 7;
            // 
            // clb_mk
            // 
            this.clb_mk.FormattingEnabled = true;
            this.clb_mk.Location = new System.Drawing.Point(6, 129);
            this.clb_mk.Margin = new System.Windows.Forms.Padding(2);
            this.clb_mk.Name = "clb_mk";
            this.clb_mk.Size = new System.Drawing.Size(152, 199);
            this.clb_mk.TabIndex = 8;
            // 
            // TambahSKS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 347);
            this.ControlBox = false;
            this.Controls.Add(this.clb_mk);
            this.Controls.Add(this.tb_jurusan);
            this.Controls.Add(this.tb_nrp);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_close);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TambahSKS";
            this.Text = "Daftar SKS Mahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.TextBox tb_nrp;
        private System.Windows.Forms.TextBox tb_jurusan;
        private System.Windows.Forms.CheckedListBox clb_mk;
    }
}