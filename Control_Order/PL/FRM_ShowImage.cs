using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Control_Order.BL;
using System.IO;
using System.Drawing.Printing;


namespace Control_Order.PL
{
      
    public partial class FRM_ShowImage : Form
    {
        int DocID;
        int numOfImag = 0;
        int counter = 1;
        string ss = "";
        DataTable dt = new DataTable();
        byte[] arr;
        public FRM_ShowImage(int id,string s)
        {
            InitializeComponent();
            DocID = id;
            ss = s;
            if (s.Equals("ShowQ")) 
            {
                btnSave.Visible = btnDelete.Visible = btnSelectOne.Visible = btnExport.Visible = btnPrint.Visible = false;
                dt = ClassQute.selectimgforQute(DocID);
            }

            if (s.Equals("ShowO"))
            {
                btnSave.Visible = btnDelete.Visible = btnSelectOne.Visible = btnExport.Visible = btnPrint.Visible = false;
                dt = ClassOrder.selectImgOrder(DocID);
            }
            if (s.Equals("ShowQManag"))
            {
                dt = ClassQute.selectimgforQute(DocID);
            }
            if (s.Equals("ShowOManag"))
            {
                dt = ClassOrder.selectImgOrder(DocID);
            }
            
            numOfImag = dt.Rows.Count;
            try
            {
                txtIMGid.Text = dt.Rows[0][0].ToString();
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                picImage.Image = Image.FromStream(ms);
            }
            catch (Exception) { }
        }

        private void btnNextIMG_Click(object sender, EventArgs e)
        {
            if (numOfImag > 0)
            {
                try
                {
                    txtIMGid.Text = dt.Rows[counter][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[counter][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    counter++;
                }
                catch (Exception)
                {
                    txtIMGid.Text = dt.Rows[0][0].ToString();
                    byte[] arr = (byte[])(dt.Rows[0][1]);
                    MemoryStream ms = new MemoryStream(arr);
                    picImage.Image = Image.FromStream(ms);
                    counter = 1;
                }
            }
        }

        private void btnFirstIMG_Click(object sender, EventArgs e)
        {
            if (numOfImag > 0)
            {
                txtIMGid.Text = dt.Rows[0][0].ToString();
                byte[] arr = (byte[])(dt.Rows[0][1]);
                MemoryStream ms = new MemoryStream(arr);
                picImage.Image = Image.FromStream(ms);
                counter = 1;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
             PrintDocument pd = new PrintDocument();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            //PrintDialog myPrinDialog1 = new PrintDialog();
           // pd.PrintPage += PrintPage;

            ppd.Document = pd;
            ppd.Width = 595;
            ppd.Height = 842;
            ppd.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (picImage.Image == null) { MessageBox.Show("No Image Selected !!."); }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                // saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif"; 
                saveFileDialog1.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.  

                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    picImage.Image.Save(fs, picImage.Image.RawFormat);
                    MessageBox.Show("تمت تصدير الصورة بنجاح");
                }


            }
        }

        private void btnSelectOne_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Please Select Images";
                ofd.Filter = "JPG|*.jpg|JPEG|*.jpeg|GIF|*.gif|PNG|*.png";
                DialogResult dr = ofd.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    picImage.Image = Image.FromFile(ofd.FileName);

                    MemoryStream ms = new MemoryStream();
                    picImage.Image.Save(ms, picImage.Image.RawFormat);
                    arr = ms.ToArray();

                    txtIMGid.Text = "";

                }

            }
            catch (Exception) { MessageBox.Show("Wrong with Selected Image..\n Image Not Selected"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ss.Equals("ShowQManag"))
            {
                try
                {
                    if (txtIMGid.Text.Equals("") && picImage.Image != null)
                    {
                        int addIMG = ClassQute.AddImgQute(arr, DocID);
                        dt = ClassQute.selectimgforQute(DocID);

                        MessageBox.Show("Done . .");
                        numOfImag = dt.Rows.Count;
                        btnFirstIMG_Click(null, null);
                    }

                }
                catch (Exception) { }
            }
            else if (ss.Equals("ShowOManag")) 
            {
                try
                {
                    if (txtIMGid.Text.Equals("") && picImage.Image != null)
                    {
                        int addIMG = ClassOrder.AddImageOrder(arr, DocID);
                        dt = ClassOrder.selectImgOrder(DocID);

                        MessageBox.Show("Done . .");
                        numOfImag = dt.Rows.Count;
                        btnFirstIMG_Click(null, null);
                    }

                }
                catch (Exception) { }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtIMGid.Text.Equals(""))
            {
                picImage.Image = null;
            }
            else
            {
                if (ss.Equals("ShowQManag"))
                {

                    int delImage = ClassQute.deleteQuteImg(int.Parse(txtIMGid.Text));
                    dt = ClassQute.selectimgforQute(DocID);

                    MessageBox.Show("Done . .");
                    txtIMGid.Text = "";
                    picImage.Image = null;
                }
                else if (ss.Equals("ShowOManag")) 
                {
                    int delImage = ClassOrder.deleteImgForOrder(int.Parse(txtIMGid.Text));
                    dt = ClassOrder.selectImgOrder(DocID);

                    MessageBox.Show("Done . .");
                    txtIMGid.Text = "";
                    picImage.Image = null;
                }
            }
            numOfImag = dt.Rows.Count;
            btnFirstIMG_Click(null, null);
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            /*
            PrintDocument pd = new PrintDocument();
            PrintPreviewDialog ppd = new PrintPreviewDialog();
            //PrintDialog myPrinDialog1 = new PrintDialog();
            pd.PrintPage += PrintPage;

            ppd.Document = pd;
            ppd.Width = 595;
            ppd.Height = 842;
            ppd.ShowDialog();
             * */
        }
    }
}
