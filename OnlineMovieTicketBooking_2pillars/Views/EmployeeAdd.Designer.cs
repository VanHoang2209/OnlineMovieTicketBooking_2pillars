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
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.err_Warning = new System.Windows.Forms.ErrorProvider(this.components);
            this.grb_EmployeeInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_EmployeeInfo
            // 
            this.grb_EmployeeInfo.Controls.Add(this.txt_Phone);
            this.grb_EmployeeInfo.Controls.Add(this.txt_FullName);
            this.grb_EmployeeInfo.Controls.Add(this.txt_ID);
            this.grb_EmployeeInfo.Controls.Add(this.label3);
            this.grb_EmployeeInfo.Controls.Add(this.label2);
            this.grb_EmployeeInfo.Controls.Add(this.label1);
            this.grb_EmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_EmployeeInfo.Location = new System.Drawing.Point(16, 34);
            this.grb_EmployeeInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_EmployeeInfo.Name = "grb_EmployeeInfo";
            this.grb_EmployeeInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_EmployeeInfo.Size = new System.Drawing.Size(337, 233);
            this.grb_EmployeeInfo.TabIndex = 0;
            this.grb_EmployeeInfo.TabStop = false;
            this.grb_EmployeeInfo.Text = "Thông tin nhân viên";
            // 
            // txt_Phone
            // 
            this.txt_Phone.Location = new System.Drawing.Point(130, 168);
            this.txt_Phone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(177, 23);
            this.txt_Phone.TabIndex = 5;
            // 
            // txt_FullName
            // 
            this.txt_FullName.Location = new System.Drawing.Point(130, 100);
            this.txt_FullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.Size = new System.Drawing.Size(177, 23);
            this.txt_FullName.TabIndex = 4;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(130, 37);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(177, 23);
            this.txt_ID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
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
            this.col_Phone});
            this.dgv_EmployeeList.Location = new System.Drawing.Point(370, 34);
            this.dgv_EmployeeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_EmployeeList.Name = "dgv_EmployeeList";
            this.dgv_EmployeeList.ReadOnly = true;
            this.dgv_EmployeeList.RowHeadersWidth = 51;
            this.dgv_EmployeeList.RowTemplate.Height = 24;
            this.dgv_EmployeeList.Size = new System.Drawing.Size(389, 283);
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
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(286, 276);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(71, 41);
            this.btn_Back.TabIndex = 16;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(197, 276);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(71, 41);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(106, 276);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(71, 41);
            this.btn_Update.TabIndex = 14;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(16, 276);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(71, 41);
            this.btn_Add.TabIndex = 13;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // err_Warning
            // 
            this.err_Warning.ContainerControl = this;
            // 
            // frm_EmployeeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 341);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_EmployeeList);
            this.Controls.Add(this.grb_EmployeeInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_EmployeeAdd";
            this.Text = "THÊM NHÂN VIÊN";
            this.grb_EmployeeInfo.ResumeLayout(false);
            this.grb_EmployeeInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ErrorProvider err_Warning;
    }
}