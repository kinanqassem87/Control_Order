﻿namespace Control_Order.PL
{
    partial class FRM_AddNewEmp
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Backup_Data = new System.Windows.Forms.CheckBox();
            this.Change_Pass = new System.Windows.Forms.CheckBox();
            this.Emp_Managment = new System.Windows.Forms.CheckBox();
            this.Order_managment = new System.Windows.Forms.CheckBox();
            this.Order_view = new System.Windows.Forms.CheckBox();
            this.Qute_managment = new System.Windows.Forms.CheckBox();
            this.Qute_view = new System.Windows.Forms.CheckBox();
            this.Order_control = new System.Windows.Forms.CheckBox();
            this.AddNewEmp = new System.Windows.Forms.CheckBox();
            this.Order_enter = new System.Windows.Forms.CheckBox();
            this.Qute_enter = new System.Windows.Forms.CheckBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم الاول :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المستخدم: ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(28, 100);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(315, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(28, 74);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(315, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(28, 48);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(315, 20);
            this.txtLname.TabIndex = 5;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(28, 22);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(315, 20);
            this.txtFname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "كلمة السر :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "اسم المستخدم :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "الاسم الاخير :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Backup_Data);
            this.groupBox2.Controls.Add(this.Change_Pass);
            this.groupBox2.Controls.Add(this.Emp_Managment);
            this.groupBox2.Controls.Add(this.Order_managment);
            this.groupBox2.Controls.Add(this.Order_view);
            this.groupBox2.Controls.Add(this.Qute_managment);
            this.groupBox2.Controls.Add(this.Qute_view);
            this.groupBox2.Controls.Add(this.Order_control);
            this.groupBox2.Controls.Add(this.AddNewEmp);
            this.groupBox2.Controls.Add(this.Order_enter);
            this.groupBox2.Controls.Add(this.Qute_enter);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "السماحيات : ";
            // 
            // Backup_Data
            // 
            this.Backup_Data.AutoSize = true;
            this.Backup_Data.Location = new System.Drawing.Point(41, 88);
            this.Backup_Data.Name = "Backup_Data";
            this.Backup_Data.Size = new System.Drawing.Size(86, 17);
            this.Backup_Data.TabIndex = 10;
            this.Backup_Data.Text = "backup Data";
            this.Backup_Data.UseVisualStyleBackColor = true;
            // 
            // Change_Pass
            // 
            this.Change_Pass.AutoSize = true;
            this.Change_Pass.Location = new System.Drawing.Point(28, 65);
            this.Change_Pass.Name = "Change_Pass";
            this.Change_Pass.Size = new System.Drawing.Size(99, 17);
            this.Change_Pass.TabIndex = 9;
            this.Change_Pass.Text = "تغيير كلمة السر";
            this.Change_Pass.UseVisualStyleBackColor = true;
            // 
            // Emp_Managment
            // 
            this.Emp_Managment.AutoSize = true;
            this.Emp_Managment.Location = new System.Drawing.Point(18, 42);
            this.Emp_Managment.Name = "Emp_Managment";
            this.Emp_Managment.Size = new System.Drawing.Size(109, 17);
            this.Emp_Managment.TabIndex = 8;
            this.Emp_Managment.Text = "ادارة المستخدمين";
            this.Emp_Managment.UseVisualStyleBackColor = true;
            // 
            // Order_managment
            // 
            this.Order_managment.AutoSize = true;
            this.Order_managment.Location = new System.Drawing.Point(354, 88);
            this.Order_managment.Name = "Order_managment";
            this.Order_managment.Size = new System.Drawing.Size(87, 17);
            this.Order_managment.TabIndex = 7;
            this.Order_managment.Text = "ادارة الطلبيات";
            this.Order_managment.UseVisualStyleBackColor = true;
            // 
            // Order_view
            // 
            this.Order_view.AutoSize = true;
            this.Order_view.Location = new System.Drawing.Point(351, 65);
            this.Order_view.Name = "Order_view";
            this.Order_view.Size = new System.Drawing.Size(90, 17);
            this.Order_view.TabIndex = 6;
            this.Order_view.Text = "اظهار الطلبيات";
            this.Order_view.UseVisualStyleBackColor = true;
            // 
            // Qute_managment
            // 
            this.Qute_managment.AutoSize = true;
            this.Qute_managment.Location = new System.Drawing.Point(187, 65);
            this.Qute_managment.Name = "Qute_managment";
            this.Qute_managment.Size = new System.Drawing.Size(116, 17);
            this.Qute_managment.TabIndex = 5;
            this.Qute_managment.Text = "ادارة عروض الاسعار";
            this.Qute_managment.UseVisualStyleBackColor = true;
            // 
            // Qute_view
            // 
            this.Qute_view.AutoSize = true;
            this.Qute_view.Location = new System.Drawing.Point(184, 42);
            this.Qute_view.Name = "Qute_view";
            this.Qute_view.Size = new System.Drawing.Size(119, 17);
            this.Qute_view.TabIndex = 4;
            this.Qute_view.Text = "اظهار عروض الاسعار";
            this.Qute_view.UseVisualStyleBackColor = true;
            // 
            // Order_control
            // 
            this.Order_control.AutoSize = true;
            this.Order_control.Location = new System.Drawing.Point(340, 42);
            this.Order_control.Name = "Order_control";
            this.Order_control.Size = new System.Drawing.Size(101, 17);
            this.Order_control.TabIndex = 3;
            this.Order_control.Text = "التحكم بالطلبيات";
            this.Order_control.UseVisualStyleBackColor = true;
            // 
            // AddNewEmp
            // 
            this.AddNewEmp.AutoSize = true;
            this.AddNewEmp.Location = new System.Drawing.Point(6, 19);
            this.AddNewEmp.Name = "AddNewEmp";
            this.AddNewEmp.Size = new System.Drawing.Size(121, 17);
            this.AddNewEmp.TabIndex = 2;
            this.AddNewEmp.Text = "ادخال مستخدم جديد";
            this.AddNewEmp.UseVisualStyleBackColor = true;
            // 
            // Order_enter
            // 
            this.Order_enter.AutoSize = true;
            this.Order_enter.Location = new System.Drawing.Point(362, 19);
            this.Order_enter.Name = "Order_enter";
            this.Order_enter.Size = new System.Drawing.Size(79, 17);
            this.Order_enter.TabIndex = 1;
            this.Order_enter.Text = "ادخال طلبية";
            this.Order_enter.UseVisualStyleBackColor = true;
            // 
            // Qute_enter
            // 
            this.Qute_enter.AutoSize = true;
            this.Qute_enter.Location = new System.Drawing.Point(194, 19);
            this.Qute_enter.Name = "Qute_enter";
            this.Qute_enter.Size = new System.Drawing.Size(109, 17);
            this.Qute_enter.TabIndex = 0;
            this.Qute_enter.Text = "ادخال عرض اسعار";
            this.Qute_enter.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(61, 297);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(129, 23);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "حفظ";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(313, 297);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FRM_AddNewEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 330);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_AddNewEmp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "اضافة مستخدم جديد";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox Order_managment;
        private System.Windows.Forms.CheckBox Order_view;
        private System.Windows.Forms.CheckBox Qute_managment;
        private System.Windows.Forms.CheckBox Qute_view;
        private System.Windows.Forms.CheckBox Order_control;
        private System.Windows.Forms.CheckBox AddNewEmp;
        private System.Windows.Forms.CheckBox Order_enter;
        private System.Windows.Forms.CheckBox Qute_enter;
        private System.Windows.Forms.CheckBox Backup_Data;
        private System.Windows.Forms.CheckBox Change_Pass;
        private System.Windows.Forms.CheckBox Emp_Managment;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnCancel;
    }
}