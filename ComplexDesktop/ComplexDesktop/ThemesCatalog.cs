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
    public partial class ThemesCatalog : Form
    {
        int id;
        NpgsqlConnection con = new NpgsqlConnection("database=Complexdb;server=localhost;port=5432;uid=postgres;password=fuck;");
        public ThemesCatalog(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ThemesCatalog_Load(object sender, EventArgs e)
        {
            ThemesLoad();
        }

        private void ThemesLoad()
        {
            con.Open();

            NpgsqlDataAdapter DA = new NpgsqlDataAdapter($"SELECT * FROM \"Theme\"", con);
            DataTable dt = new DataTable();
            DA.Fill(dt);
            dgvThemesCatalog.DataSource = dt.DefaultView;

            con.Close();
        }

        private void buttonCreateTheme_Click(object sender, EventArgs e)
        {
            try
            {
                ThemeRecord TR = new ThemeRecord();
                if (TR.ShowDialog() == DialogResult.OK)
                {
                    ThemesLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void buttonEditTheme_Click(object sender, EventArgs e)
        {
            try
            {
                int ThemeId = Convert.ToInt32(dgvThemesCatalog.CurrentRow.Cells[0].Value.ToString()); 
                ThemeRecord TR = new ThemeRecord(ThemeId);
                if (TR.ShowDialog() == DialogResult.OK)
                {
                    ThemesLoad();
                }
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
            

        private void personalPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            TeacherPersonalPage TPP = new TeacherPersonalPage(id);
            TPP.ShowDialog();

            Close();
        }

        private void questionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            QuestionCatalog QC = new QuestionCatalog(id);
            QC.ShowDialog();
            Close();
        }

        private void studentsAnswersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            StudAnsCatalog SAC = new StudAnsCatalog(id);
            SAC.ShowDialog();
            Close();
        }
    }
}
