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
            this.SuspendLayout();
            // 
            // btn_MovieAdd
            // 
            this.btn_MovieAdd.Location = new System.Drawing.Point(24, 43);
            this.btn_MovieAdd.Name = "btn_MovieAdd";
            this.btn_MovieAdd.Size = new System.Drawing.Size(97, 62);
            this.btn_MovieAdd.TabIndex = 0;
            this.btn_MovieAdd.Text = "Thêm phim";
            this.btn_MovieAdd.UseVisualStyleBackColor = true;
            this.btn_MovieAdd.Click += new System.EventHandler(this.btn_MovieAdd_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(340, 43);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(97, 62);
            this.btn_Logout.TabIndex = 1;
            this.btn_Logout.Text = "Đăng xuất";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_AddSchedule
            // 
            this.btn_AddSchedule.Location = new System.Drawing.Point(183, 43);
            this.btn_AddSchedule.Name = "btn_AddSchedule";
            this.btn_AddSchedule.Size = new System.Drawing.Size(97, 62);
            this.btn_AddSchedule.TabIndex = 2;
            this.btn_AddSchedule.Text = "Thêm lịch chiếu";
            this.btn_AddSchedule.UseVisualStyleBackColor = true;
            this.btn_AddSchedule.Click += new System.EventHandler(this.btn_AddSchedule_Click);
            // 
            // frm_EmployeeHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 162);
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
    }
}