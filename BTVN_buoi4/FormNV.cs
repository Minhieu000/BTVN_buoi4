using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN_buoi4
{
    public partial class FormNV : Form
    {
        public FormNV()
        {
            InitializeComponent();
        }
        public string MSNV { get; set; }
        public string TenNhanVien { get; set; }
        public string Luong { get; set; }

        private void FormNV_Load(object sender, EventArgs e)
        {
            txtMSNV.Text = MSNV;
            txtTenNhanVien.Text = TenNhanVien;
            txtLuongCoBan.Text = Luong;

        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            MSNV = txtMSNV.Text;
            TenNhanVien = txtTenNhanVien.Text;
            Luong = txtLuongCoBan.Text;

            if (string.IsNullOrWhiteSpace(MSNV) || string.IsNullOrWhiteSpace(TenNhanVien) || string.IsNullOrWhiteSpace(Luong))
            {
                MessageBox.Show("MSNV và Tên Nhân Viên không được để trống.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
