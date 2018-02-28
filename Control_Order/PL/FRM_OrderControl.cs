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
    public partial class FRM_OrderControl : Form
    {
        public FRM_OrderControl()
        {
            InitializeComponent();
            display();
            fullcmb();
        }
        void display() 
        {
            dgvOrder.DataSource = ClassOrder.selectOrderControl();
        }
        void fullcmb() 
        {
            DataTable dt=ClassOrder.selectAllStateOrder();
            cmbStateOrder.DataSource = dt;
            cmbStateOrder.DisplayMember = "Order_state";
            cmbStateOrder.ValueMember = "Order_state_id";
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvOrder.DataSource = ClassOrder.searchOrderControl(txtSearch.Text);
        }

        private void dgvOrder_Click(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvOrder.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnShowImg_Click(object sender, EventArgs e)
        {
            if (!txtID.Text.Equals(""))
            {
                FRM_ShowImage fr = new FRM_ShowImage(int.Parse(txtID.Text), "ShowO");
                fr.ShowDialog();
            }
            else 
            {
                MessageBox.Show("الرجاء تحديد طلبية");
            }
        }

        private void btnExcute_Click(object sender, EventArgs e)
        {
            if (!txtID.Text.Equals(""))
            {
                int i = ClassOrder.UpdateStateOrder(int.Parse(txtID.Text), (int)cmbStateOrder.SelectedValue);
                MessageBox.Show("تمت العملية بنجاح");
                txtID.Text = txtSearch.Text = "";
                display();
            }
            else 
            {
                MessageBox.Show("الرجاء تحديد طلبية ");
            }
        }
    }
}
