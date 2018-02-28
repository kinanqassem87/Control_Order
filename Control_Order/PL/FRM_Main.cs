using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Order.PL
{
    public partial class FRM_Main : Form
    {
        public static int emp_id=0;
        public static string emp_user = "";
        public static string emp_pass = "";
        public static string emp_fname = "";
        public static string emp_lname = "";
        public static string Qute_enter = "";
        public static string Order_enter = "";
        public static string Order_control = "";
        public static string Order_management = "";
        public static string Order_view = "";
        public static string Qute_management = "";
        public static string Qute_view = "";
        public static string emp_enter = "";
        public static string emp_managment = "";
        public static string Change_pass = "";
        public static string Backup_data = "";
        public FRM_Main()
        {
            InitializeComponent();
        }

        private void SignIN_Click(object sender, EventArgs e)
        {
            FRM_SignIn fr = new FRM_SignIn();
            fr.ShowDialog();
        }

        private void FRM_Main_Activated(object sender, EventArgs e)
        {

            if (emp_id != 0) { SignIN.Enabled = false;  SignOut.Enabled = true; }
            if (Qute_enter.Equals("Checked")) { QuteEnter.Enabled = true; }
            if (Order_enter.Equals("Checked")) { OrderEnter.Enabled = true; }
            if (Order_control.Equals("Checked")) { OrderControl.Enabled = true; }
            if (Order_management.Equals("Checked")) { OrderManag.Enabled = true; }
            if (Order_view.Equals("Checked")) { OrderView.Enabled = true; }
            if (Qute_management.Equals("Checked")) { QuteManag.Enabled = true; }
            if (Qute_view.Equals("Checked")) { QuteView.Enabled = true; }
            if (emp_enter.Equals("Checked")) { AddNewUser.Enabled = true; }
            if (emp_managment.Equals("Checked")) { UserManag.Enabled = true; }
            if (Change_pass.Equals("Checked")) { ChangePassword.Enabled = true; }
            if (Backup_data.Equals("Checked")) { BackupData.Enabled = true; }
            toolStripStatusLabel1.Text = "الاسم : " + emp_fname + " " + emp_lname;

        }

        private void SignOut_Click(object sender, EventArgs e)
        {
            SignIN.Enabled = true;
            SignOut.Enabled = QuteEnter.Enabled = OrderEnter.Enabled = OrderControl.Enabled = OrderManag.Enabled = OrderView.Enabled = QuteManag.Enabled =QuteView.Enabled= AddNewUser.Enabled = UserManag.Enabled = ChangePassword.Enabled = BackupData.Enabled = false;
             emp_id=0;
             emp_user = "";
             emp_pass = "";
             emp_fname = "";
             emp_lname = "";
             Qute_enter = "";
             Order_enter = "";
             Order_control = "";
             Order_management = "";
             Order_view = "";
             Qute_management = "";
             Qute_view = "";
             emp_enter = "";
             emp_managment = "";
             Change_pass = "";
             Backup_data = "";
             toolStripStatusLabel1.Text = "الاسم : " + emp_fname + " " + emp_lname;
             FRM_SignIn fr = new FRM_SignIn();
            fr.ShowDialog();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            FRM_ChangePassword fr = new FRM_ChangePassword();
            fr.ShowDialog();
        }

        private void BackupData_Click(object sender, EventArgs e)
        {
            FRM_BackupData fr = new FRM_BackupData();
            fr.ShowDialog();
        }

        private void QuteEnter_Click(object sender, EventArgs e)
        {
            FRM_AddNewQute fr = new FRM_AddNewQute();
            fr.ShowDialog();
        }

        private void OrderEnter_Click(object sender, EventArgs e)
        {
            FRM_AddNewOrder fr = new FRM_AddNewOrder();
            fr.ShowDialog();
        }

        private void OrderControl_Click(object sender, EventArgs e)
        {
            FRM_OrderControl fr = new FRM_OrderControl();
            fr.ShowDialog();
        }

        private void QuteView_Click(object sender, EventArgs e)
        {
            FRM_AllQute fr = new FRM_AllQute();
            fr.ShowDialog();
        }

        private void QuteManag_Click(object sender, EventArgs e)
        {
            FRM_QuteManag fr = new FRM_QuteManag();
            fr.ShowDialog();
        }

        private void OrderView_Click(object sender, EventArgs e)
        {
            FRM_AllOrder fr = new FRM_AllOrder();
            fr.ShowDialog();
        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            FRM_AddNewEmp fr = new FRM_AddNewEmp();
            fr.ShowDialog();
        }

        private void UserManag_Click(object sender, EventArgs e)
        {
            FRM_EmpManagment fr = new FRM_EmpManagment();
            fr.ShowDialog();
        }

        private void About_Click(object sender, EventArgs e)
        {
            FRM_About fr = new FRM_About();
            fr.ShowDialog();
        }

        private void OrderManag_Click(object sender, EventArgs e)
        {
            FRM_OrderManagement fr = new FRM_OrderManagement();
            fr.ShowDialog();
        }

    }
}
