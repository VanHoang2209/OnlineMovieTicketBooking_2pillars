using System;
using OnlineMovieTicketBooking_2pillars.Models;
using OnlineMovieTicketBooking_2pillars.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
        private void btn_Continue_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void InfoCustomer_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }


        private bool InputChecked()
        {
            err_Warning.Clear();

            if (string.IsNullOrEmpty(txt_Name.Text) || txt_Name.Text.Any(char.IsDigit))
            {
                err_Warning.SetError(txt_Name, "Họ tên không hợp lệ!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_Phone.Text) || string.IsNullOrWhiteSpace(txt_Phone.Text))
            {
                err_Warning.SetError(txt_Name, "Vui lòng nhập số điện thoại");
                return false;
            }
            if (string.IsNullOrEmpty(txt_Email.Text) || string.IsNullOrWhiteSpace(txt_Email.Text)
                || !Regex.IsMatch(txt_Email.Text, @"^\S+@gmail\.com$"))
            {
                err_Warning.SetError(txt_Email, "Vui lòng nhập địa chỉ email hợp lệ (ví dụ: example@gmail.com)");
                return false;
            }

            using (var dbContext = new MovieDBContext())
            {
                string phoneNumber = txt_Phone.Text;
                var existingPhoneNumber = dbContext.Customers.FirstOrDefault(c => c.Phone == phoneNumber);
                if (existingPhoneNumber != null)
                {
                    err_Warning.SetError(txt_Phone, "Số điện thoại đã được sử dụng bởi người khác!");
                    return false;
                }
            }
            return true;
        }

    }
}
