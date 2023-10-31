using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMovieTicketBooking_2pillars.Views
{
    public partial class frm_EmployeeHome : Form
    {
        public frm_EmployeeHome()
        {
            InitializeComponent();
            if (GlobalVariables.UserRole == 2)
            {
                btn_EmployeeAdd.Visible = false;
                btn_AccountAdd.Visible = false;
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btn_MovieAdd_Click(object sender, EventArgs e)
        {
            frm_MovieAdd frm_MovieAdd = new frm_MovieAdd();
            frm_MovieAdd.ShowDialog();
        }

        private void btn_AddSchedule_Click(object sender, EventArgs e)
        {
            frm_ScheduleAdd frm_ScheduleAdd = new frm_ScheduleAdd();
            frm_ScheduleAdd.ShowDialog();
        }

        private void btn_EmployeeAdd_Click(object sender, EventArgs e)
        {
            frm_EmployeeAdd frm_EmployeeAdd = new frm_EmployeeAdd();
            frm_EmployeeAdd.ShowDialog();
        }

        private void btn_AccountAdd_Click(object sender, EventArgs e)
        {
            frm_AccountAdd frm_AccountAdd = new frm_AccountAdd();
            frm_AccountAdd.ShowDialog();
        }

        private void btn_PasswordChange_Click(object sender, EventArgs e)
        {
            frm_PasswordChange frm_PasswordChange = new frm_PasswordChange();
            frm_PasswordChange.ShowDialog();
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            frm_ReserChecking frm = new frm_ReserChecking();
            frm.Show();
        }
    }
}
