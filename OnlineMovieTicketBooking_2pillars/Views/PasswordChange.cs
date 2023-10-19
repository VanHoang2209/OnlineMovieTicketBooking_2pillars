using OnlineMovieTicketBooking_2pillars.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMovieTicketBooking_2pillars.Views
{
    public partial class frm_PasswordChange : Form
    {
        private static MovieDBContext context = new MovieDBContext();
        List<Account> listAccounts = context.Accounts.ToList();
        public frm_PasswordChange()
        {
            InitializeComponent();
        }

        private bool CheckInput()
        {
            err_Warning.Clear();
            if (string.IsNullOrEmpty(txt_CurrentPassword.Text))
            {
                err_Warning.SetError(txt_CurrentPassword, "Vui lòng nhập mật khẩu hiện tại!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_NewPassword.Text))
            {
                err_Warning.SetError(txt_NewPassword, "Vui lòng nhập mật khẩu mới!");
                return false;
            }
            return true;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                Account existingAccount = context.Accounts.FirstOrDefault(s => s.ID == GlobalVariables.AccountID);
                if (existingAccount.Password == txt_CurrentPassword.Text)
                {
                    if (txt_CurrentPassword.Text != txt_NewPassword.Text)
                    {
                        existingAccount.Password = txt_NewPassword.Text;
                        context.SaveChanges();
                        MessageBox.Show("Đổi mật khẩu thành công! Vui lòng đăng nhập lại!");
                        this.Hide();
                        frm_EmployeeHome frm_EmployeeHome = Application.OpenForms.OfType<frm_EmployeeHome>().FirstOrDefault();
                        if (frm_EmployeeHome != null)
                        {
                            frm_EmployeeHome.Close();
                        }
                        this.Close();
                        frm_Login frm_Login = Application.OpenForms.OfType<frm_Login>().FirstOrDefault() ?? new frm_Login();
                        frm_Login.Show();
                        List<Account> listAccount = context.Accounts.Include("Role").ToList();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới và mật khẩu cũ giống nhau! Vui lòng nhập lại!");
                        return;
                    }
                }
                else
                    MessageBox.Show("Mật khẩu hiện tại không đúng!");
            }
        }
    }
}
