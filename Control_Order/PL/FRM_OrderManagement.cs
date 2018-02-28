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
    public partial class FRM_OrderManagement : Form
    {
        int QuteID = 0;
        public FRM_OrderManagement()
        {
            InitializeComponent();
            display();
            fullcmb();
        }
        void display() 
        {
            dgvOrder.DataSource = ClassOrder.selectOrder();
        }
        void fullcmb()
        {
            DataTable dt = ClassOrder.selectAllStateOrder();
            cmbState.DataSource = dt;
            cmbState.DisplayMember = "Order_state";
            cmbState.ValueMember = "Order_state_id";

        }

        private void dgvOrder_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvOrder.CurrentRow.Cells[0].Value.ToString();
                txttype.Text = dgvOrder.CurrentRow.Cells[1].Value.ToString();
                txtown.Text = dgvOrder.CurrentRow.Cells[2].Value.ToString();
                txtnum.Text = dgvOrder.CurrentRow.Cells[3].Value.ToString();
                dtpdate.Value = DateTime.Parse(dgvOrder.CurrentRow.Cells[4].Value.ToString());
                rtxtNote.Text = dgvOrder.CurrentRow.Cells[5].Value.ToString();
                cmbState.Text = dgvOrder.CurrentRow.Cells[7].Value.ToString();

                DataTable dt = ClassOrder.selectQuteIdwithOrder(int.Parse(txtID.Text));
                QuteID = int.Parse(dt.Rows[0][0].ToString());
            }
            catch (Exception)
            {

            }
        }

        private void btnShowImg_Click(object sender, EventArgs e)
        {
            if (!txtID.Text.Equals(""))
            {
                FRM_ShowImage fr = new FRM_ShowImage(int.Parse(txtID.Text), "ShowOManag");
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("الرجاء تحديد طلبية");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals("") || txttype.Text.Equals("") || txtown.Text.Equals("") || txtnum.Text.Equals(""))
            {
                MessageBox.Show("الرجاء ملئ جميع الجقول");
            }
            else
            {
                int i = ClassOrder.updateOrder(int.Parse(txtID.Text), txttype.Text, txtown.Text, txtnum.Text, dtpdate.Value, rtxtNote.Text, (int)cmbState.SelectedValue);
                MessageBox.Show("تمت عملية التعديل بنجاح");
                display();
                txtID.Text = txtnum.Text = txtown.Text = txttype.Text = rtxtNote.Text = "";
                QuteID = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("الرجاء تحديد طلبية اولا");
            }
            else 
            {
                int delImg = ClassOrder.deleteImgWithIDOrder(int.Parse(txtID.Text));
                int delOrder = ClassOrder.deleteOrder(int.Parse(txtID.Text));
                int updateQutestate = ClassQute.FreeStatQuteOrder(QuteID);
                MessageBox.Show("تمت عملية الحذف بنجاح");
                display();
                txtID.Text = txtnum.Text = txtown.Text = txttype.Text = rtxtNote.Text = "";
                QuteID = 0;
            }
        }
    }
}
