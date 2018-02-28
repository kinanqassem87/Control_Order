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
    public partial class FRM_SignIn : Form
    {
        string stateEnter = "";
        public FRM_SignIn()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            DataTable dt = ClassUsers.selectAllEmp();
            if (txtUserName.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("الرجاء تعبئة كل الحقول");
            }
            else
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][1].Equals(txtUserName.Text))
                    {
                        if (dt.Rows[i][2].Equals(txtPassword.Text))
                        {
                            Close();
                            stateEnter = "1";
                            FRM_Main.emp_id = int.Parse(dt.Rows[i][0].ToString());
                            FRM_Main.emp_user = dt.Rows[i][1].ToString();
                            FRM_Main.emp_pass = dt.Rows[i][2].ToString();
                            FRM_Main.emp_fname = dt.Rows[i][3].ToString();
                            FRM_Main.emp_lname = dt.Rows[i][4].ToString();
                            FRM_Main.Qute_enter = dt.Rows[i][5].ToString();
                            FRM_Main.Order_enter = dt.Rows[i][6].ToString();
                            FRM_Main.Order_control = dt.Rows[i][7].ToString();
                            FRM_Main.Order_management = dt.Rows[i][8].ToString();
                            FRM_Main.Order_view = dt.Rows[i][9].ToString();
                            FRM_Main.Qute_management = dt.Rows[i][10].ToString();
                            FRM_Main.Qute_view = dt.Rows[i][11].ToString();
                            FRM_Main.emp_enter = dt.Rows[i][12].ToString();
                            FRM_Main.emp_managment = dt.Rows[i][13].ToString();
                            FRM_Main.Change_pass = dt.Rows[i][14].ToString();
                            FRM_Main.Backup_data = dt.Rows[i][15].ToString();
                            
                        }

                    }
                }
                if (!stateEnter.Equals("1"))
                {
                    MessageBox.Show("اسم المستخدم أو كلمة السر غير صحيحة");
                    txtUserName.Text = txtPassword.Text = "";
                }

            }
        }
    }
}
