using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;

namespace ComplexDesktop
{
    public partial class StudentsCatalog : Form
    {
        int id;
        NpgsqlConnection con = new NpgsqlConnection("database=Complexdb;server=localhost;port=5432;uid=postgres;password=fuck;");
        public StudentsCatalog(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void StudentsCatalog_Load(object sender, EventArgs e)
        {
            LoadStudentTable();
        }
        private void LoadStudentTable()
        {
            con.Open();
            NpgsqlDataAdapter DA = new NpgsqlDataAdapter($"SELECT u.\"Id\",u.\"Name\",u.\"Surname\",u.\"Patronymic\",u.\"Login\",g.\"Group_name\"" +
                $" FROM \"User\" u JOIN \"Student\" s on (u.\"Id\"=s.\"User_id\") JOIN \"Group\" g on(s.\"Group_id\"=g.\"id\")", con);
            DataTable dt = new DataTable();
            DA.Fill(dt);
            dgvStudents.DataSource = dt.DefaultView;
            con.Close();
        }
        private void buttonCreateStudent_Click(object sender, EventArgs e)
        {
            UserRecord UR = new UserRecord(UserType.Student);
            if (UR.ShowDialog() == DialogResult.OK)
            {
                LoadStudentTable();
            }
        }
        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            int UserId = Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value.ToString());
            UserRecord UR = new UserRecord(UserId,UserType.Student);
            if (UR.ShowDialog() == DialogResult.OK)
            {
                LoadStudentTable();
            }
        }

        private void TSMI_PersonalPage_Click(object sender, EventArgs e)
        {
            Hide();
            AdminPersonalPage APP = new AdminPersonalPage(id);
            APP.ShowDialog();

            Close();
        }
        private void TSMI_TeacherList_Click(object sender, EventArgs e)
        {
            Hide();
            TeacherCatalog TC = new TeacherCatalog(id);
            TC.ShowDialog();

            Close();
        }

        
    }
}
