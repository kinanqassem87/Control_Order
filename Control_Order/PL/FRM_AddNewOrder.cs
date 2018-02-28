using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Control_Order.BL;

namespace Control_Order.PL
{
    public partial class FRM_AddNewOrder : Form
    {
        int NumOfImage = 0;
        List<byte[]> images = new List<byte[]>();
        public static int Qute_Id=0;
        
        public FRM_AddNewOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox img = new PictureBox();
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
                // ofd.Multiselect = true;
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    string[] files = ofd.FileNames;
                    foreach (string fileName in files)
                    {
                        img.Image = Image.FromFile(ofd.FileName);

                        MemoryStream ms = new MemoryStream();
                        img.Image.Save(ms, img.Image.RawFormat);
                        byte[] arr = ms.ToArray();
                        images.Add(arr);

                        NumOfImage++;
                    }
                }
                lbNumIMG.Text = NumOfImage.ToString();
            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            lbNumIMG.Text = "0";
            NumOfImage = 0;
            images.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtType.Text.Equals("") || txtOwnDoc.Text.Equals(""))
                {
                    MessageBox.Show("الرجاء ملئ الحقول الضرورية");
                }
                else
                {

                    int addDoc = ClassOrder.AddNewOrder(txtType.Text, txtOwnDoc.Text, txtNumber.Text, dtpDoc.Value, rtxtNote.Text, 1, Qute_Id, FRM_Main.emp_fname + " " + FRM_Main.emp_lname);
                    if (NumOfImage > 0)
                    {
                        DataTable LastOne = ClassOrder.selectlastOrder();
                        for (int i = 0; i < images.Count; i++)
                        {
                            int AddImg = ClassOrder.AddImageOrder(images[i], int.Parse(LastOne.Rows[0][0].ToString()));
                        }

                    }
                    int updateQute = ClassQute.UpdateStatQute(Qute_Id);
                    Qute_Id = 0;
                    txtNumber.Text = txtOwnDoc.Text = txtType.Text = rtxtNote.Text = "";
                    lbNumIMG.Text = "0";
                    NumOfImage = 0;
                    images.Clear();
                    label7.Text = "0";

                    MessageBox.Show("تمت عملية الحفظ بنجاح");
                }
            }
            catch (Exception) { MessageBox.Show("يجب اختيار عرض اسعار مرتبط بالطلبية"); }
        }

        private void btnChooseQute_Click(object sender, EventArgs e)
        {
            FRM_QuteForOrder fr = new FRM_QuteForOrder();
            fr.ShowDialog();
        }

        private void FRM_AddNewOrder_Activated(object sender, EventArgs e)
        {
            label7.Text = Qute_Id.ToString();
        }
    }
}
