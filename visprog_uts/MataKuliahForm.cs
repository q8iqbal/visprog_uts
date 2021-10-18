using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visprog_uts
{
    public partial class MataKuliahForm : Form
    {
        public MataKuliahForm()
        {
            InitializeComponent();
        }

        private void mataKuliahBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mataKuliahBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iqbaldbDataSet);

        }

        private void MataKuliahForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iqbaldbDataSet.MataKuliah' table. You can move, or remove it, as needed.
            this.mataKuliahTableAdapter.Fill(this.iqbaldbDataSet.MataKuliah);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
