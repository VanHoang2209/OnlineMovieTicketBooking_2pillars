using OnlineMovieTicketBooking_2pillars.Models;
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
    public partial class frm_ReserChecking : Form
    {
        private static MovieDBContext context = new MovieDBContext();
        private List<Reservation> listReser = context.Reservations.ToList();
        public frm_ReserChecking()
        {
            InitializeComponent();
            BindGrid(listReser);
        }

        private void BindGrid(List<Reservation> listReser)
        {
            dgv_ReserList.Rows.Clear();
            foreach (var item in listReser)
            {
                int index = dgv_ReserList.Rows.Add();
                dgv_ReserList.Rows[index].Cells[0].Value = item.ID;
                dgv_ReserList.Rows[index].Cells[1].Value = item.Customer.FullName;
                dgv_ReserList.Rows[index].Cells[2].Value = item.Customer.Phone;
                dgv_ReserList.Rows[index].Cells[3].Value = item.Customer.Email;
                dgv_ReserList.Rows[index].Cells[4].Value = item.ScheduledMovie.Movie.Name;
                dgv_ReserList.Rows[index].Cells[5].Value = item.ScheduledMovie.Date;
                dgv_ReserList.Rows[index].Cells[6].Value = item.ScheduledMovie.Time;
                dgv_ReserList.Rows[index].Cells[7].Value = item.TotalPrice;
            }
        }
        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_ReserChecking_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
