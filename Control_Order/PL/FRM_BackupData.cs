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
    public partial class FRM_BackupData : Form
    {
        public FRM_BackupData()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                fd.ShowDialog();
                txtPath.Text = fd.SelectedPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtPath.Text.Equals(""))
                {
                    string path = string.Format("{0}\\Control_Order-{1}{2}.bak", txtPath.Text, DateTime.Now.ToShortDateString().Replace('/', '-'),
                        DateTime.Now.ToShortTimeString().Replace(':', '-'));
                    ClassUsers.Back_up(path);
                    MessageBox.Show("تم اخذ نسخة احتياطية");
                }
                else { MessageBox.Show("الرجاء اختيار مسار للتخزين"); }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("يرجى التخزين على قرص اخر مختلف عن قرص النظام ");
            }
        }
    }
}
