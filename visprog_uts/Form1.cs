using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visprog_uts
{
    public partial class Form1 : Form
    {
        private MahasiswaForm mahasiswaForm;
        private MataKuliahForm mataKuliahForm;
        private TambahSKS tambahSKS;
        private EditSKS editSKS;
        private iqbaldbEntities2 context;
        private int mahasiswaId;

        public Form1()
        {
            context = new iqbaldbEntities2();
            InitializeComponent();
            InitializeForm();
            mahasiswaId = 0;
        }

        private void InitializeForm()
        {
            mahasiswaForm = new MahasiswaForm();
            mahasiswaForm.Show();
            mahasiswaForm.Visible = false;
            mahasiswaForm.VisibleChanged += Form1_Load;

            mataKuliahForm = new MataKuliahForm();
            mataKuliahForm.Show();
            mataKuliahForm.Visible = false;

            tambahSKS = new TambahSKS(context);
            tambahSKS.Show();
            tambahSKS.Visible = false;

            editSKS = new EditSKS(context);
            editSKS.Show();
            editSKS.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iqbaldbDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.iqbaldbDataSet.Mahasiswa);
        }

        private void btn_mhs_Click(object sender, EventArgs e)
        {
            mahasiswaForm.Visible = true;
        }

        private void btn_mk_Click(object sender, EventArgs e)
        {
            mataKuliahForm.Visible = true;
            tambahSKS.UpdateMK();
        }

        private void btn_sks_add_Click(object sender, EventArgs e)
        {
            var mhs = context.Mahasiswas.Find(mahasiswaId);
            tambahSKS.Mahasiswa = mhs;
            tambahSKS.Visible = true;
        }

        private void dgv_mhs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = dgv_mhs.Rows[e.RowIndex].Cells[1];
            mahasiswaId = Convert.ToInt32(selectedRow.Value);     
        }

        private void btn_sks_update_Click(object sender, EventArgs e)
        {
            var mhs = context.Mahasiswas.Find(mahasiswaId);
            editSKS.Mahasiswa = mhs;
            editSKS.Visible = true;
        }
    }
}
