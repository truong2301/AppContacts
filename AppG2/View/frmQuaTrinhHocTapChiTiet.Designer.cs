namespace AppG2.View
{
    partial class frmQuaTrinhHocTapChiTiet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numTuNam = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numDenNam = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiHoc = new System.Windows.Forms.TextBox();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnDongY = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTuNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenNam)).BeginInit();
            this.SuspendLayout();
            // 
            // numTuNam
            // 
            this.numTuNam.Location = new System.Drawing.Point(97, 18);
            this.numTuNam.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numTuNam.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numTuNam.Name = "numTuNam";
            this.numTuNam.Size = new System.Drawing.Size(62, 20);
            this.numTuNam.TabIndex = 0;
            this.numTuNam.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numTuNam.ValueChanged += new System.EventHandler(this.numTuNam_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ Năm :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Đến Năm :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // numDenNam
            // 
            this.numDenNam.Location = new System.Drawing.Point(97, 50);
            this.numDenNam.Maximum = new decimal(new int[] {
            2050,
            0,
            0,
            0});
            this.numDenNam.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numDenNam.Name = "numDenNam";
            this.numDenNam.Size = new System.Drawing.Size(62, 20);
            this.numDenNam.TabIndex = 2;
            this.numDenNam.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numDenNam.ValueChanged += new System.EventHandler(this.numDenNam_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nơi học :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNoiHoc
            // 
            this.txtNoiHoc.Location = new System.Drawing.Point(97, 81);
            this.txtNoiHoc.Multiline = true;
            this.txtNoiHoc.Name = "txtNoiHoc";
            this.txtNoiHoc.Size = new System.Drawing.Size(285, 135);
            this.txtNoiHoc.TabIndex = 6;
            this.txtNoiHoc.TextChanged += new System.EventHandler(this.txtNoiHoc_TextChanged);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBoQua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBoQua.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnBoQua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoQua.Image = global::AppG2.Properties.Resources.icons8_cancel_32;
            this.btnBoQua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoQua.Location = new System.Drawing.Point(298, 237);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(86, 50);
            this.btnBoQua.TabIndex = 8;
            this.btnBoQua.Text = "Bỏ Qua";
            this.btnBoQua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnDongY
            // 
            this.btnDongY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDongY.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnDongY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDongY.Image = global::AppG2.Properties.Resources.icons8_ok_hand1;
            this.btnDongY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDongY.Location = new System.Drawing.Point(196, 237);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(86, 50);
            this.btnDongY.TabIndex = 7;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // frmQuaTrinhHocTapChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnBoQua;
            this.ClientSize = new System.Drawing.Size(440, 318);
            this.ControlBox = false;
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtNoiHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numDenNam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numTuNam);
            this.Name = "frmQuaTrinhHocTapChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm mới/ Chỉnh Sửa quá trình học tập";
            ((System.ComponentModel.ISupportInitialize)(this.numTuNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenNam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numTuNam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numDenNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiHoc;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnBoQua;
    }
}