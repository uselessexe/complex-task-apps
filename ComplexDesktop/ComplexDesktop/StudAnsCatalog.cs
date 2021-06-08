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
    public partial class StudAnsCatalog : Form
    {
        int Userid;
        NpgsqlConnection con = new NpgsqlConnection("database=Complexdb;server=localhost;port=5432;uid=postgres;password=fuck;");
        public StudAnsCatalog(int id)
        {
            InitializeComponent();
            this.Userid = id;
        }

        private void StudAnsCatalog_Load(object sender, EventArgs e)
        {
            con.Open();

            NpgsqlCommand cmdTheme = new NpgsqlCommand($"SELECT * FROM \"Theme\"", con);
            NpgsqlDataReader rdrTheme = cmdTheme.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(rdrTheme);
            comboBoxTheme.DataSource = t;
            comboBoxTheme.DisplayMember = "TName";
            rdrTheme.Close();

            NpgsqlCommand cmdGroup = new NpgsqlCommand($"SELECT * FROM \"Group\"", con);
            NpgsqlDataReader rdrGroup = cmdGroup.ExecuteReader();
            t = new DataTable();
            t.Load(rdrGroup);
            comboBoxGroup.DataSource = t;
            comboBoxGroup.DisplayMember = "Group_name";
            rdrGroup.Close();

            con.Close();
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string ThemeName = comboBoxTheme.Text;
            string GroupName = comboBoxGroup.Text;

            con.Open();
            NpgsqlCommand cmdSelectT = new NpgsqlCommand($"SELECT \"id\" FROM \"Theme\" WHERE \"TName\"='{ThemeName}'", con);
            NpgsqlDataReader rdrSelectT = cmdSelectT.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(rdrSelectT);
            int ThemeId = Convert.ToInt32(t.Rows[0].ItemArray[0].ToString());
            rdrSelectT.Close();

            NpgsqlCommand cmdSelectG = new NpgsqlCommand($"SELECT \"id\" FROM \"Group\" WHERE \"Group_name\"='{GroupName}'", con);
            NpgsqlDataReader rdrSelectG = cmdSelectG.ExecuteReader();
            t = new DataTable();
            t.Load(rdrSelectG);
            int GroupId = Convert.ToInt32(t.Rows[0].ItemArray[0].ToString());
            rdrSelectG.Close();

            NpgsqlDataAdapter DA = new NpgsqlDataAdapter($"SELECT sa.\"id\",u.\"Name\",u.\"Surname\",u.\"Patronymic\",q.\"QText\",sa.\"Stud_answer\"" +
                $" FROM \"Stud_answers\" sa join \"Question\" q on (sa.\"Question_id\"=q.\"id\")" +
                $"join \"Student\" s on(sa.\"Stud_id\"=s.\"id\") join \"User\" u on (s.\"User_id\"=u.\"Id\")" +
                $"WHERE q.\"IdTheme\"={ThemeId} AND s.\"Group_id\"={GroupId}", con);
            t = new DataTable();
            DA.Fill(t);
            dgvStudAns.DataSource = t.DefaultView;
            con.Close();

            con.Close();
        }
        private void buttonMoreDet_Click(object sender, EventArgs e)
        {
            StudAnsFull SAF = new StudAnsFull();
            SAF.ShowDialog();
        }
        private void personalPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            TeacherPersonalPage TPP = new TeacherPersonalPage(Userid);
            TPP.ShowDialog();

            Close();
        }

        private void themesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            ThemesCatalog TC = new ThemesCatalog(Userid);
            TC.ShowDialog();
            Close();
        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            QuestionCatalog QC = new QuestionCatalog(Userid);
            QC.ShowDialog();
            Close();
        }

        
    }
}
