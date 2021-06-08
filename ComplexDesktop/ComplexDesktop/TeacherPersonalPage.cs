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
    public partial class TeacherPersonalPage : Form
    {
        int id;
        NpgsqlConnection con = new NpgsqlConnection("database=Complexdb;server=localhost;port=5432;uid=postgres;password=fuck;");
        public TeacherPersonalPage(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void TeacherPersonalPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                con.Open();
                
                NpgsqlCommand cmd = new NpgsqlCommand($"SELECT u.\"Id\",u.\"Name\",u.\"Surname\",u.\"Patronymic\",u.\"Login\" FROM \"User\" u WHERE u.\"Id\"={id}", con);
                using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        DataTable t = new DataTable();
                        t.Load(rdr);
                        labelFIO.Text = $"ФИО: {t.Rows[0].ItemArray[2]} {t.Rows[0].ItemArray[1]} {t.Rows[0].ItemArray[3]}";
                        labelEmail.Text = $"Электронная почта: {t.Rows[0].ItemArray[4]}";
                    }
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void buttonUserEdit_Click(object sender, EventArgs e)
        {
            UserRecord UR = new UserRecord(id, UserType.Teacher);
            if (UR.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void TSMI_Themes_Click(object sender, EventArgs e)
        {
            Hide();
            ThemesCatalog TC = new ThemesCatalog(id);
            TC.ShowDialog();
            Close();
        }

        private void TSMI_Questions_Click(object sender, EventArgs e)
        {
            Hide();
            QuestionCatalog QC = new QuestionCatalog(id);
            QC.ShowDialog();
            Close();
        }

        private void TSMI_StudentAnswers_Click(object sender, EventArgs e)
        {
           Hide();
           StudAnsCatalog SAC = new StudAnsCatalog(id);
           SAC.ShowDialog();
           Close();

        }
        
    }
}
