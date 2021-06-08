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
    public enum UserType
    {
        Teacher,
        Student,
        SysAdmin
    }
    public partial class Autorization : Form
    {
        NpgsqlConnection con = new NpgsqlConnection("database=Complexdb;server=localhost;port=5432;uid=postgres;password=fuck;");
        public Autorization()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPass.Text;
            //string strSQL = $"SELECT Id,Login,Password,Name,Surname,Patronymic FROM User WHERE Login = '{email}' and Password='{password}'";
            try
            {
                con.Open();
                
                NpgsqlCommand cmd = new NpgsqlCommand($"SELECT u.\"Id\" FROM \"User\" u join \"Teacher\" t on(u.\"Id\"=t.\"User_id\") WHERE \"Login\" = '{email}' and \"Password\"='{password}'", con);
                using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        DataTable t = new DataTable();
                        t.Load(rdr);
                        
                        Hide();
                        TeacherPersonalPage TPP = new TeacherPersonalPage(Convert.ToInt32(t.Rows[0].ItemArray[0].ToString()));
                        TPP.ShowDialog();
                        
                        Close();
                    }
                }

                //s.\"id\"
                cmd = new NpgsqlCommand($"SELECT u.\"Id\" FROM \"User\" u join \"Sys_admin\" s on(u.\"Id\"=s.\"user_id\") WHERE \"Login\" = '{email}' and \"Password\"='{password}'", con);
                using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        DataTable t = new DataTable();
                        t.Load(rdr);
                        //string row = t.Rows[0].ItemArray[0].ToString();
                        
                        Hide();
                        AdminPersonalPage APP = new AdminPersonalPage(Convert.ToInt32(t.Rows[0].ItemArray[0].ToString()));
                        APP.ShowDialog();
                        
                        Close();
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
    }
}
