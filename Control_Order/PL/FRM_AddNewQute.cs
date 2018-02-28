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
    public partial class FRM_AddNewQute : Form
    {
        int NumOfImage = 0;
        List<byte[]> images = new List<byte[]>();
        public FRM_AddNewQute()
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
            if (txtType.Text.Equals("") || txtOwnDoc.Text.Equals(""))
            {
                MessageBox.Show("الرجاء ملئ الحقول الضرورية");
            }
            else
            {
                int addDoc = ClassQute.AddNewQute(txtType.Text, txtOwnDoc.Text, txtNumber.Text, dtpDoc.Value, rtxtNote.Text,"ready",FRM_Main.emp_fname+" "+FRM_Main.emp_lname);
                if (NumOfImage > 0)
                {
                    DataTable LastOne = ClassQute.selectLastQute();
                    for (int i = 0; i < images.Count; i++)
                    {
                        int AddImg = ClassQute.AddImgQute(images[i], int.Parse(LastOne.Rows[0][0].ToString()));
                    }
                }
                txtNumber.Text = txtOwnDoc.Text = txtType.Text = rtxtNote.Text = "";
                lbNumIMG.Text = "0";
                NumOfImage = 0;
                images.Clear();
                MessageBox.Show("تمت عملية الحفظ بنجاح");
            }
        }
    }
}
