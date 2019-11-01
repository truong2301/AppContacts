using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppG2.Model;
namespace AppG2.View
{
    public partial class frmQuaTrinhHocTapChiTiet : Form
    {
        HistoryLearning history;
        public frmQuaTrinhHocTapChiTiet(HistoryLearning history = null)
        {
            InitializeComponent();
            this.history = history;
            if (history !=null)
            {
                this.Text = "Chỉnh sửa quá trình học tập";
                numTuNam.Value = history.YearFrom;
                numDenNam.Value = history.YearEnd;
                txtNoiHoc.Text = history.Address;
            }
            else
            {
                this.Text = "Thêm mới quá trình học tập";

            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (history !=null)
            {

            }
            else
            {

            }
            MessageBox.Show("Đã cập nhật dữ liệu thành công");
            DialogResult = DialogResult.OK;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {

        }

        private void txtNoiHoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numDenNam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numTuNam_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
