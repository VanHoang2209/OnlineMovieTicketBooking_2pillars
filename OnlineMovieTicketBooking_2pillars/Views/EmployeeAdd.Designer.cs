namespace OnlineMovieTicketBooking_2pillars.Views
{
    partial class frm_EmployeeAdd
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
            this.grb_EmployeeInfo = new System.Windows.Forms.GroupBox();
            this.cmb_Position = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Phone = new System.Windows.Forms.TextBox();
            this.txt_FullName = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_EmployeeList = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Disable = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.err_Warning = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.grb_EmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_EmployeeInfo
            // 
            this.grb_EmployeeInfo.Controls.Add(this.cmb_Position);
            this.grb_EmployeeInfo.Controls.Add(this.label4);
            this.grb_EmployeeInfo.Controls.Add(this.txt_Phone);
            this.grb_EmployeeInfo.Controls.Add(this.txt_FullName);
            this.grb_EmployeeInfo.Controls.Add(this.txt_ID);
            this.grb_EmployeeInfo.Controls.Add(this.label3);
            this.grb_EmployeeInfo.Controls.Add(this.label2);
            this.grb_EmployeeInfo.Controls.Add(this.label1);
            this.grb_EmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_EmployeeInfo.Location = new System.Drawing.Point(21, 156);
            this.grb_EmployeeInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_EmployeeInfo.Name = "grb_EmployeeInfo";
            this.grb_EmployeeInfo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grb_EmployeeInfo.Size = new System.Drawing.Size(449, 287);
            this.grb_EmployeeInfo.TabIndex = 0;
            this.grb_EmployeeInfo.TabStop = false;
            this.grb_EmployeeInfo.Text = "Thông tin nhân viên";
            // 
            // cmb_Position
            // 
            this.cmb_Position.FormattingEnabled = true;
            this.cmb_Position.Location = new System.Drawing.Point(173, 230);
            this.cmb_Position.Name = "cmb_Position";
            this.cmb_Position.Size = new System.Drawing.Size(235, 28);
            this.cmb_Position.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Chức vụ";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(173, 163);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(235, 27);
            this.txt_Phone.TabIndex = 3;
            // 
            // txt_FullName
            // 
            this.txt_FullName.Location = new System.Drawing.Point(173, 104);
            this.txt_FullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(235, 27);
            this.txt_FullName.TabIndex = 2;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(173, 46);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(235, 27);
            this.txt_ID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // dgv_EmployeeList
            // 
            this.dgv_EmployeeList.AllowUserToAddRows = false;
            this.dgv_EmployeeList.AllowUserToDeleteRows = false;
            this.dgv_EmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_FullName,
            this.col_Phone,
            this.col_Position});
            this.dgv_EmployeeList.Location = new System.Drawing.Point(476, 156);
            this.dgv_EmployeeList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_EmployeeList.Name = "dgv_EmployeeList";
            this.dgv_EmployeeList.ReadOnly = true;
            this.dgv_EmployeeList.RowHeadersWidth = 51;
            this.dgv_EmployeeList.RowTemplate.Height = 24;
            this.dgv_EmployeeList.Size = new System.Drawing.Size(622, 348);
            this.dgv_EmployeeList.TabIndex = 1;
            this.dgv_EmployeeList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_EmployeeList_CellClick);
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "Mã nhân viên";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_FullName
            // 
            this.col_FullName.HeaderText = "Họ tên";
            this.col_FullName.MinimumWidth = 6;
            this.col_FullName.Name = "col_FullName";
            this.col_FullName.ReadOnly = true;
            // 
            // col_Phone
            // 
            this.col_Phone.HeaderText = "Số điện thoại";
            this.col_Phone.MinimumWidth = 6;
            this.col_Phone.Name = "col_Phone";
            this.col_Phone.ReadOnly = true;
            // 
            // col_Position
            // 
            this.col_Position.HeaderText = "Chức vụ";
            this.col_Position.MinimumWidth = 6;
            this.col_Position.Name = "col_Position";
            this.col_Position.ReadOnly = true;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(375, 454);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(95, 50);
            this.btn_Back.TabIndex = 8;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Disable
            // 
            this.btn_Disable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Disable.Location = new System.Drawing.Point(263, 454);
            this.btn_Disable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Disable.Name = "btn_Disable";
            this.btn_Disable.Size = new System.Drawing.Size(95, 50);
            this.btn_Disable.TabIndex = 7;
            this.btn_Disable.Text = "Vô hiệu";
            this.btn_Disable.UseVisualStyleBackColor = true;
            this.btn_Disable.Click += new System.EventHandler(this.btn_Disable_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(141, 454);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(95, 50);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(21, 454);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(95, 50);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // err_Warning
            // 
            this.err_Warning.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(335, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(380, 39);
            this.label5.TabIndex = 17;
            this.label5.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // frm_EmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 530);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Disable);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_EmployeeList);
            this.Controls.Add(this.grb_EmployeeInfo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_EmployeeAdd";
            this.Text = "Employee Management";
            this.Load += new System.EventHandler(this.frm_EmployeeAdd_Load);
            this.grb_EmployeeInfo.ResumeLayout(false);
            this.grb_EmployeeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_EmployeeInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.DataGridView dgv_EmployeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Phone;
        private System.Windows.Forms.TextBox txt_Phone;
        private System.Windows.Forms.TextBox txt_FullName;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Disable;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ErrorProvider err_Warning;
        private System.Windows.Forms.ComboBox cmb_Position;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Position;
        private System.Windows.Forms.Label label5;
    }
}