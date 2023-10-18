using OnlineMovieTicketBooking_2pillars.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMovieTicketBooking_2pillars.Views
{
    public partial class BookingTicketsUI : Form
    {
        decimal total = 0;
        public BookingTicketsUI()
        {
            InitializeComponent();
            ControlSetting();
        }
        private void BookingTicketsUI_Load(object sender, EventArgs e)
        {
            try
            {
                // Button
                SeatInit();

                using (var dbContext = new MovieDBContext())
                {
                    cmb_MovieTitle.DataSource = dbContext.Movies.Select(c => new { c.ID, c.Name }).ToList();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //  Button Seat Handle 
        #region "Button Seat Handle"

        private void SeatInit()
        {
            int x = 65, y = 68, i = 1;
            using (var dbContext = new MovieDBContext())
            {
                int seatSpacing = 108; // Khoảng cách mặc định giữa các ghế
                foreach (var seat in dbContext.Seats.ToList())
                {
                    SeatsDrawing(x, y, seat.Name, seat.ID);

                    if (seat.ID >= 21 && seat.ID <= 23)
                    {
                        seatSpacing = 190; // Đặt khoảng cách lớn hơn cho các ghế từ id 21 đến 23
                    }
                    else
                    {
                        seatSpacing = 108; // Sử dụng khoảng cách mặc định cho các ghế khác
                    }

                    if (i++ % 5 == 0)
                    {
                        y += 70;
                        x = 65;
                    }
                    else
                    {
                        x += seatSpacing;
                    }
                }
            }
        }
        private void SeatsDrawing(int x, int y,string name, int id)
        {
            Button btn = new Button();
            btn.Text = name;
            btn.TextAlign = ContentAlignment.MiddleRight;
            btn.Tag = id;
            
            if( id >= 1 && id <= 20)
            {
                btn.Size = new Size(58, 38);
                btn.BackColor = Color.Yellow;

            }
            else if(id > 20 && id <= 25)
            {
                btn.Size = new Size(116, 38);
                btn.BackColor = Color.Aqua;
            }

            btn.Location = new Point(x, y); 
            pnl_ListSeat.Controls.Add(btn);
            btn.Click += Btn_Click;
        }


        private decimal PriceSeat(Button button)
        {
            int btn = (int)button.Tag;
            decimal price = 0;
            if(btn >= 1 && btn <= 10)
            {
                price = 60000;
            }
            else if(btn >= 11 && btn <= 20)
            {
                price = 70000;
            }
            else if(btn >= 21 && btn <= 23)
            {
                price = 150000;
            }
            return price;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txt_Total.Font = new Font(txt_Total.Font, FontStyle.Bold);

            int btnID = (int)btn.Tag; // Lấy ID từ Tag của nút
            //list_SeatSelected = new ListBox();

            if (btn.BackColor == Color.Yellow)
            {
                btn.BackColor = Color.Red;
                total += PriceSeat(btn);
                txt_Total.Text = total.ToString();

                // Info selected
                list_SeatSelected.Items.Add(btn.Text);
                //UpdateSeatText();
                
            }
            else if (btn.BackColor == Color.Aqua)
            {
                btn.BackColor = Color.Red;
                total += PriceSeat(btn);
                txt_Total.Text = total.ToString();

                list_SeatSelected.Items.Add(btn.Text);
                //UpdateSeatText();
            }
            else if (btn.BackColor == Color.Red)
            {
                if (btnID >= 1 && btnID <= 20)
                {
                    btn.BackColor = Color.Yellow;
                }
                else if (btnID >= 21 && btnID <= 23)
                {
                    btn.BackColor = Color.Aqua;
                }

                total -= PriceSeat(btn);
                txt_Total.Text = total.ToString();

                list_SeatSelected.Items.Remove(btn.Text);
                //UpdateSeatText();
            }
            else if (btn.BackColor == Color.Gray)
            {
                MessageBox.Show("Ghế đã được bán!");
            }
        }


        private void pnl_ListSeat_Paint(object sender, PaintEventArgs e)
        {
            pnl_ListSeat.BorderStyle = BorderStyle.FixedSingle;
        }
        #endregion


        // Combobox Movie Handle
        #region "Combobox Movie and Combobox ScheduledMovie Handle"
        private void ControlSetting()
        {
            cmb_MovieTitle.DisplayMember = "Name";
            cmb_MovieTitle.ValueMember = "ID";
            cmb_MovieTitle.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb_ShowTime.DisplayMember = "FullDateTime";
            //cmb_ShowTime.DisplayMember = "Time";
            cmb_ShowTime.ValueMember = "ID";
            cmb_ShowTime.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void cmb_MovieTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_MovieTitle.SelectedValue != null)
            {
                int selectedMovieID = int.Parse(cmb_MovieTitle.SelectedValue.ToString());

                using (var dbContext = new MovieDBContext())
                {
                    var scheduledMovies = dbContext.ScheduledMovies
                        .Where(s => s.MovieID == selectedMovieID)
                        .ToList();

                    var scheduledMoviesWithDateTime = scheduledMovies
                        .Select(s => new
                        {
                            s.ID,
                            FullDateTime = s.Date + "   " + s.Time // Kết hợp ngày và giờ thành một chuỗi
                        })
                        .ToList();

                    cmb_ShowTime.DataSource = scheduledMoviesWithDateTime;
                }
            }
        }
        #endregion


        // Groupbox Infor Selected
        #region ""Groupbox infor selected
        private void cmb_ShowTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ShowTime.SelectedValue != null)
            {
                string selectedShowTime = cmb_ShowTime.Text;
                string[] parts = selectedShowTime.Split(new string[] { "   " }, StringSplitOptions.None);

                if (parts.Length >= 2)
                {
                    string showDate = parts[0];
                    string showTime = parts[1];

                    txt_Time.Text = showTime;
                    txt_Date.Text = showDate;
                    txt_MovieTitle.Text = cmb_MovieTitle.Text;
                }
            }
        }
        #endregion
    }
}
