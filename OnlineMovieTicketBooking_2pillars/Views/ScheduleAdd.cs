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
    public partial class frm_ScheduleAdd : Form
    {
        private static MovieDBContext context = new MovieDBContext();
        List<Movie> listMovie = context.Movies.ToList();
        List<ScheduledMovie> listSchedule = context.ScheduledMovies.ToList();
        public frm_ScheduleAdd()
        {
            InitializeComponent();
            FillMovieCombobox(listMovie);
            BindGrid(listSchedule);
        }

        private void FillMovieCombobox(List<Movie> listMovie)
        {
            listMovie.Insert(0, new Movie());
            this.cmb_MovieName.DataSource = listMovie;
            this.cmb_MovieName.DisplayMember = "Name";
            this.cmb_MovieName.ValueMember = "ID";
            this.cmb_MovieName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BindGrid(List<ScheduledMovie> listSchedule)
        {
            dgv_ScheduleList.Rows.Clear();
            foreach (var item in listSchedule)
            {
                int index = dgv_ScheduleList.Rows.Add();
                dgv_ScheduleList.Rows[index].Cells[0].Value = item.ID;
                dgv_ScheduleList.Rows[index].Cells[1].Value = item.Movie.Name;
                dgv_ScheduleList.Rows[index].Cells[2].Value = item.Date;
                dgv_ScheduleList.Rows[index].Cells[3].Value = item.Time;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckInput())
                {
                    int id = int.Parse(txt_ScheduleID.Text);
                    ScheduledMovie existingSchedule = context.ScheduledMovies.FirstOrDefault(s => s.ID == id);
                    if (existingSchedule == null)
                    {
                        using (var dbContext = new MovieDBContext())
                        {
                            foreach (var item in dbContext.ScheduledMovies)
                            {
                                if (item.Date == txt_Date.Text && item.Time == txt_Time.Text)
                                    throw new Exception("Lịch chiếu bị trùng!");
                            }
                        }
                        ScheduledMovie scheduledMovie = new ScheduledMovie()
                        {
                            ID = int.Parse(txt_ScheduleID.Text),
                            MovieID = int.Parse(cmb_MovieName.SelectedValue.ToString()),
                            Date = txt_Date.Text,
                            Time = txt_Time.Text
                        };
                        context.ScheduledMovies.Add(scheduledMovie);
                        context.SaveChanges();
                        MessageBox.Show("Thêm thông tin thành công!");
                    }
                    else
                        MessageBox.Show("Mã lịch chiếu đã tồn tại!");
                }
                List<ScheduledMovie> listSchedule = context.ScheduledMovies.Include("Movie").ToList();
                BindGrid(listSchedule);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                
        }

        private bool CheckInput()
        {
            err_Warning.Clear();
            if (string.IsNullOrEmpty(txt_ScheduleID.Text))
            {
                err_Warning.SetError(txt_ScheduleID, "Mã lịch chiếu không được để trống!");
                return false;
            }
            if (txt_ScheduleID.Text.Any(Char.IsLetter))
            {
                err_Warning.SetError(txt_ScheduleID, "Mã lịch chiếu phải là số!");
                return false;
            }
            if (cmb_MovieName.SelectedIndex == 0)
            {
                err_Warning.SetError(cmb_MovieName, "Vui lòng chọn tên phim!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_Date.Text))
            {
                err_Warning.SetError(txt_Date, "Ngày chiếu không được để trống!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_Time.Text))
            {
                err_Warning.SetError(txt_Time, "Giờ chiếu không được để trống!");
                return false;
            }
            return true;
        }

        private bool CheckInput2()
        {
            err_Warning.Clear();
            if (string.IsNullOrEmpty(txt_ScheduleID.Text))
            {
                err_Warning.SetError(txt_ScheduleID, "Mã lịch chiếu không được để trống!");
                return false;
            }
            return true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                int id = int.Parse(txt_ScheduleID.Text);
                ScheduledMovie existingSchedule = context.ScheduledMovies.FirstOrDefault(s => s.ID == id);
                if (existingSchedule != null)
                {
                    using (var dbContext = new MovieDBContext())
                    {
                        foreach (var item in dbContext.ScheduledMovies)
                        {
                            if (item.Date == txt_Date.Text && item.Time == txt_Time.Text)
                                throw new Exception("Lịch chiếu bị trùng!");
                        }
                    }
                    existingSchedule.MovieID = int.Parse(cmb_MovieName.SelectedValue.ToString());
                    existingSchedule.Date = txt_Date.Text;
                    existingSchedule.Time = txt_Time.Text;
                    context.SaveChanges();
                    MessageBox.Show("Sửa thông tin thành công!");
                }
                else
                    MessageBox.Show("Mã lịch chiếu không tồn tại!");
            }
            List<ScheduledMovie> listSchedule = context.ScheduledMovies.Include("Movie").ToList();
            BindGrid(listSchedule);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (CheckInput2())
            {
                int id = int.Parse(txt_ScheduleID.Text);
                ScheduledMovie existingSchedule = context.ScheduledMovies.FirstOrDefault(s => s.ID == id);
                if (existingSchedule != null)
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "CẢNH BÁO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        context.ScheduledMovies.Remove(existingSchedule);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thông tin thành công!");
                    }
                }
                else
                    MessageBox.Show("Mã lịch chiếu không tồn tại!");
            }
            List<ScheduledMovie> listSchedule = context.ScheduledMovies.Include("Movie").ToList();
            BindGrid(listSchedule);
        }

        private void dgv_ScheduleList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;
                txt_ScheduleID.Text = dgv_ScheduleList.Rows[index].Cells[0].Value.ToString();
                cmb_MovieName.Text = dgv_ScheduleList.Rows[index].Cells[1].Value.ToString();
                txt_Date.Text = dgv_ScheduleList.Rows[index].Cells[2].Value.ToString();
                txt_Time.Text = dgv_ScheduleList.Rows[index].Cells[3].Value.ToString();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
