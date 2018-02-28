using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Order.BL;

namespace Control_Order.PL
{
    public partial class FRM_EmpManagment : Form
    {
        public FRM_EmpManagment()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvEmp.DataSource = ClassEmp.SelectEmpInfo();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvEmp.DataSource = ClassEmp.SearchEmpInfo(txtSearch.Text);
        }

        private void dgvEmp_DoubleClick(object sender, EventArgs e)
        {
            try
            {

                Order_control.Checked = Order_enter.Checked = Order_managment.Checked = Order_view.Checked = false;
                Qute_enter.Checked = Qute_managment.Checked = Qute_view.Checked = false;
                AddNewEmp.Checked = Emp_Managment.Checked = Change_Pass.Checked = Backup_Data.Checked = false;
                txtID.Text = dgvEmp.CurrentRow.Cells[0].Value.ToString();
                DataTable dt = ClassEmp.selectOnemp(int.Parse(txtID.Text));
                txtUsername.Text = dt.Rows[0][1].ToString();
                txtPassword.Text = dt.Rows[0][2].ToString();
                txtFname.Text = dt.Rows[0][3].ToString();
                txtLname.Text = dt.Rows[0][4].ToString();
                if (dt.Rows[0][5].ToString().Equals("Checked")) { Qute_enter.Checked = true; }
                if (dt.Rows[0][6].ToString().Equals("Checked")) { Order_enter.Checked = true; }
                if (dt.Rows[0][7].ToString().Equals("Checked")) { Order_control.Checked = true; }
                if (dt.Rows[0][8].ToString().Equals("Checked")) { Order_managment.Checked = true; }
                if (dt.Rows[0][9].ToString().Equals("Checked")) { Order_view.Checked = true; }
                if (dt.Rows[0][10].ToString().Equals("Checked")) { Qute_managment.Checked = true; }
                if (dt.Rows[0][11].ToString().Equals("Checked")) { Qute_view.Checked = true; }
                if (dt.Rows[0][12].ToString().Equals("Checked")) { AddNewEmp.Checked = true; }
                if (dt.Rows[0][13].ToString().Equals("Checked")) { Emp_Managment.Checked = true; }
                if (dt.Rows[0][14].ToString().Equals("Checked")) { Change_Pass.Checked = true; }
                if (dt.Rows[0][15].ToString().Equals("Checked")) { Backup_Data.Checked = true; }

            }
            catch (Exception) { }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int found = 0;
            DataTable dt = ClassEmp.empNotExist(int.Parse(txtID.Text), txtUsername.Text);
            if (dt.Rows.Count != 0) { found = 1; }

            if (txtID.Text.Equals("") || txtFname.Text.Equals("") || txtPassword.Text.Equals("") || txtUsername.Text.Equals("")) { MessageBox.Show("الرجاء تعبئة الحقول الاساسية"); }
            else 
            {
                if (found == 1) { MessageBox.Show("اسم المستخدم موجود مسبقا الرجاء اختيار اسم جديد"); }
                else 
                {
                    int i = ClassEmp.UpdateEmp(int.Parse(txtID.Text), txtUsername.Text, txtPassword.Text, txtFname.Text, txtLname.Text, Qute_enter.CheckState.ToString(), Order_enter.CheckState.ToString(),
                   Order_control.CheckState.ToString(), Order_managment.CheckState.ToString(), Order_view.CheckState.ToString(), Qute_managment.CheckState.ToString(),
                   Qute_view.CheckState.ToString(), AddNewEmp.CheckState.ToString(), Emp_Managment.CheckState.ToString(), Change_Pass.CheckState.ToString(), Backup_Data.CheckState.ToString());
                    MessageBox.Show("تمت عملية التعديل بنجاح");
                    txtID.Text = txtFname.Text = txtLname.Text = txtPassword.Text = txtUsername.Text = "";
                    Order_control.Checked = Order_enter.Checked = Order_managment.Checked = Order_view.Checked = false;
                    Qute_enter.Checked = Qute_managment.Checked = Qute_view.Checked = false;
                    AddNewEmp.Checked = Emp_Managment.Checked = Change_Pass.Checked = Backup_Data.Checked = false;
                    display();
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("الرجاء تحديد اسم ");
            }
            else 
            {
                int i = ClassEmp.DeleteEmp(int.Parse(txtID.Text));
                MessageBox.Show("تمت عملية الحذف بنجاح");
                txtID.Text = txtFname.Text = txtLname.Text = txtPassword.Text = txtUsername.Text = "";
                Order_control.Checked = Order_enter.Checked = Order_managment.Checked = Order_view.Checked = false;
                Qute_enter.Checked = Qute_managment.Checked = Qute_view.Checked = false;
                AddNewEmp.Checked = Emp_Managment.Checked = Change_Pass.Checked = Backup_Data.Checked = false;
                display();
            }
        }
    }
}
