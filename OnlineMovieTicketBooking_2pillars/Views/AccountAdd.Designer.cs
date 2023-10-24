namespace OnlineMovieTicketBooking_2pillars.Views
{
    partial class frm_AccountAdd
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
            this.grb_AccountInfo = new System.Windows.Forms.GroupBox();
            this.cmb_Role = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Employee = new System.Windows.Forms.ComboBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.Mã = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_AccountList = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Permission = new System.Windows.Forms.Button();
            this.btn_Disable = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.err_Warning = new System.Windows.Forms.ErrorProvider(this.components);
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_AccountInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccountList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_AccountInfo
            // 
            this.grb_AccountInfo.Controls.Add(this.cmb_Role);
            this.grb_AccountInfo.Controls.Add(this.label4);
            this.grb_AccountInfo.Controls.Add(this.cmb_Employee);
            this.grb_AccountInfo.Controls.Add(this.txt_Password);
            this.grb_AccountInfo.Controls.Add(this.txt_Username);
            this.grb_AccountInfo.Controls.Add(this.txt_ID);
            this.grb_AccountInfo.Controls.Add(this.Mã);
            this.grb_AccountInfo.Controls.Add(this.label3);
            this.grb_AccountInfo.Controls.Add(this.label2);
            this.grb_AccountInfo.Controls.Add(this.label1);
            this.grb_AccountInfo.Location = new System.Drawing.Point(12, 23);
            this.grb_AccountInfo.Name = "grb_AccountInfo";
            this.grb_AccountInfo.Size = new System.Drawing.Size(442, 271);
            this.grb_AccountInfo.TabIndex = 0;
            this.grb_AccountInfo.TabStop = false;
            this.grb_AccountInfo.Text = "Thông tin tài khoản";
            // 
            // cmb_Role
            // 
            this.cmb_Role.FormattingEnabled = true;
            this.cmb_Role.Location = new System.Drawing.Point(335, 34);
            this.cmb_Role.Name = "cmb_Role";
            this.cmb_Role.Size = new System.Drawing.Size(67, 24);
            this.cmb_Role.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Role";
            // 
            // cmb_Employee
            // 
            this.cmb_Employee.FormattingEnabled = true;
            this.cmb_Employee.Location = new System.Drawing.Point(112, 210);
            this.cmb_Employee.Name = "cmb_Employee";
            this.cmb_Employee.Size = new System.Drawing.Size(236, 24);
            this.cmb_Employee.TabIndex = 7;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(112, 153);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(180, 22);
            this.txt_Password.TabIndex = 6;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(112, 95);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(180, 22);
            this.txt_Username.TabIndex = 5;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(112, 34);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_ID.TabIndex = 4;
            // 
            // Mã
            // 
            this.Mã.AutoSize = true;
            this.Mã.Location = new System.Drawing.Point(24, 40);
            this.Mã.Name = "Mã";
            this.Mã.Size = new System.Drawing.Size(26, 16);
            this.Mã.TabIndex = 3;
            this.Mã.Text = "Mã";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // dgv_AccountList
            // 
            this.dgv_AccountList.AllowUserToAddRows = false;
            this.dgv_AccountList.AllowUserToDeleteRows = false;
            this.dgv_AccountList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AccountList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AccountList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Username,
            this.col_EmployeeName,
            this.col_Role});
            this.dgv_AccountList.Location = new System.Drawing.Point(460, 23);
            this.dgv_AccountList.Name = "dgv_AccountList";
            this.dgv_AccountList.ReadOnly = true;
            this.dgv_AccountList.RowHeadersWidth = 51;
            this.dgv_AccountList.RowTemplate.Height = 24;
            this.dgv_AccountList.Size = new System.Drawing.Size(571, 342);
            this.dgv_AccountList.TabIndex = 1;
            this.dgv_AccountList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AccountList_CellClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(27, 313);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(78, 43);
            this.btn_Add.TabIndex = 10;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Permission
            // 
            this.btn_Permission.Location = new System.Drawing.Point(138, 313);
            this.btn_Permission.Name = "btn_Permission";
            this.btn_Permission.Size = new System.Drawing.Size(78, 43);
            this.btn_Permission.TabIndex = 11;
            this.btn_Permission.Text = "Cấp quyền";
            this.btn_Permission.UseVisualStyleBackColor = true;
            this.btn_Permission.Click += new System.EventHandler(this.btn_Permisson_Click);
            // 
            // btn_Disable
            // 
            this.btn_Disable.Location = new System.Drawing.Point(251, 313);
            this.btn_Disable.Name = "btn_Disable";
            this.btn_Disable.Size = new System.Drawing.Size(78, 43);
            this.btn_Disable.TabIndex = 13;
            this.btn_Disable.Text = "Vô hiệu";
            this.btn_Disable.UseVisualStyleBackColor = true;
            this.btn_Disable.Click += new System.EventHandler(this.btn_Disable_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(360, 313);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(78, 43);
            this.btn_Back.TabIndex = 14;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // err_Warning
            // 
            this.err_Warning.ContainerControl = this;
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "Mã";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Username
            // 
            this.col_Username.HeaderText = "Tên tài khoản";
            this.col_Username.MinimumWidth = 6;
            this.col_Username.Name = "col_Username";
            this.col_Username.ReadOnly = true;
            // 
            // col_EmployeeName
            // 
            this.col_EmployeeName.HeaderText = "Tên nhân viên";
            this.col_EmployeeName.MinimumWidth = 6;
            this.col_EmployeeName.Name = "col_EmployeeName";
            this.col_EmployeeName.ReadOnly = true;
            // 
            // col_Role
            // 
            this.col_Role.HeaderText = "Role";
            this.col_Role.MinimumWidth = 6;
            this.col_Role.Name = "col_Role";
            this.col_Role.ReadOnly = true;
            // 
            // frm_AccountAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 377);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Disable);
            this.Controls.Add(this.btn_Permission);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_AccountList);
            this.Controls.Add(this.grb_AccountInfo);
            this.Name = "frm_AccountAdd";
            this.Text = "THÊM TÀI KHOẢN";
            this.grb_AccountInfo.ResumeLayout(false);
            this.grb_AccountInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccountList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_AccountInfo;
        private System.Windows.Forms.Label Mã;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_AccountList;
        private System.Windows.Forms.ComboBox cmb_Employee;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Permission;
        private System.Windows.Forms.Button btn_Disable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.ComboBox cmb_Role;
        private System.Windows.Forms.ErrorProvider err_Warning;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Role;
    }
}