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
    public partial class QuestionRecord : Form
    {
        int QuestionId;
        bool isNew;
        NpgsqlConnection con = new NpgsqlConnection("database=Complexdb;server=localhost;port=5432;uid=postgres;password=fuck;");
        public QuestionRecord(int QuestionId)
        {
            InitializeComponent();
            this.QuestionId = QuestionId;
            isNew = false;
        }
        public QuestionRecord(bool isNew)
        {
            InitializeComponent();
            this.isNew = isNew;
        }

        private void QuestionRecord_Load(object sender, EventArgs e)
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
                rdr.Close();
                
                
                if (isNew)
                {

                }
                else
                {
                    NpgsqlCommand cmdTheme = new NpgsqlCommand($"SELECT t.\"TName\" FROM \"Theme\" t join \"Question\" q on(t.\"id\"=q.\"IdTheme\") WHERE q.\"id\"={QuestionId}", con);
                    NpgsqlDataReader rdrTheme = cmdTheme.ExecuteReader();
                    t = new DataTable();
                    t.Load(rdrTheme);
                    comboBoxThemes.SelectedItem = t.Rows[0].ItemArray[0].ToString();
                    
                }


                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void buttonddTheme_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
