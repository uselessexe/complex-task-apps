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
    public partial class ThemeRecord : Form
    {
        bool isNew;
        int id;
        NpgsqlConnection con = new NpgsqlConnection("database=Complexdb;server=localhost;port=5432;uid=postgres;password=fuck;");
        public ThemeRecord()
        {
            InitializeComponent();
            this.isNew = true ;
        }
        public ThemeRecord(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        private void ThemeRecord_Load(object sender, EventArgs e)
        {
            
            try
            {
                if(!isNew)
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand($"SELECT \"TName\" FROM \"Theme\" WHERE \"id\"={id}", con);
                    NpgsqlDataReader rdr = cmd.ExecuteReader();
                    DataTable t = new DataTable();
                    t.Load(rdr);
                    textBoxTheme.Text = t.Rows[0].ItemArray[0].ToString();
                    con.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }
        private void buttonddTheme_Click(object sender, EventArgs e)
        {
            
            try
            {
                string ThemeName = textBoxTheme.Text;
                if (isNew)
                {
                    
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO \"Theme\"(\"TName\") VALUES('{ThemeName}')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Тема была успешно создана.");
                    
                }
                else
                {
                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand($"UPDATE \"Theme\" SET \"TName\"='{ThemeName}' WHERE \"id\"={id}", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Тема была успешно отредактирована.");
                    
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
