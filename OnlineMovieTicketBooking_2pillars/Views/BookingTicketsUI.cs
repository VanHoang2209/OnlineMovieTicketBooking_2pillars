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
    public partial class BookingTicketsUI : Form
    {
        Button btn_SeatSelecting;
        int number = 1;
        public BookingTicketsUI()
        {
            InitializeComponent();
            btn_SeatSelecting = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Xử lý button ghế
        private void SeatsDrawing(int x, int y, string name, int id)
        {
            Button btn = new Button();
            btn.Text = name;
            btn.Tag = id;
            btn.Size = new Size(50, 50);
            btn.Location = new Point(x, y);
            btn.BackColor = Color.Black;
            pnl_ListSeat.Controls.Add(btn);

            btn.Click += Btn_Click;
        }

        private void priceSeat(Button button)
        {
            int seat = int.Parse(button.Text);
            int price = 0;
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Aqua;
            }
            else if(btn.BackColor == Color.Aqua)
            {
                btn.BackColor = Color.White;
            }
            else if(btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đã được bán!");
            }
        }

        
        private void BookingTicketsUI_Load(object sender, EventArgs e)
        {

        }
    }
}
