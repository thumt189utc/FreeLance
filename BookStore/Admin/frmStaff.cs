﻿using BookStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Admin {
    public partial class frmStaff : Form {

        DBConnect db = new DBConnect();
        public frmStaff() {
            InitializeComponent();
            myTable = new DataTable();
            myBindS = new BindingSource();
        }

        //Attribute
        private DataTable myTable;
        private BindingSource myBindS;
        private string[] headerText = { "Mã NV", "Tên nhân viên", "SĐT", "Email", "Địa chỉ", "Tên bộ phận", "Trạng thái", "Tài khoản", "Pass" };
        private int[] size = { 12, 25, 12, 25, 25, 20, 12, 20, 15 };

        //Method
        public void Empty() {
            txtName.Text = "";
            txtName.Enabled = false;
            txtPhone.Text = "";
            txtPhone.Enabled = false;
            txtEmail.Text = "";
            txtEmail.Enabled = false;
            rtbAddress.Text = "";
            rtbAddress.Enabled = false;
            cbbDepartment.Text = "";
            cbbDepartment.Enabled = false;
            cbbStatus.Text = "";
            cbbStatus.Enabled = false;
        }

        public void Enable() {
            txtName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            cbbDepartment.Enabled = true;
            cbbStatus.Enabled = true;
            rtbAddress.Enabled = true;
            btnCancel.Enabled = true;
        }

        //Event
        private void frmStaff_Load(object sender, EventArgs e) {
            // Lấy dữ liệu từ CSDL
            string strCL = "SELECT MANHANVIEN, TENNHANVIEN, SODIENTHOAI, EMAIL, DIACHI, TENBOPHAN,TRANGTHAI, TENTAIKHOAN, MATKHAU FROM NHANVIEN"
                         + " INNER JOIN BOPHAN ON NHANVIEN.MABOPHAN = BOPHAN.MABOPHAN";
            myTable = db.GetData(strCL);

            // Gán dl bảng vào binding, binding gán vào dgv
            myBindS.DataSource = myTable;
            dgvData.DataSource = myBindS;

            // Set size + headerText cho dgv
            for (int i = 0; i < headerText.Length; i++) {
                dgvData.Columns[i].HeaderText = headerText[i];
                dgvData.Columns[i].Width = ((dgvData.Width) / 100) * size[i];
            }

            // Chọn theo chế độ cả hàng
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //Đổ dữ liệu cho ComboBox
            string sqlDp = "Select MABOPHAN, TENBOPHAN from BOPHAN";
            DataTable dtDp = db.GetData(sqlDp);

            cbbDepartment.DataSource = dtDp;
            cbbDepartment.DisplayMember = "TENBOPHAN";
            cbbDepartment.ValueMember = "MABOPHAN";
            cbbDepartment.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbDepartment.AutoCompleteMode = AutoCompleteMode.Suggest;

            cbbStatus.Items.Add(new ComboBoxItem("Đang làm", 1));
            cbbStatus.Items.Add(new ComboBoxItem("Nghỉ làm", 2));
            cbbStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbStatus.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbbStatus.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbbStatus.AutoCompleteMode = AutoCompleteMode.Suggest;

        }

        //Ẩn PASS == "*"
        private void dgvData_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {

            if (e.ColumnIndex == 8 && e.Value != null) {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        //Lọc
        private void txtSearch_TextChanged(object sender, EventArgs e) {
            string loc = string.Format("TENNHANVIEN like '%{0}%' or SODIENTHOAI like '%{1}%' or EMAIL like '%{2}%' or DIACHI like '%{3}%' or TENBOPHAN like '%{4}%' or TENTAIKHOAN like '%{5}%'",
                                        txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text, txtSearch.Text);
            myBindS.Filter = loc;
            dgvData.DataSource = myBindS;
        }

        //Start Add
        private void btnAdd_Click(object sender, EventArgs e) {
            Enable();
            btnSaveAdd.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSaveAdd_Click(object sender, EventArgs e) {
            if (txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || rtbAddress.Text == "") {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                string name = txtName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string address = rtbAddress.Text;
                string selectedValueDepart = cbbDepartment.SelectedValue.ToString();
                int selectedValueStatus = ((ComboBoxItem)cbbStatus.SelectedItem).Value;
                //string selectedValueStatus = cbbStatus.Text;
                string account = "";
                string pass = "";

                string sql = string.Format("INSERT INTO NHANVIEN VALUES (N'{0}', '{1}', '{2}', N'{3}', N'{4}', '{5}', '{6}', '{7}')", name, phone, email, address, selectedValueDepart, selectedValueStatus, account, pass);
                db.UpdataData(sql);

                MessageBox.Show("Thêm mới thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmStaff_Load(null, null);
                Empty();
                btnSaveAdd.Enabled = false;
                btnCancel.Enabled = false;
            }
        }
        //End Add

        //Start Edit
        private void btnEdit_Click(object sender, EventArgs e) {
            try {
                // Tìm vị trí hàng đang chọn
                int choose = dgvData.SelectedRows[0].Index;

                // Lấy ra các giá trị hàng đang chọn
                string id = dgvData.Rows[choose].Cells[0].Value.ToString();
                string name = dgvData.Rows[choose].Cells[1].Value.ToString();
                string phone = dgvData.Rows[choose].Cells[2].Value.ToString();
                string email = dgvData.Rows[choose].Cells[3].Value.ToString();
                string address = dgvData.Rows[choose].Cells[4].Value.ToString();
                string department = dgvData.Rows[choose].Cells[5].Value.ToString();
                int status = int.Parse(dgvData.Rows[choose].Cells[6].Value.ToString());
                string account = dgvData.Rows[choose].Cells[7].Value.ToString();
                string pass = dgvData.Rows[choose].Cells[8].Value.ToString();

                //Đưa dữ liệu đã lấy ra vào TextBox
                Enable();
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
                txtAcount.Enabled = true;
                txtPass.Enabled = true;
                btnSaveEdit.Enabled = true;

                if(status == 1) {
                    cbbStatus.Text = "Đang làm";
                }
                if(status == 2) {
                    cbbStatus.Text = "Nghỉ làm";
                }

                txtID.Text = id;
                txtName.Text = name;
                txtPhone.Text = phone;
                txtEmail.Text = email;
                rtbAddress.Text = address;
                cbbDepartment.Text = department;
                txtAcount.Text = account;
                txtPass.Text = pass;
            }
            catch (Exception) {
                MessageBox.Show("Bạn phải chọn Nhân viên muốn sửa!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e) {
            if (txtName.Text == "" || txtPhone.Text == "" || txtEmail.Text == "" || rtbAddress.Text == "") {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                int id = int.Parse(txtID.Text);
                string name = txtName.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string address = rtbAddress.Text;
                string selectedValueDepart = cbbDepartment.SelectedValue.ToString();
                int selectedValueStatus = ((ComboBoxItem)cbbStatus.SelectedItem).Value;
                //string selectedValueStatus = cbbStatus.Text;
                string account = txtAcount.Text;
                string pass = txtPass.Text;

                string strSQL = string.Format("UPDATE NHANVIEN SET TENNHANVIEN = N'{0}', SODIENTHOAI = '{1}', EMAIL = '{2}', DIACHI = N'{3}', MABOPHAN = '{4}', TRANGTHAI = '{5}', TENTAIKHOAN = '{6}', MATKHAU = '{7}' WHERE MANHANVIEN = '{8}'",
                    name, phone, email, address, selectedValueDepart, selectedValueStatus, account, pass, id);
                db.UpdataData(strSQL);
                MessageBox.Show("Sửa thành công nhân viên có mã là " + id, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmStaff_Load(null, null);
                Empty();
                btnSaveEdit.Enabled = false;
                btnCancel.Enabled = false;
                txtAcount.Text = "";
                txtPass.Text = "";
                txtID.Text = "";
                txtAcount.Enabled = false;
                txtPass.Enabled = false;
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        //End Edit

        //Delete
        private void btnDelete_Click(object sender, EventArgs e) {
            string id = dgvData.Rows[dgvData.SelectedRows[0].Index].Cells[0].Value.ToString();

            string numRecordBillIn = "SELECT count(*) FROM HOADONNHAP WHERE MANHANVIEN = '" + id + "'";
            string numRecordBillOut = "SELECT count(*) FROM HOADONXUAT WHERE MANHANVIEN = '" + id + "'";

            int numBillIn = db.CountRecord(numRecordBillOut);
            int numBillOut = db.CountRecord(numRecordBillIn);

            DialogResult kq = MessageBox.Show("Có " + (numBillIn + numBillOut) + " dữ liệu liên quan đến " + id + " này! \nBạn có muốn xóa không?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes) {
                if (numBillOut > 0 || numBillIn > 0) {
                    MessageBox.Show("Có " + (numBillIn + numBillOut) + " dữ liệu liên quan đến Mã này. \nBạn không thể xóa!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    string delete = "DELETE FROM NHANVIEN WHERE MANHANVIEN = '" + id + "'";
                    db.UpdataData(delete);

                    MessageBox.Show("Xóa thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmStaff_Load(null, null);
                }
                return;
            }
        }
    }
}
