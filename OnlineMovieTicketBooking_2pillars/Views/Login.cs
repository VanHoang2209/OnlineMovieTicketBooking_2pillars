using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMovieTicketBooking_2pillars.Models;

namespace OnlineMovieTicketBooking_2pillars.Views
{
    public partial class frm_Login : Form
    {
        private static MovieDBContext context = new MovieDBContext();
        public frm_Login()
        {
            InitializeComponent();
            txt_Password.PasswordChar = '*';
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                Account existingAccount = context.Accounts.FirstOrDefault(s => s.Username.Equals(txt_Username.Text));
                if (existingAccount != null)
                {
                    if (existingAccount.Password == txt_Password.Text)
                    {
                        GlobalVariables.UserID = existingAccount.UserID;
                        frm_EmployeeHome frm = new frm_EmployeeHome();
                        frm.ShowDialog();
                        txt_Username.Text = string.Empty;
                        txt_Password.Text = string.Empty;
                    }
                    else
                        throw new Exception("Tài khoản hoặc mật khẩu không đúng!");
                }
                else
                {
                    throw new Exception("Tài khoản hoặc mật khẩu không đúng!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            GlobalVariables.UserID = -1;
            this.Close();
        }
    }
}
