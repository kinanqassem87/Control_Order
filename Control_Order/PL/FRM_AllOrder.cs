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
    public partial class FRM_AllOrder : Form
    {
        public FRM_AllOrder()
        {
            InitializeComponent();
            display();
        }

        void display() 
        {
            dgvOrder.DataSource = ClassOrder.selectOrder();
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
                MessageBox.Show("الرجاء تحديد عرض الطلبية");
            }
        }

        private void dgvOrder_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                txtID.Text = dgvOrder.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception) { }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvOrder.DataSource = ClassOrder.searchOrderAll(txtSearch.Text);
        }
    }
}
