using OnlineMovieTicketBooking_2pillars.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMovieTicketBooking_2pillars.Views
{
    public partial class frm_AccountAdd : Form
    {
        private static MovieDBContext context = new MovieDBContext();
        private List<Role> listRole = context.Roles.ToList();
        private List<Employee> listEmployee = context.Employees.ToList();
        private List<Account> listAccount = context.Accounts.ToList();
        public frm_AccountAdd()
        {
            InitializeComponent();
            FillRoleCombobox(listRole);
            FillEmployeeCombobox(listEmployee);
            BindGrid(listAccount);
        }

        private void BindGrid(List<Account> listAccount)
        {
            dgv_AccountList.Rows.Clear();
            foreach (var item in listAccount)
            {
                int index = dgv_AccountList.Rows.Add();
                dgv_AccountList.Rows[index].Cells[0].Value = item.ID;
                dgv_AccountList.Rows[index].Cells[1].Value = item.Username;
                dgv_AccountList.Rows[index].Cells[2].Value = item.Password;
                dgv_AccountList.Rows[index].Cells[3].Value = item.Employee.FullName;
                dgv_AccountList.Rows[index].Cells[4].Value = item.Role.Name;
            }
        }

        private void FillEmployeeCombobox(List<Employee> listEmployee)
        {
            listEmployee.Insert(0, new Employee());
            this.cmb_Employee.DataSource = listEmployee;
            this.cmb_Employee.DisplayMember = "FullName";
            this.cmb_Employee.ValueMember = "ID";
            this.cmb_Employee.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FillRoleCombobox(List<Role> listRole)
        {
            listRole.Insert(0, new Role());
            this.cmb_Role.DataSource = listRole;
            this.cmb_Role.DisplayMember = "Name";
            this.cmb_Role.ValueMember = "ID";
            this.cmb_Role.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private bool CheckInput()
        {
            err_Warning.Clear();
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                err_Warning.SetError(txt_ID, "Mã tài khoản không được để trống!");
                return false;
            }
            if (txt_ID.Text.Any(Char.IsLetter))
            {
                err_Warning.SetError(txt_ID, "Mã tài khoản phải là số!");
                return false;
            }
            if (cmb_Role.SelectedIndex == 0)
            {
                err_Warning.SetError(cmb_Role, "Vui lòng chọn role!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_Username.Text))
            {
                err_Warning.SetError(txt_Username, "Tài khoản không được để trống!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_Password.Text))
            {
                err_Warning.SetError(txt_Password, "Mật khẩu không được để trống!");
                return false;
            }
            if (cmb_Employee.SelectedIndex == 0)
            {
                err_Warning.SetError(cmb_Employee, "Vui lòng chọn nhân viên!");
                return false;
            }
            return true;
        }

        private bool CheckInput3()
        {
            err_Warning.Clear();
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                err_Warning.SetError(txt_ID, "Mã tài khoản không được để trống!");
                return false;
            }
            return true;
        }

        private bool CheckInput2()
        {
            err_Warning.Clear();
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                err_Warning.SetError(txt_ID, "Mã tài khoản không được để trống!");
                return false;
            }
            if (cmb_Role.SelectedIndex == 0)
            {
                err_Warning.SetError(cmb_Role, "Vui lòng chọn role!");
                return false;
            }
            return true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    int id = int.Parse(txt_ID.Text);
                    Account existingAccount = context.Accounts.FirstOrDefault(s => s.ID == id);
                    if (existingAccount == null)
                    {
                        using (var dbContext = new MovieDBContext())
                        {
                            foreach (var item in dbContext.Accounts)
                            {
                                if (item.Username == txt_Username.Text)
                                    throw new Exception("Tên tài khoản đã tồn tại!");
                            }
                        }
                        Account account = new Account()
                        {
                            ID = int.Parse(txt_ID.Text),
                            RoleID = int.Parse(cmb_Role.SelectedValue.ToString()),
                            Username = txt_Username.Text,
                            Password = txt_Password.Text,
                            UserID = int.Parse(cmb_Employee.SelectedValue.ToString())
                        };
                        context.Accounts.Add(account);
                        context.SaveChanges();
                        MessageBox.Show("Thêm tài khoản thành công!");
                    }
                    else
                        MessageBox.Show("Mã tài khoản đã tồn tại!");
                }
                List<Account> listAccount = context.Accounts.Include("Role").ToList();
                BindGrid(listAccount);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Permisson_Click(object sender, EventArgs e)
        {
            if (CheckInput2())
            {
                int id = int.Parse(txt_ID.Text);
                Account existingAccount = context.Accounts.FirstOrDefault(s => s.ID == id);
                if (existingAccount != null)
                {
                    existingAccount.RoleID = int.Parse(cmb_Role.SelectedValue.ToString());
                    context.SaveChanges();
                    MessageBox.Show("Cấp quyền thành công!");
                }
                else
                    MessageBox.Show("Mã tài khoản không tồn tại!");
            }
            List<Account> listAccount = context.Accounts.Include("Role").ToList();
            BindGrid(listAccount);
        }

        private void btn_Disable_Click(object sender, EventArgs e)
        {
            if (CheckInput3())
            {
                int id = int.Parse(txt_ID.Text);
                Account existingAccount = context.Accounts.FirstOrDefault(s => s.ID == id);
                if (existingAccount != null)
                {
                    existingAccount.RoleID = -1;
                    context.SaveChanges();
                    MessageBox.Show("Vô hiệu hóa thành công!");
                }
                else
                    MessageBox.Show("Mã tài khoản không tồn tại!");
            }
            List<Account> listAccount = context.Accounts.Include("Role").ToList();
            BindGrid(listAccount);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_AccountList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;
                txt_ID.Text = dgv_AccountList.Rows[index].Cells[0].Value.ToString();
                txt_Username.Text = dgv_AccountList.Rows[index].Cells[1].Value.ToString();
                txt_Password.Text = dgv_AccountList.Rows[index].Cells[2].Value.ToString();
                cmb_Employee.Text = dgv_AccountList.Rows[index].Cells[3].Value.ToString();
                cmb_Role.Text = dgv_AccountList.Rows[index].Cells[4].Value.ToString();
            }
        }
    }
}
