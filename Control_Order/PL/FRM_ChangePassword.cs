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
    public partial class FRM_ChangePassword : Form
    {
        public FRM_ChangePassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOld.Text.Equals("") || txtNew.Text.Equals("") || txtConfirm.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء ملىء جميع الحقول");
                }
                else
                {
                    if (txtOld.Text == FRM_Main.emp_pass && txtNew.Text == txtConfirm.Text)
                    {
                        int i = ClassUsers.changpassword(FRM_Main.emp_id, txtNew.Text);
                        FRM_Main.emp_pass = txtNew.Text;
                        MessageBox.Show("تم تغيير كلمة المرور بنجاح");
                        txtNew.Text = txtOld.Text = txtConfirm.Text = "";
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("المعلومات غير متطابقة");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("هناك خطأ في البيانات المدخلة");
            }
        }
    }
}
