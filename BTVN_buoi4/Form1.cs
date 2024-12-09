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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormNV formNhanVien = new FormNV();
            if (formNhanVien.ShowDialog() == DialogResult.OK)
            {
                // Thêm dữ liệu từ Form Nhân Viên
                dataGridViewNhanVien.Rows.Add(formNhanVien.MSNV, formNhanVien.TenNhanVien, formNhanVien.Luong);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewNhanVien.SelectedRows[0];
                FormNV formNhanVien = new FormNV();

                // Gửi dữ liệu sang form sửa
                formNhanVien.MSNV = selectedRow.Cells[0].Value.ToString();
                formNhanVien.TenNhanVien = selectedRow.Cells[1].Value.ToString();
                formNhanVien.Luong = selectedRow.Cells[2].Value.ToString();

                if (formNhanVien.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật dữ liệu
                    selectedRow.Cells[0].Value = formNhanVien.MSNV;
                    selectedRow.Cells[1].Value = formNhanVien.TenNhanVien;
                    selectedRow.Cells[2].Value = formNhanVien.Luong;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (dataGridViewNhanVien.SelectedRows.Count > 0)
            {
                dataGridViewNhanVien.Rows.RemoveAt(dataGridViewNhanVien.SelectedRows[0].Index);
                MessageBox.Show("Xóa thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa!");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewNhanVien.ColumnCount = 3;
            dataGridViewNhanVien.Columns[0].Name = "MSNV";
            dataGridViewNhanVien.Columns[1].Name = "Tên NV";
            dataGridViewNhanVien.Columns[2].Name = "Lương CB";
        }
    }
}
