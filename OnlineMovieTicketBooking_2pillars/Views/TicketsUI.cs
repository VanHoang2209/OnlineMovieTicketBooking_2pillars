using OnlineMovieTicketBooking_2pillars.Models;
using System;
using System.CodeDom.Compiler;
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
    public partial class frm_TicketsUI : Form
    {
        private frm_BookingTicketsUI bookingTicketsUI;
        public frm_TicketsUI(frm_BookingTicketsUI bookingTicketsUI)
        {
            InitializeComponent();
            this.bookingTicketsUI = bookingTicketsUI;
        }
        public void SetTicketInformation(string reserID, string movieTitle, string showDate, string customerName, string customerPhone, string customerEmail, string totalPrice, List<string> listSeats)
        {
            rtb_MovieTitle.Text = movieTitle;
            rtb_ScheduledMovie.Text = showDate;
            rtb_CustomerName.Text = customerName;
            rtb_CustomerPhone.Text = customerPhone;
            rtb_CustomerEmail.Text = customerEmail;
            rtb_ReserID.Text = reserID;
            rtb_TotalPrice.Text = totalPrice;

        }
        public void SetListSeats(List<string> listSeats)
        {
            string seatsText = string.Join(", ", listSeats);
            rtb_Seats.Text = seatsText;
        }

        private void frm_TicketsUI_Load(object sender, EventArgs e)
        {
            rtb_MovieTitle.Select();
            rtb_MovieTitle.SelectionAlignment = HorizontalAlignment.Center;
            this.CenterToScreen();
        }
    }
}
