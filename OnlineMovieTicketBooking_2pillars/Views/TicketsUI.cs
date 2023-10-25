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
    public partial class frm_TicketsUI : Form
    {
        public frm_TicketsUI()
        {
            InitializeComponent();
        }
        public void SetTicketInformation(string movieName, string showDate, string showTime, string customerName, string customerPhone, string customerEmail, List<string> listSeats, decimal totalPrice)
        {
            txt_MovieName.Text = movieName;
            txt_Scheduled.Text = showDate + " " + showTime;
            txt_CustomerName.Text = customerName;
            txt_CustomerPhone.Text = customerPhone;
            txt_CustomerEmail.Text = customerEmail;
            //txt_ReserID.Text = reserID;

            // Hiển thị danh sách ghế đã chọn
            foreach (string seat in listSeats)
            {
                txt_Scheduled.Text += seat + Environment.NewLine;
            }

            txt_TotalPrice.Text = totalPrice.ToString();
        }
    }
}
