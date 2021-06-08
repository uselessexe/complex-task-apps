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
    public partial class TeacherCatalog : Form
    {
        int id;
        NpgsqlConnection con = new NpgsqlConnection("database=Complexdb;server=localhost;port=5432;uid=postgres;password=fuck;");

        public TeacherCatalog(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void TeacherCatalog_Load(object sender, EventArgs e)
        {
            LoadTeacherTable();
        }
        private void LoadTeacherTable()
        {
            con.Open();
            NpgsqlDataAdapter DA = new NpgsqlDataAdapter($"SELECT u.\"Id\",u.\"Name\",u.\"Surname\",u.\"Patronymic\",u.\"Login\" FROM \"User\" u JOIN \"Teacher\" t on (u.\"Id\"=t.\"User_id\")", con);
            DataTable dt = new DataTable();
            DA.Fill(dt);
            dgvTeachers.DataSource = dt.DefaultView;
            con.Close();
        }
        private void buttonCreateTeacher_Click(object sender, EventArgs e)
        {
            UserRecord UR = new UserRecord(UserType.Teacher);
            if (UR.ShowDialog() == DialogResult.OK)
            {
                LoadTeacherTable();
            }
        }

        private void buttonEditTeacher_Click(object sender, EventArgs e)
        {
            int UserId =Convert.ToInt32(dgvTeachers.CurrentRow.Cells[0].Value.ToString());
            UserRecord UR = new UserRecord(UserId, UserType.Teacher);
            if (UR.ShowDialog() == DialogResult.OK)
            {
                LoadTeacherTable();
            }
        }

        private void TSMI_PersonalPage_Click(object sender, EventArgs e)
        {
            Hide();
            AdminPersonalPage APP = new AdminPersonalPage(id);
            APP.ShowDialog();

            Close();
        }

        private void TSMI_StudentList_Click(object sender, EventArgs e)
        {
            Hide();
            StudentsCatalog SC = new StudentsCatalog(id);
            SC.ShowDialog();

            Close();
        }

        
    }
}
