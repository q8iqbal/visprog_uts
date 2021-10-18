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
    public partial class MahasiswaForm : Form
    {
        public MahasiswaForm()
        {
            InitializeComponent();
        }

        private void mahasiswaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.mahasiswaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.iqbaldbDataSet);

        }

        private void MahasiswaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iqbaldbDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.iqbaldbDataSet.Mahasiswa);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
