using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2.View
{
    public partial class frmAEContact : Form
    {
        DataGridView dgvContacts;
        int Rowsnum;
        public frmAEContact(DataGridView dgvContacts, string text, int rowsnum = -1)
        {
            InitializeComponent();

            if (rowsnum != -1)
            {
                Rowsnum = rowsnum;
                this.Text = text;
                this.dgvContacts = dgvContacts;
                txtName.Text = dgvContacts.Rows[rowsnum].Cells[1].Value.ToString();
                txtPhone.Text = dgvContacts.Rows[rowsnum].Cells[2].Value.ToString();
                txtEmail.Text = dgvContacts.Rows[rowsnum].Cells[3].Value.ToString();
            }
            else
            {
                this.Text = text;
                this.dgvContacts = dgvContacts;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (this.Text == "Thêm Dữ Liệu")
            {
                Them();
            }
            else
            {
                Sua();
            }

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        private void Them()
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                dgvContacts.Rows.Add(txtName.Text.Substring(0, 1), txtName.Text, txtPhone.Text, txtEmail.Text);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu còn trống", "Thông báo");
            }
        }
        private void Sua()
        {
            if (!string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtPhone.Text) && !string.IsNullOrEmpty(txtEmail.Text))
            {
                dgvContacts.Rows[Rowsnum].Cells[0].Value = txtName.Text.Substring(0, 1);
                dgvContacts.Rows[Rowsnum].Cells[1].Value = txtName.Text;
                dgvContacts.Rows[Rowsnum].Cells[2].Value = txtPhone.Text;
                dgvContacts.Rows[Rowsnum].Cells[3].Value = txtEmail.Text;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập dữ liệu còn trống", "Thông báo");
            }
        }
    }
}
