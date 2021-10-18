using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace visprog_uts
{

    public partial class TambahSKS : Form
    {

        private Mahasiswa mahasiswa;
        private iqbaldbEntities2 context;

        public Mahasiswa Mahasiswa { get => mahasiswa; set => mahasiswa = value; }
        public iqbaldbEntities2 Context { get => context; set => context = value; }

        private List<MataKuliah> mk;

        public TambahSKS(iqbaldbEntities2 context)
        {
            this.context = context;
            InitializeComponent();
            mahasiswa = new Mahasiswa();
            this.VisibleChanged += HandleVisibleChanged;
            UpdateMK();
        }

        private void HandleVisibleChanged(object sender, EventArgs e)
        {
            tb_nama.Text = mahasiswa.nama;
            tb_nrp.Text = mahasiswa.nrp;
            tb_jurusan.Text = mahasiswa.jurusan;
            UpdateMK();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void UpdateMK()
        {
            clb_mk.Items.Clear();
            mk = context.MataKuliahs.ToList();
            foreach(MataKuliah m in mk)
            {
                var temp = context.Mahasiswa_MataKuliah.Where(x => x.mahasiswa_id == mahasiswa.id && x.matakuliah_id == m.id).Count();
                clb_mk.Items.Add($"{m.id} {m.judul}", temp > 0? true : false);
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            context.Mahasiswa_MataKuliah.RemoveRange(context.Mahasiswa_MataKuliah.Where(x => x.mahasiswa_id == mahasiswa.id));
            context.SaveChanges();
            var tes = clb_mk.CheckedItems;
            foreach (var i in clb_mk.CheckedItems)
            {
                var temp = new Mahasiswa_MataKuliah { matakuliah_id = int.Parse(Regex.Match(i.ToString(), @"\d+").Value), mahasiswa_id=mahasiswa.id , status="diambil"};
                context.Mahasiswa_MataKuliah.Add(temp);
            }
            context.SaveChanges();
        }
    }
}
