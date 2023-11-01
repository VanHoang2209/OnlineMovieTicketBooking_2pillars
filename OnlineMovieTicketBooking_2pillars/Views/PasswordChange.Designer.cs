namespace OnlineMovieTicketBooking_2pillars.Views
{
    partial class frm_PasswordChange
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CurrentPassword = new System.Windows.Forms.TextBox();
            this.txt_NewPassword = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.err_Warning = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txt_CurrentPassword
            // 
            this.txt_CurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CurrentPassword.Location = new System.Drawing.Point(259, 127);
            this.txt_CurrentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CurrentPassword.Name = "txt_CurrentPassword";
            this.txt_CurrentPassword.Size = new System.Drawing.Size(265, 27);
            this.txt_CurrentPassword.TabIndex = 1;
            // 
            // txt_NewPassword
            // 
            this.txt_NewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NewPassword.Location = new System.Drawing.Point(259, 189);
            this.txt_NewPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_NewPassword.Name = "txt_NewPassword";
            this.txt_NewPassword.Size = new System.Drawing.Size(265, 27);
            this.txt_NewPassword.TabIndex = 2;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(288, 263);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(104, 46);
            this.btn_Back.TabIndex = 3;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.Location = new System.Drawing.Point(415, 263);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(109, 46);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "Xác nhận";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // err_Warning
            // 
            this.err_Warning.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "ĐỔI MẬT KHẨU";
            // 
            // frm_PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.txt_NewPassword);
            this.Controls.Add(this.txt_CurrentPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_PasswordChange";
            this.Text = "Password Change";
            this.Load += new System.EventHandler(this.frm_PasswordChange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CurrentPassword;
        private System.Windows.Forms.TextBox txt_NewPassword;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.ErrorProvider err_Warning;
        private System.Windows.Forms.Label label3;
    }
}