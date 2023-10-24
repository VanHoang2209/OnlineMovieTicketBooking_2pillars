namespace OnlineMovieTicketBooking_2pillars.Views
{
    partial class frm_MovieAdd
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
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_MovieList = new System.Windows.Forms.DataGridView();
            this.col_MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MovieName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_MovieInfo = new System.Windows.Forms.GroupBox();
            this.txt_MovieID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MovieName = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.err_Warning = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MovieList)).BeginInit();
            this.grb_MovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 2;
            // 
            // dgv_MovieList
            // 
            this.dgv_MovieList.AllowUserToAddRows = false;
            this.dgv_MovieList.AllowUserToDeleteRows = false;
            this.dgv_MovieList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MovieList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MovieList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MovieID,
            this.col_MovieName,
            this.col_Username});
            this.dgv_MovieList.Location = new System.Drawing.Point(388, 37);
            this.dgv_MovieList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_MovieList.Name = "dgv_MovieList";
            this.dgv_MovieList.ReadOnly = true;
            this.dgv_MovieList.RowHeadersWidth = 51;
            this.dgv_MovieList.RowTemplate.Height = 24;
            this.dgv_MovieList.Size = new System.Drawing.Size(401, 248);
            this.dgv_MovieList.TabIndex = 6;
            this.dgv_MovieList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MovieList_CellClick);
            // 
            // col_MovieID
            // 
            this.col_MovieID.HeaderText = "Mã phim";
            this.col_MovieID.MinimumWidth = 6;
            this.col_MovieID.Name = "col_MovieID";
            this.col_MovieID.ReadOnly = true;
            // 
            // col_MovieName
            // 
            this.col_MovieName.HeaderText = "Tên";
            this.col_MovieName.MinimumWidth = 6;
            this.col_MovieName.Name = "col_MovieName";
            this.col_MovieName.ReadOnly = true;
            // 
            // col_Username
            // 
            this.col_Username.HeaderText = "Người thêm";
            this.col_Username.MinimumWidth = 6;
            this.col_Username.Name = "col_Username";
            this.col_Username.ReadOnly = true;
            // 
            // grb_MovieInfo
            // 
            this.grb_MovieInfo.Controls.Add(this.txt_MovieID);
            this.grb_MovieInfo.Controls.Add(this.label4);
            this.grb_MovieInfo.Controls.Add(this.txt_MovieName);
            this.grb_MovieInfo.Controls.Add(this.label3);
            this.grb_MovieInfo.Controls.Add(this.label1);
            this.grb_MovieInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_MovieInfo.Location = new System.Drawing.Point(21, 62);
            this.grb_MovieInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_MovieInfo.Name = "grb_MovieInfo";
            this.grb_MovieInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grb_MovieInfo.Size = new System.Drawing.Size(344, 166);
            this.grb_MovieInfo.TabIndex = 4;
            this.grb_MovieInfo.TabStop = false;
            this.grb_MovieInfo.Text = "Thông tin phim";
            // 
            // txt_MovieID
            // 
            this.txt_MovieID.Location = new System.Drawing.Point(106, 50);
            this.txt_MovieID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MovieID.Name = "txt_MovieID";
            this.txt_MovieID.Size = new System.Drawing.Size(188, 24);
            this.txt_MovieID.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã phim";
            // 
            // txt_MovieName
            // 
            this.txt_MovieName.Location = new System.Drawing.Point(106, 107);
            this.txt_MovieName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_MovieName.Name = "txt_MovieName";
            this.txt_MovieName.Size = new System.Drawing.Size(188, 24);
            this.txt_MovieName.TabIndex = 1;
            // 
            // btn_Back
            // 
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(294, 244);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(71, 41);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Quay lại";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(31, 244);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(71, 41);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(115, 244);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(71, 41);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(204, 244);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(71, 41);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // err_Warning
            // 
            this.err_Warning.ContainerControl = this;
            // 
            // frm_MovieAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 309);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.grb_MovieInfo);
            this.Controls.Add(this.dgv_MovieList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frm_MovieAdd";
            this.Text = "THÊM PHIM";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MovieList)).EndInit();
            this.grb_MovieInfo.ResumeLayout(false);
            this.grb_MovieInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err_Warning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_MovieList;
        private System.Windows.Forms.GroupBox grb_MovieInfo;
        private System.Windows.Forms.TextBox txt_MovieID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MovieName;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MovieName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Username;
        private System.Windows.Forms.ErrorProvider err_Warning;
    }
}