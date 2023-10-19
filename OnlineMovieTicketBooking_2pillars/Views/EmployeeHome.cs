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
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
