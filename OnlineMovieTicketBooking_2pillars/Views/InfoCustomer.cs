using OnlineMovieTicketBooking_2pillars.Models;
using OnlineMovieTicketBooking_2pillars.ViewModels;
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
    public partial class InfoCustomer : Form
    {
        public string CustomerName { get; private set; }
        public string CustomerPhone { get; private set; }
        public string CustomerEmail { get; private set; }


        private BookingTicketsUI bookingTicketsUI;
        public InfoCustomer(BookingTicketsUI bookingTicketsUI)
        {
            InitializeComponent();
            this.bookingTicketsUI = bookingTicketsUI;
        }

        private void InfoCustomer_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btn_PayAway_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputChecked())
                {
                    CustomerName = txt_Name.Text;
                    CustomerPhone = txt_Phone.Text;
                    CustomerEmail = txt_Email.Text;
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        private bool InputChecked()
        {
            err_Warning.Clear();

            if(string.IsNullOrEmpty(txt_Name.Text) && string.IsNullOrWhiteSpace(txt_Name.Text))
            {
                err_Warning.SetError(txt_Name, "Vui lòng nhập họ tên");
                return false;
            }
            if (string.IsNullOrEmpty(txt_Phone.Text) && string.IsNullOrWhiteSpace(txt_Phone.Text))
            {
                err_Warning.SetError(txt_Name, "Vui lòng nhập số điện thoại");
                return false;
            }
            if (string.IsNullOrEmpty(txt_Email.Text) && string.IsNullOrWhiteSpace(txt_Email.Text))
            {
                err_Warning.SetError(txt_Name, "Vui lòng nhập địa chỉ email");
                return false;
            }
            return true;
        }

    }
}
