using AppG2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppG2.View
{
    public partial class frmContacts : Form
    {
        string pathContacts;

        public frmContacts()
        {
            InitializeComponent();


        }
        List<Contacts> lsContacts = new List<Contacts>();
        private void btnClose_Click(object sender, EventArgs e)
        {
             DialogResult result= MessageBox.Show("Bạn muốn thoát?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if ( result == DialogResult.OK)
            {
                Application.Exit();
            }
            
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.ForeColor = Color.Black;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmContacts_Load(object sender, EventArgs e)
        {
            pathContacts = Application.StartupPath + @"\Data\Contacts.txt";
            if (File.Exists(pathContacts))
            {
                var listLines = File.ReadAllLines(pathContacts);
                foreach (var line in listLines)
                {
                    var rs = line.Split(new char[] { '|' });
                    dgvContacts.Rows.Add(rs[0].Substring(0,1),rs[0], rs[1], rs[2]);

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = new frmAEContact(dgvContacts,"Thêm Dữ Liệu");
            frm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var frm = new frmAEContact(dgvContacts,"Sửa Dữ Liệu", dgvContacts.CurrentCell.RowIndex);
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgvContacts.Rows.RemoveAt(dgvContacts.CurrentCell.RowIndex);
            bindingContacts.DataSource = dgvContacts.DataSource;
        }


        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchValue = txtSearch.Text;
                dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dgvContacts.Rows)
                    {
                        row.Selected = false;
                        if (row.Cells[1].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                        }
                        if (row.Cells[2].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                        }
                        if (row.Cells[3].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                        }
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            SortBy('A');
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            SortBy('D');
        }
        /// <summary>
        /// Sort theo kí tự bắt đầu
        /// Trường đẹp trai
        /// </summary>
        /// <param name="ASC">Kí tự bắt đầu</param>
        private void SortBy(char ASC)
        {
            dgvContacts.Sort(KiTu, ListSortDirection.Ascending);
            int converASC = (int)ASC;
            foreach(DataGridViewRow row in dgvContacts.Rows)
            {
                row.Visible = true;
                int ascNow = (int)char.Parse(row.Cells[0].Value.ToString());
                if (ascNow < converASC)
                {
                    row.Visible = false;
                }
            }
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            SortBy('G');
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            SortBy('J');
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            SortBy('M');
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            SortBy('P');
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            SortBy('S');
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            SortBy('V');
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            SortBy('Z');
        }
    }
}
