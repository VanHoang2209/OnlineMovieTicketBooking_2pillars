namespace OnlineMovieTicketBooking_2pillars.Views
{
    partial class frm_EmployeeHome
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
            this.btn_MovieAdd = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_AddSchedule = new System.Windows.Forms.Button();
            this.btn_EmployeeAdd = new System.Windows.Forms.Button();
            this.btn_AccountAdd = new System.Windows.Forms.Button();
            this.btn_PasswordChange = new System.Windows.Forms.Button();
            this.btn_Check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_MovieAdd
            // 
            this.btn_MovieAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MovieAdd.Location = new System.Drawing.Point(36, 183);
            this.btn_MovieAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_MovieAdd.Name = "btn_MovieAdd";
            this.btn_MovieAdd.Size = new System.Drawing.Size(140, 96);
            this.btn_MovieAdd.TabIndex = 1;
            this.btn_MovieAdd.Text = "Quản lý phim";
            this.btn_MovieAdd.UseVisualStyleBackColor = true;
            this.btn_MovieAdd.Click += new System.EventHandler(this.btn_MovieAdd_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(322, 315);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(143, 95);
            this.btn_Logout.TabIndex = 6;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_AddSchedule
            // 
            this.btn_AddSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddSchedule.Location = new System.Drawing.Point(224, 183);
            this.btn_AddSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AddSchedule.Name = "btn_AddSchedule";
            this.btn_AddSchedule.Size = new System.Drawing.Size(145, 96);
            this.btn_AddSchedule.TabIndex = 2;
            this.btn_AddSchedule.Text = "Quản lý lịch chiếu";
            this.btn_AddSchedule.UseVisualStyleBackColor = true;
            this.btn_AddSchedule.Click += new System.EventHandler(this.btn_AddSchedule_Click);
            // 
            // btn_EmployeeAdd
            // 
            this.btn_EmployeeAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EmployeeAdd.Location = new System.Drawing.Point(427, 184);
            this.btn_EmployeeAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_EmployeeAdd.Name = "btn_EmployeeAdd";
            this.btn_EmployeeAdd.Size = new System.Drawing.Size(140, 95);
            this.btn_EmployeeAdd.TabIndex = 3;
            this.btn_EmployeeAdd.Text = "Quản lý nhân viên";
            this.btn_EmployeeAdd.UseVisualStyleBackColor = true;
            this.btn_EmployeeAdd.Click += new System.EventHandler(this.btn_EmployeeAdd_Click);
            // 
            // btn_AccountAdd
            // 
            this.btn_AccountAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AccountAdd.Location = new System.Drawing.Point(614, 184);
            this.btn_AccountAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AccountAdd.Name = "btn_AccountAdd";
            this.btn_AccountAdd.Size = new System.Drawing.Size(145, 95);
            this.btn_AccountAdd.TabIndex = 4;
            this.btn_AccountAdd.Text = "Quản lý tài khoản";
            this.btn_AccountAdd.UseVisualStyleBackColor = true;
            this.btn_AccountAdd.Click += new System.EventHandler(this.btn_AccountAdd_Click);
            // 
            // btn_PasswordChange
            // 
            this.btn_PasswordChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PasswordChange.Location = new System.Drawing.Point(519, 314);
            this.btn_PasswordChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PasswordChange.Name = "btn_PasswordChange";
            this.btn_PasswordChange.Size = new System.Drawing.Size(143, 96);
            this.btn_PasswordChange.TabIndex = 7;
            this.btn_PasswordChange.Text = "Đổi mật khẩu";
            this.btn_PasswordChange.UseVisualStyleBackColor = true;
            this.btn_PasswordChange.Click += new System.EventHandler(this.btn_PasswordChange_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Check.Location = new System.Drawing.Point(122, 314);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(140, 95);
            this.btn_Check.TabIndex = 4;
            this.btn_Check.Text = "Kiểm tra vé";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "CHỨC NĂNG";
            // 
            // frm_EmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.btn_PasswordChange);
            this.Controls.Add(this.btn_AccountAdd);
            this.Controls.Add(this.btn_EmployeeAdd);
            this.Controls.Add(this.btn_AddSchedule);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_MovieAdd);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_EmployeeHome";
            this.Text = "Employee Home";
            this.Load += new System.EventHandler(this.frm_EmployeeHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MovieAdd;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_AddSchedule;
        private System.Windows.Forms.Button btn_EmployeeAdd;
        private System.Windows.Forms.Button btn_AccountAdd;
        private System.Windows.Forms.Button btn_PasswordChange;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Label label1;
    }
}