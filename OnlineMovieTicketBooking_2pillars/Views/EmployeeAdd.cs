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
    public partial class frm_EmployeeAdd : Form
    {
        private static MovieDBContext context = new MovieDBContext();
        private List<Employee> listEmployee = context.Employees.ToList();
        public frm_EmployeeAdd()
        {
            InitializeComponent();
            BindGrid(listEmployee);
        }

        private void BindGrid(List<Employee> listEmployee)
        {
            dgv_EmployeeList.Rows.Clear();
            foreach (var item in listEmployee)
            {
                int index = dgv_EmployeeList.Rows.Add();
                dgv_EmployeeList.Rows[index].Cells[0].Value = item.ID;
                dgv_EmployeeList.Rows[index].Cells[1].Value = item.FullName;
                dgv_EmployeeList.Rows[index].Cells[2].Value = item.Phone;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                int id = int.Parse(txt_ID.Text);
                Employee existingEmployee = context.Employees.FirstOrDefault(s => s.ID == id);
                if (existingEmployee == null)
                {
                    Employee employee = new Employee()
                    {
                        ID = int.Parse(txt_ID.Text),
                        FullName = txt_FullName.Text,
                        Phone = txt_Phone.Text
                    };
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    MessageBox.Show("Thêm thông tin thành công!");
                }
                else
                    MessageBox.Show("Mã nhân viên đã tồn tại!");
            }
            List<Employee> listEmployee = context.Employees.ToList();
            BindGrid(listEmployee);
        }

        private bool CheckInput()
        {
            err_Warning.Clear();
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                err_Warning.SetError(txt_ID, "Mã nhân viên không được để trống!");
                return false;
            }
            if (txt_ID.Text.Any(Char.IsLetter))
            {
                err_Warning.SetError(txt_ID, "Mã nhân viên phải là số!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_FullName.Text))
            {
                err_Warning.SetError(txt_FullName, "Tên nhân viên không được để trống!");
                return false;
            }
            if (string.IsNullOrEmpty(txt_Phone.Text))
            {
                err_Warning.SetError(txt_Phone, "Số điện thoại không được để trống!");
                return false;
            }
            return true;
        }

        private bool CheckInput2()
        {
            err_Warning.Clear();
            if (string.IsNullOrEmpty(txt_ID.Text))
            {
                err_Warning.SetError(txt_ID, "Mã lịch chiếu không được để trống!");
                return false;
            }
            return true;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                int id = int.Parse(txt_ID.Text);
                Employee existingEmployee = context.Employees.FirstOrDefault(s => s.ID == id);
                if (existingEmployee != null)
                {
                    existingEmployee.FullName = txt_FullName.Text;
                    existingEmployee.Phone = txt_Phone.Text;
                    context.SaveChanges();
                    MessageBox.Show("Sửa thông tin thành công!");
                }
                else
                    MessageBox.Show("Mã nhân viên không tồn tại!");
            }
            List<Employee> listEmployee = context.Employees.ToList();
            BindGrid(listEmployee);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (CheckInput2())
            {
                int id = int.Parse(txt_ID.Text);
                Employee existingEmployee = context.Employees.FirstOrDefault(s => s.ID == id);
                if (existingEmployee != null)
                {
                    DialogResult dr = MessageBox.Show("Bạn có muốn xóa không?", "CẢNH BÁO", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        context.Employees.Remove(existingEmployee);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thông tin thành công!");
                    }
                }
                else
                    MessageBox.Show("Mã nhân viên không tồn tại!");
            }
            List<Employee> listEmployee = context.Employees.ToList();
            BindGrid(listEmployee);
        }

        private void dgv_EmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int index = e.RowIndex;
                txt_ID.Text = dgv_EmployeeList.Rows[index].Cells[0].Value.ToString();
                txt_FullName.Text = dgv_EmployeeList.Rows[index].Cells[1].Value.ToString();
                txt_Phone.Text = dgv_EmployeeList.Rows[index].Cells[2].Value.ToString();
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
