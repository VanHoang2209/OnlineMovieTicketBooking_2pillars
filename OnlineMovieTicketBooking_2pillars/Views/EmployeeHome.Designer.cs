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
            this.SuspendLayout();
            // 
            // btn_MovieAdd
            // 
            this.btn_MovieAdd.Location = new System.Drawing.Point(24, 43);
            this.btn_MovieAdd.Name = "btn_MovieAdd";
            this.btn_MovieAdd.Size = new System.Drawing.Size(121, 80);
            this.btn_MovieAdd.TabIndex = 0;
            this.btn_MovieAdd.Text = "Quản lý phim";
            this.btn_MovieAdd.UseVisualStyleBackColor = true;
            this.btn_MovieAdd.Click += new System.EventHandler(this.btn_MovieAdd_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(345, 148);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(121, 78);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_AddSchedule
            // 
            this.btn_AddSchedule.Location = new System.Drawing.Point(183, 43);
            this.btn_AddSchedule.Name = "btn_AddSchedule";
            this.btn_AddSchedule.Size = new System.Drawing.Size(121, 80);
            this.btn_AddSchedule.TabIndex = 2;
            this.btn_AddSchedule.Text = "Quản lý lịch chiếu";
            this.btn_AddSchedule.UseVisualStyleBackColor = true;
            this.btn_AddSchedule.Click += new System.EventHandler(this.btn_AddSchedule_Click);
            // 
            // btn_EmployeeAdd
            // 
            this.btn_EmployeeAdd.Location = new System.Drawing.Point(24, 148);
            this.btn_EmployeeAdd.Name = "btn_EmployeeAdd";
            this.btn_EmployeeAdd.Size = new System.Drawing.Size(121, 78);
            this.btn_EmployeeAdd.TabIndex = 3;
            this.btn_EmployeeAdd.Text = "Quản lý nhân viên";
            this.btn_EmployeeAdd.UseVisualStyleBackColor = true;
            this.btn_EmployeeAdd.Click += new System.EventHandler(this.btn_EmployeeAdd_Click);
            // 
            // btn_AccountAdd
            // 
            this.btn_AccountAdd.Location = new System.Drawing.Point(183, 148);
            this.btn_AccountAdd.Name = "btn_AccountAdd";
            this.btn_AccountAdd.Size = new System.Drawing.Size(121, 78);
            this.btn_AccountAdd.TabIndex = 4;
            this.btn_AccountAdd.Text = "Quản lý tài khoản";
            this.btn_AccountAdd.UseVisualStyleBackColor = true;
            this.btn_AccountAdd.Click += new System.EventHandler(this.btn_AccountAdd_Click);
            // 
            // btn_PasswordChange
            // 
            this.btn_PasswordChange.Location = new System.Drawing.Point(345, 45);
            this.btn_PasswordChange.Name = "btn_PasswordChange";
            this.btn_PasswordChange.Size = new System.Drawing.Size(121, 78);
            this.btn_PasswordChange.TabIndex = 5;
            this.btn_PasswordChange.Text = "Đổi mật khẩu";
            this.btn_PasswordChange.UseVisualStyleBackColor = true;
            this.btn_PasswordChange.Click += new System.EventHandler(this.btn_PasswordChange_Click);
            // 
            // frm_EmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 264);
            this.Controls.Add(this.btn_PasswordChange);
            this.Controls.Add(this.btn_AccountAdd);
            this.Controls.Add(this.btn_EmployeeAdd);
            this.Controls.Add(this.btn_AddSchedule);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.btn_MovieAdd);
            this.Name = "frm_EmployeeHome";
            this.Text = "TRANG NHÂN VIÊN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_MovieAdd;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_AddSchedule;
        private System.Windows.Forms.Button btn_EmployeeAdd;
        private System.Windows.Forms.Button btn_AccountAdd;
        private System.Windows.Forms.Button btn_PasswordChange;
    }
}