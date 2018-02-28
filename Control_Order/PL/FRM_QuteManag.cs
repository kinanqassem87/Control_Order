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
    public partial class FRM_QuteManag : Form
    {
        public FRM_QuteManag()
        {
            InitializeComponent();
            display();
            cmbState.Items.Add("ready");
            cmbState.Items.Add("Done");
        }
        void display()
        {
            dgvQute.DataSource = ClassQute.selectAllQuteManag();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvQute.DataSource = ClassQute.searchAllQuteManag(txtSearch.Text);
        }

        private void dgvQute_Click(object sender, EventArgs e)
        {
           /* try
            {
                txtID.Text = dgvQute.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception) { }*/
        }

        private void btnShowImg_Click(object sender, EventArgs e)
        {
            if (!txtID.Text.Equals(""))
            {
                FRM_ShowImage fr = new FRM_ShowImage(int.Parse(txtID.Text), "ShowQManag");
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("الرجاء تحديد عرض اسعار");
            }
        }

        private void dgvQute_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvQute.CurrentRow.Cells[0].Value.ToString();
                txttype.Text = dgvQute.CurrentRow.Cells[1].Value.ToString();
                txtown.Text = dgvQute.CurrentRow.Cells[2].Value.ToString();
                txtnum.Text = dgvQute.CurrentRow.Cells[3].Value.ToString();
                dtpdate.Value = DateTime.Parse(dgvQute.CurrentRow.Cells[4].Value.ToString());
                rtxtNote.Text = dgvQute.CurrentRow.Cells[5].Value.ToString();
                cmbState.Text = dgvQute.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception) 
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txttype.Text.Equals("") || txtown.Text.Equals("") || txtnum.Text.Equals(""))
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول");
            }
            else 
            {
                int i = ClassQute.updateQuteManag(int.Parse(txtID.Text), txttype.Text, txtown.Text, txtnum.Text, dtpdate.Value, rtxtNote.Text, cmbState.Text);
                MessageBox.Show("تمت عملية التعديل بنجاح");
                display();
                txtID.Text = txtnum.Text = txtown.Text = txttype.Text = rtxtNote.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int found = 0;
            DataTable dt = ClassQute.selectStateOFQute(int.Parse(txtID.Text));
            if (dt.Rows[0][0].ToString().Equals("Done")) { found = 1; }
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("الرجاء تحديد عرض اسعار");
            }
            else 
            {
                if (found == 0)
                {
                    int delIMG = ClassQute.deleteQutewithAllIMG(int.Parse(txtID.Text));
                    int i = ClassQute.deleteQute(int.Parse(txtID.Text));
                    MessageBox.Show("تمت عملية الحذف بنجاح");
                    display();
                    txtID.Text = txtnum.Text = txtown.Text = txttype.Text = rtxtNote.Text = "";
                }
                else 
                {
                    MessageBox.Show("لا يمكن حذف هذا العرض هناك طلبية مرتبطة به");
                }
            }
        }
    }
}
