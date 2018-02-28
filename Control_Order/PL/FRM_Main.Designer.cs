namespace Control_Order.PL
{
    partial class FRM_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SignToProg = new System.Windows.Forms.ToolStripMenuItem();
            this.SignIN = new System.Windows.Forms.ToolStripMenuItem();
            this.SignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BackupData = new System.Windows.Forms.ToolStripMenuItem();
            this.QuteOrderEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.QuteEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.OrderEnter = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderCheck = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderControl = new System.Windows.Forms.ToolStripMenuItem();
            this.DataManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.Qute = new System.Windows.Forms.ToolStripMenuItem();
            this.QuteView = new System.Windows.Forms.ToolStripMenuItem();
            this.QuteManag = new System.Windows.Forms.ToolStripMenuItem();
            this.Order = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderView = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderManag = new System.Windows.Forms.ToolStripMenuItem();
            this.Users = new System.Windows.Forms.ToolStripMenuItem();
            this.AddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.UserManag = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignToProg,
            this.QuteOrderEnter,
            this.OrderCheck,
            this.DataManagement,
            this.Users,
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1103, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SignToProg
            // 
            this.SignToProg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SignIN,
            this.SignOut,
            this.toolStripSeparator2,
            this.ChangePassword,
            this.toolStripSeparator1,
            this.BackupData});
            this.SignToProg.Name = "SignToProg";
            this.SignToProg.Size = new System.Drawing.Size(112, 20);
            this.SignToProg.Text = "الدخول الى البرنامج";
            // 
            // SignIN
            // 
            this.SignIN.Name = "SignIN";
            this.SignIN.Size = new System.Drawing.Size(148, 22);
            this.SignIN.Text = "تسجيل دخول";
            this.SignIN.Click += new System.EventHandler(this.SignIN_Click);
            // 
            // SignOut
            // 
            this.SignOut.Enabled = false;
            this.SignOut.Name = "SignOut";
            this.SignOut.Size = new System.Drawing.Size(148, 22);
            this.SignOut.Text = "تسجيل خروج";
            this.SignOut.Click += new System.EventHandler(this.SignOut_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // ChangePassword
            // 
            this.ChangePassword.Enabled = false;
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(148, 22);
            this.ChangePassword.Text = "تغيير كلمة السر";
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // BackupData
            // 
            this.BackupData.Enabled = false;
            this.BackupData.Name = "BackupData";
            this.BackupData.Size = new System.Drawing.Size(148, 22);
            this.BackupData.Text = "Backup Data";
            this.BackupData.Click += new System.EventHandler(this.BackupData_Click);
            // 
            // QuteOrderEnter
            // 
            this.QuteOrderEnter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuteEnter,
            this.toolStripSeparator3,
            this.OrderEnter});
            this.QuteOrderEnter.Name = "QuteOrderEnter";
            this.QuteOrderEnter.Size = new System.Drawing.Size(144, 20);
            this.QuteOrderEnter.Text = "ادخال العروض و الطلبيات";
            // 
            // QuteEnter
            // 
            this.QuteEnter.Enabled = false;
            this.QuteEnter.Name = "QuteEnter";
            this.QuteEnter.Size = new System.Drawing.Size(188, 22);
            this.QuteEnter.Text = "ادخال عرض اسعار جديد";
            this.QuteEnter.Click += new System.EventHandler(this.QuteEnter_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // OrderEnter
            // 
            this.OrderEnter.Enabled = false;
            this.OrderEnter.Name = "OrderEnter";
            this.OrderEnter.Size = new System.Drawing.Size(188, 22);
            this.OrderEnter.Text = "ادخال طلبية جديدة";
            this.OrderEnter.Click += new System.EventHandler(this.OrderEnter_Click);
            // 
            // OrderCheck
            // 
            this.OrderCheck.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderControl});
            this.OrderCheck.Name = "OrderCheck";
            this.OrderCheck.Size = new System.Drawing.Size(95, 20);
            this.OrderCheck.Text = "مراقبة الطلبيات";
            // 
            // OrderControl
            // 
            this.OrderControl.Enabled = false;
            this.OrderControl.Name = "OrderControl";
            this.OrderControl.Size = new System.Drawing.Size(155, 22);
            this.OrderControl.Text = "التحكم بالطلبيات";
            this.OrderControl.Click += new System.EventHandler(this.OrderControl_Click);
            // 
            // DataManagement
            // 
            this.DataManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Qute,
            this.Order});
            this.DataManagement.Name = "DataManagement";
            this.DataManagement.Size = new System.Drawing.Size(80, 20);
            this.DataManagement.Text = "ادارة البيانات";
            // 
            // Qute
            // 
            this.Qute.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QuteView,
            this.QuteManag});
            this.Qute.Name = "Qute";
            this.Qute.Size = new System.Drawing.Size(152, 22);
            this.Qute.Text = "عروض الاسعار";
            // 
            // QuteView
            // 
            this.QuteView.Enabled = false;
            this.QuteView.Name = "QuteView";
            this.QuteView.Size = new System.Drawing.Size(203, 22);
            this.QuteView.Text = "اظهار جميع عروض الاسعار";
            this.QuteView.Click += new System.EventHandler(this.QuteView_Click);
            // 
            // QuteManag
            // 
            this.QuteManag.Enabled = false;
            this.QuteManag.Name = "QuteManag";
            this.QuteManag.Size = new System.Drawing.Size(203, 22);
            this.QuteManag.Text = "ادارة عروض الاسعار";
            this.QuteManag.Click += new System.EventHandler(this.QuteManag_Click);
            // 
            // Order
            // 
            this.Order.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OrderView,
            this.OrderManag});
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(152, 22);
            this.Order.Text = "الطلبيات";
            // 
            // OrderView
            // 
            this.OrderView.Enabled = false;
            this.OrderView.Name = "OrderView";
            this.OrderView.Size = new System.Drawing.Size(175, 22);
            this.OrderView.Text = "اظهار جميع الطلبيات";
            this.OrderView.Click += new System.EventHandler(this.OrderView_Click);
            // 
            // OrderManag
            // 
            this.OrderManag.Enabled = false;
            this.OrderManag.Name = "OrderManag";
            this.OrderManag.Size = new System.Drawing.Size(175, 22);
            this.OrderManag.Text = "ادارة الطلبيات";
            this.OrderManag.Click += new System.EventHandler(this.OrderManag_Click);
            // 
            // Users
            // 
            this.Users.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewUser,
            this.UserManag});
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(79, 20);
            this.Users.Text = "المستخدمين";
            // 
            // AddNewUser
            // 
            this.AddNewUser.Enabled = false;
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(171, 22);
            this.AddNewUser.Text = "ادخال مستخدم جديد";
            this.AddNewUser.Click += new System.EventHandler(this.AddNewUser_Click);
            // 
            // UserManag
            // 
            this.UserManag.Enabled = false;
            this.UserManag.Name = "UserManag";
            this.UserManag.Size = new System.Drawing.Size(171, 22);
            this.UserManag.Text = "ادارة المستخدمين";
            this.UserManag.Click += new System.EventHandler(this.UserManag_Click);
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(79, 20);
            this.About.Text = "حول البرنامج";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 701);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1103, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "الاسم : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Control_Order.Properties.Resources._12;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1103, 674);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 723);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FRM_Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الواجهة الرئيسية";
            this.Activated += new System.EventHandler(this.FRM_Main_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SignToProg;
        private System.Windows.Forms.ToolStripMenuItem SignIN;
        private System.Windows.Forms.ToolStripMenuItem SignOut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem BackupData;
        private System.Windows.Forms.ToolStripMenuItem QuteOrderEnter;
        private System.Windows.Forms.ToolStripMenuItem QuteEnter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem OrderEnter;
        private System.Windows.Forms.ToolStripMenuItem OrderCheck;
        private System.Windows.Forms.ToolStripMenuItem OrderControl;
        private System.Windows.Forms.ToolStripMenuItem DataManagement;
        private System.Windows.Forms.ToolStripMenuItem Qute;
        private System.Windows.Forms.ToolStripMenuItem QuteView;
        private System.Windows.Forms.ToolStripMenuItem QuteManag;
        private System.Windows.Forms.ToolStripMenuItem Order;
        private System.Windows.Forms.ToolStripMenuItem OrderView;
        private System.Windows.Forms.ToolStripMenuItem OrderManag;
        private System.Windows.Forms.ToolStripMenuItem Users;
        private System.Windows.Forms.ToolStripMenuItem AddNewUser;
        private System.Windows.Forms.ToolStripMenuItem UserManag;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}