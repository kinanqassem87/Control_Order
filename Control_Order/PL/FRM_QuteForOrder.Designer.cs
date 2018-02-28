namespace Control_Order.PL
{
    partial class FRM_QuteForOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnchoose = new System.Windows.Forms.Button();
            this.btnShowImage = new System.Windows.Forms.Button();
            this.txtQuteID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvQute = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQute)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnchoose);
            this.groupBox1.Controls.Add(this.btnShowImage);
            this.groupBox1.Controls.Add(this.txtQuteID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnchoose
            // 
            this.btnchoose.Location = new System.Drawing.Point(514, 20);
            this.btnchoose.Name = "btnchoose";
            this.btnchoose.Size = new System.Drawing.Size(107, 23);
            this.btnchoose.TabIndex = 3;
            this.btnchoose.Text = "اختيار هذا العرض";
            this.btnchoose.UseVisualStyleBackColor = true;
            this.btnchoose.Click += new System.EventHandler(this.btnchoose_Click);
            // 
            // btnShowImage
            // 
            this.btnShowImage.Location = new System.Drawing.Point(659, 18);
            this.btnShowImage.Name = "btnShowImage";
            this.btnShowImage.Size = new System.Drawing.Size(144, 23);
            this.btnShowImage.TabIndex = 2;
            this.btnShowImage.Text = "عرض الصورة";
            this.btnShowImage.UseVisualStyleBackColor = true;
            this.btnShowImage.Click += new System.EventHandler(this.btnShowImage_Click);
            // 
            // txtQuteID
            // 
            this.txtQuteID.Location = new System.Drawing.Point(809, 20);
            this.txtQuteID.Name = "txtQuteID";
            this.txtQuteID.ReadOnly = true;
            this.txtQuteID.Size = new System.Drawing.Size(90, 20);
            this.txtQuteID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(905, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الرقم المتسلسل :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvQute);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1006, 533);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dgvQute
            // 
            this.dgvQute.AllowUserToAddRows = false;
            this.dgvQute.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvQute.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvQute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQute.Location = new System.Drawing.Point(3, 16);
            this.dgvQute.MultiSelect = false;
            this.dgvQute.Name = "dgvQute";
            this.dgvQute.ReadOnly = true;
            this.dgvQute.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQute.Size = new System.Drawing.Size(1000, 514);
            this.dgvQute.TabIndex = 0;
            this.dgvQute.Click += new System.EventHandler(this.dgvQute_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(49, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(308, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "بحث : ";
            // 
            // FRM_QuteForOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 620);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_QuteForOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عروض الاسعار ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnchoose;
        private System.Windows.Forms.Button btnShowImage;
        private System.Windows.Forms.TextBox txtQuteID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvQute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
    }
}