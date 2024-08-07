using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.Forms
{
    public partial class Frm_SanPham : Form
    {
        
        public Frm_SanPham()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();   
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            LoadDataToGridView();
        }
        public void LoadDataToGridView()
        {

        }
    }
}
