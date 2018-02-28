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
    public partial class FRM_AddNewEmp : Form
    {
        public FRM_AddNewEmp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int found = 0;
            if (txtFname.Text.Equals("") || txtUsername.Text.Equals("") || txtPassword.Text.Equals(""))
            {
                MessageBox.Show("الرجاء ادخال البيانات الضرورية");
            }
            else 
            {
                DataTable dt = ClassEmp.getusername();
                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    if (txtUsername.Text.Equals(dt.Rows[j][0].ToString()))
                    {
                        found = 1;
                    }
                }

                if (found != 1)
                {

                    int i = ClassEmp.AddNewEmp(txtUsername.Text, txtPassword.Text, txtFname.Text, txtLname.Text, Qute_enter.CheckState.ToString(), Order_enter.CheckState.ToString(),
                   Order_control.CheckState.ToString(), Order_managment.CheckState.ToString(), Order_view.CheckState.ToString(), Qute_managment.CheckState.ToString(),
                   Qute_view.CheckState.ToString(), AddNewEmp.CheckState.ToString(), Emp_Managment.CheckState.ToString(), Change_Pass.CheckState.ToString(), Backup_Data.CheckState.ToString());
                    MessageBox.Show("تمت عملية اضافة مستخدم جديد بنجاح");
                    txtFname.Text = txtLname.Text = txtPassword.Text = txtUsername.Text = "";
                    Order_control.Checked = Order_enter.Checked = Order_managment.Checked = Order_view.Checked = false;
                    Qute_enter.Checked = Qute_managment.Checked = Qute_view.Checked = false;
                    AddNewEmp.Checked = Emp_Managment.Checked = Change_Pass.Checked = Backup_Data.Checked = false;
                }
                else 
                {

                    MessageBox.Show("اسم المستخدم موجود مسبقا");
                }
                
            }
        }

        
    }
}
