namespace OnlineMovieTicketBooking_2pillars.Views
{
    partial class frm_ScheduleAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Time = new System.Windows.Forms.TextBox();
            this.txt_Date = new System.Windows.Forms.TextBox();
            this.cmb_MovieName = new System.Windows.Forms.ComboBox();
            this.txt_ScheduleID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ScheduleList = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.err_Warning = new System.Windows.Forms.ErrorProvider(this.components);
            this.col_ScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Time);
            this.groupBox1.Controls.Add(this.txt_Date);
            this.groupBox1.Controls.Add(this.cmb_MovieName);
            this.groupBox1.Controls.Add(this.txt_ScheduleID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 353);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lịch chiếu";
            // 
            // txt_Time
            // 
            this.txt_Time.Location = new System.Drawing.Point(136, 278);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.Size = new System.Drawing.Size(153, 27);
            this.txt_Time.TabIndex = 7;
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(136, 202);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(180, 27);
            this.txt_Date.TabIndex = 6;
            // 
            // cmb_MovieName
            // 
            this.cmb_MovieName.FormattingEnabled = true;
            this.cmb_MovieName.Location = new System.Drawing.Point(136, 128);
            this.cmb_MovieName.Name = "cmb_MovieName";
            this.cmb_MovieName.Size = new System.Drawing.Size(284, 28);
            this.cmb_MovieName.TabIndex = 5;
            // 
            // txt_ScheduleID
            // 
            this.txt_ScheduleID.Location = new System.Drawing.Point(136, 55);
            this.txt_ScheduleID.Name = "txt_ScheduleID";
            this.txt_ScheduleID.Size = new System.Drawing.Size(180, 27);
            this.txt_ScheduleID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giờ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lịch chiếu";
            // 
            // dgv_ScheduleList
            // 
            this.dgv_ScheduleList.AllowUserToAddRows = false;
            this.dgv_ScheduleList.AllowUserToDeleteRows = false;
            this.dgv_ScheduleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ScheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ScheduleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ScheduleID,
            this.col_MovieName,
            this.col_Date,
            this.col_Time});
            this.dgv_ScheduleList.Location = new System.Drawing.Point(477, 36);
            this.dgv_ScheduleList.Name = "dgv_ScheduleList";
            this.dgv_ScheduleList.ReadOnly = true;
            this.dgv_ScheduleList.RowHeadersWidth = 51;
            this.dgv_ScheduleList.RowTemplate.Height = 24;
            this.dgv_ScheduleList.Size = new System.Drawing.Size(623, 430);
            this.dgv_ScheduleList.TabIndex = 1;
            this.dgv_ScheduleList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ScheduleList_CellClick);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(371, 399);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(95, 50);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(253, 399);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(95, 50);
            this.btn_Delete.TabIndex = 11;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(131, 399);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(95, 50);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(11, 399);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(95, 50);
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // err_Warning
            // 
            this.err_Warning.ContainerControl = this;
            // 
            // col_ScheduleID
            // 
            this.col_ScheduleID.HeaderText = "Mã lịch chiếu";
            this.col_ScheduleID.MinimumWidth = 6;
            this.col_ScheduleID.Name = "col_ScheduleID";
            this.col_ScheduleID.ReadOnly = true;
            // 
            // col_MovieName
            // 
            this.col_MovieName.HeaderText = "Tên phim";
            this.col_MovieName.MinimumWidth = 6;
            this.col_MovieName.Name = "col_MovieName";
            this.col_MovieName.ReadOnly = true;
            // 
            // col_Date
            // 
            this.col_Date.HeaderText = "Ngày chiếu";
            this.col_Date.MinimumWidth = 6;
            this.col_Date.Name = "col_Date";
            this.col_Date.ReadOnly = true;
            // 
            // col_Time
            // 
            this.col_Time.HeaderText = "Giờ";
            this.col_Time.MinimumWidth = 6;
            this.col_Time.Name = "col_Time";
            this.col_Time.ReadOnly = true;
            // 
            // frm_ScheduleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 478);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgv_ScheduleList);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_ScheduleAdd";
            this.Text = "THÊM LỊCH CHIẾU";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ScheduleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_ScheduleList;
        private System.Windows.Forms.TextBox txt_ScheduleID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_MovieName;
        private System.Windows.Forms.TextBox txt_Time;
        private System.Windows.Forms.TextBox txt_Date;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.ErrorProvider err_Warning;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ScheduleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Time;
    }
}