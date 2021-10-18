using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visprog_uts
{
    public partial class EditSKS : Form
    {
        private Mahasiswa mahasiswa;
        private iqbaldbEntities2 context;
        public Mahasiswa Mahasiswa { get => mahasiswa; set => mahasiswa = value; }
        public iqbaldbEntities2 Context { get => context; set => context = value; }

        public EditSKS(iqbaldbEntities2 context)
        {
            this.context = context;
            InitializeComponent();
            mahasiswa = new Mahasiswa();
            this.VisibleChanged += HandleVisibleChanged;
        }

        public void UpdateCBL()
        {
            clb_mk.Items.Clear();
            var mtk = mahasiswa.Mahasiswa_MataKuliah;
            foreach (Mahasiswa_MataKuliah m in mtk)
            {
                var mk = context.MataKuliahs.Find(m.matakuliah_id);
                bool status = m.status == "selesai" ? true : false;
                clb_mk.Items.Add($"{m.id} {mk.judul}", status);
            }
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void HandleVisibleChanged(object sender, EventArgs e)
        {
            tb_nama.Text = mahasiswa.nama;
            tb_nrp.Text = mahasiswa.nrp;
            tb_jurusan.Text = mahasiswa.jurusan;
            UpdateCBL();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            foreach (var i in clb_mk.CheckedItems)
            {
                var temp = context.Mahasiswa_MataKuliah.Find(int.Parse(Regex.Match(i.ToString(), @"\d+").Value));
                temp.status = "selesai";
            }
            context.SaveChanges();
        }
    }
}
