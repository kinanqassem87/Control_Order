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
    public partial class FRM_QuteForOrder : Form
    {
        public FRM_QuteForOrder()
        {
            InitializeComponent();
            display();
        }
        void display() 
        {
            dgvQute.DataSource = ClassQute.selectAllQute();
        }

        private void dgvQute_Click(object sender, EventArgs e)
        {
            try
            {
                txtQuteID.Text = dgvQute.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnchoose_Click(object sender, EventArgs e)
        {
            if (txtQuteID.Text.Equals("")) 
            {
                MessageBox.Show("الرجاء تحديد عرض اسعار أولا");
            }
            else 
            {
                FRM_AddNewOrder.Qute_Id = int.Parse(txtQuteID.Text);
                this.Close();
            }
        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            if (!txtQuteID.Text.Equals(""))
            {
                FRM_ShowImage fr = new FRM_ShowImage(int.Parse(txtQuteID.Text), "ShowQ");
                fr.ShowDialog();
            }
            else 
            {
                MessageBox.Show("الرجاء تحديد عرض اسعار");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvQute.DataSource = ClassQute.searchQuteInOrder(txtSearch.Text);
        }
    }
}
