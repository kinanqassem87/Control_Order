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
    public partial class FRM_AllQute : Form
    {
        public FRM_AllQute()
        {
            InitializeComponent();
            display();
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
            try
            {
                txtID.Text = dgvQute.CurrentRow.Cells[0].Value.ToString();
            }
            catch (Exception) { }
        }

        private void btnShowImg_Click(object sender, EventArgs e)
        {
            if (!txtID.Text.Equals(""))
            {
                FRM_ShowImage fr = new FRM_ShowImage(int.Parse(txtID.Text), "ShowQ");
                fr.ShowDialog();
            }
            else 
            {
                MessageBox.Show("الرجاء تحديد عرض اسعار");
            }
        }
    }
}
