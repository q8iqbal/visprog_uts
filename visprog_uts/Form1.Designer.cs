
namespace visprog_uts
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
            this.dgv_mhs = new System.Windows.Forms.DataGridView();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iqbaldbDataSet = new visprog_uts.iqbaldbDataSet();
            this.mahasiswaTableAdapter = new visprog_uts.iqbaldbDataSetTableAdapters.MahasiswaTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_mhs = new System.Windows.Forms.Button();
            this.btn_mk = new System.Windows.Forms.Button();
            this.btn_sks_add = new System.Windows.Forms.Button();
            this.btn_sks_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iqbaldbDataSet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_mhs
            // 
            this.dgv_mhs.AllowUserToAddRows = false;
            this.dgv_mhs.AllowUserToDeleteRows = false;
            this.dgv_mhs.AutoGenerateColumns = false;
            this.dgv_mhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mhs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namaDataGridViewTextBoxColumn,
            this.id});
            this.dgv_mhs.DataSource = this.mahasiswaBindingSource;
            this.dgv_mhs.Location = new System.Drawing.Point(12, 12);
            this.dgv_mhs.Name = "dgv_mhs";
            this.dgv_mhs.ReadOnly = true;
            this.dgv_mhs.RowHeadersVisible = false;
            this.dgv_mhs.RowHeadersWidth = 51;
            this.dgv_mhs.RowTemplate.Height = 24;
            this.dgv_mhs.Size = new System.Drawing.Size(248, 415);
            this.dgv_mhs.TabIndex = 0;
            this.dgv_mhs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mhs_CellClick);
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "nama";
            this.namaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            this.namaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Column1";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.iqbaldbDataSet;
            // 
            // iqbaldbDataSet
            // 
            this.iqbaldbDataSet.DataSetName = "iqbaldbDataSet";
            this.iqbaldbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn_mhs);
            this.flowLayoutPanel1.Controls.Add(this.btn_mk);
            this.flowLayoutPanel1.Controls.Add(this.btn_sks_add);
            this.flowLayoutPanel1.Controls.Add(this.btn_sks_update);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(266, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(128, 415);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_mhs
            // 
            this.btn_mhs.Location = new System.Drawing.Point(3, 3);
            this.btn_mhs.Name = "btn_mhs";
            this.btn_mhs.Size = new System.Drawing.Size(125, 35);
            this.btn_mhs.TabIndex = 0;
            this.btn_mhs.Text = "Mahasiswa";
            this.btn_mhs.UseVisualStyleBackColor = true;
            this.btn_mhs.Click += new System.EventHandler(this.btn_mhs_Click);
            // 
            // btn_mk
            // 
            this.btn_mk.Location = new System.Drawing.Point(3, 44);
            this.btn_mk.Name = "btn_mk";
            this.btn_mk.Size = new System.Drawing.Size(125, 35);
            this.btn_mk.TabIndex = 1;
            this.btn_mk.Text = "Mata Kuliah";
            this.btn_mk.UseVisualStyleBackColor = true;
            this.btn_mk.Click += new System.EventHandler(this.btn_mk_Click);
            // 
            // btn_sks_add
            // 
            this.btn_sks_add.Location = new System.Drawing.Point(3, 85);
            this.btn_sks_add.Name = "btn_sks_add";
            this.btn_sks_add.Size = new System.Drawing.Size(125, 35);
            this.btn_sks_add.TabIndex = 2;
            this.btn_sks_add.Text = "Tambah SKS";
            this.btn_sks_add.UseVisualStyleBackColor = true;
            this.btn_sks_add.Click += new System.EventHandler(this.btn_sks_add_Click);
            // 
            // btn_sks_update
            // 
            this.btn_sks_update.Location = new System.Drawing.Point(3, 126);
            this.btn_sks_update.Name = "btn_sks_update";
            this.btn_sks_update.Size = new System.Drawing.Size(125, 35);
            this.btn_sks_update.TabIndex = 3;
            this.btn_sks_update.Text = "Edit SKS";
            this.btn_sks_update.UseVisualStyleBackColor = true;
            this.btn_sks_update.Click += new System.EventHandler(this.btn_sks_update_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 443);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgv_mhs);
            this.Name = "Form1";
            this.Text = "Akses SKS Mahasiswa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iqbaldbDataSet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_mhs;
        private iqbaldbDataSet iqbaldbDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private iqbaldbDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_mhs;
        private System.Windows.Forms.Button btn_mk;
        private System.Windows.Forms.Button btn_sks_add;
        private System.Windows.Forms.Button btn_sks_update;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}

