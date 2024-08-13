using Aa_DAL.Models;
using B_BUS.Services;
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
    public partial class Frm_Sale : Form
    {
        SaleService _service;
        public Frm_Sale()
        {
            _service = new SaleService();
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale()
            {
                Id = Guid.NewGuid(),
                Name = txt_ten.Text,
                Description = txt_ten.Text,
                StartDate = dtp_start.Value,
                EndDate = dtp_end.Value,
                Percent = Convert.ToDouble(txt_ptgiam.Text),
                Status = cbx_trangthai.SelectedIndex,

            };
            MessageBox.Show(_service.CreateSales(sale));
            LoadAllSale();
        }

        public void LoadAllSale()
        {
            dtg_Data.DataSource = null;
            var allSale = _service.GetAllSales();
            dtg_Data.DataSource = allSale;
        }

        private void Frm_Sale_Load(object sender, EventArgs e)
        {
            LoadAllSale();  
        }
    }
}
