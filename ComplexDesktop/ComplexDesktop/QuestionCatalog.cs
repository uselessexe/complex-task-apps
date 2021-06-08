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
    public partial class QuestionCatalog : Form
    {
        int Userid;
        NpgsqlConnection con = new NpgsqlConnection("database=Complexdb;server=localhost;port=5432;uid=postgres;password=fuck;");
        public QuestionCatalog(int Userid)
        {
            InitializeComponent();
            this.Userid = Userid;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadThemes();
        }
        private void LoadThemes()
        {
            try
            {
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM \"Theme\"", con);
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                DataTable t = new DataTable();
                t.Load(rdr);
                comboBoxThemes.DataSource = t;
                comboBoxThemes.DisplayMember = "TName";

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        private void buttonSelectTheme_Click(object sender, EventArgs e)
        {       
            con.Open();
           
            string ThemeName = comboBoxThemes.Text;
            NpgsqlCommand cmdSelectT = new NpgsqlCommand($"SELECT \"id\" FROM \"Theme\" WHERE \"TName\"='{ThemeName}'", con);
            NpgsqlDataReader rdrSelectT = cmdSelectT.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(rdrSelectT);
            int ThemeId = Convert.ToInt32(t.Rows[0].ItemArray[0].ToString());
            rdrSelectT.Close();

            NpgsqlDataAdapter DA = new NpgsqlDataAdapter($"SELECT * FROM \"Question\" WHERE \"IdTheme\"={ThemeId}", con);
            t = new DataTable();
            DA.Fill(t);
            dgvQuestions.DataSource = t.DefaultView;
            con.Close();
        }
        private void buttonAddQues_Click(object sender, EventArgs e)
        {
            QuestionRecord QR = new QuestionRecord(true);          
            if (QR.ShowDialog() == DialogResult.OK)
            {
                LoadThemes();
            }
        }

        private void buttonEditQuestion_Click(object sender, EventArgs e)
        {
            int QuesId = Convert.ToInt32(dgvQuestions.CurrentRow.Cells[0].Value.ToString());
            QuestionRecord QR = new QuestionRecord(QuesId);
            if (QR.ShowDialog() == DialogResult.OK)
            {
                LoadThemes();
            }
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

        private void studentsAnswersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            StudAnsCatalog SAC = new StudAnsCatalog(Userid);
            SAC.ShowDialog();
            Close();
        }

        
    }
}
