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
    public partial class UserRecord : Form
    {
        int id;
        bool IsNew;
        UserType userType;
        NpgsqlConnection con = new NpgsqlConnection("database=Complexdb;server=localhost;port=5432;uid=postgres;password=fuck;");

        public UserRecord(int id,UserType userType)
        {
            InitializeComponent();
            this.userType = userType;
            this.id = id;
            IsNew = false;
           
        }
        public UserRecord(UserType userType)
        {
            InitializeComponent();           
            IsNew=true;
            this.userType = userType;
        }

        private void UserRecord_Load(object sender, EventArgs e)
        {
            if (userType == UserType.Student)
            {
                labelGroup.Visible = true;
                comboBoxGroup.Visible = true;
            }
            else
            {
                labelGroup.Visible = false;
                comboBoxGroup.Visible = false;
            }
            try
            {
                if (!IsNew)
                {
                    con.Open();
                    // join \"Sys_admin\" s on(u.\"Id\"=s.\"user_id\")
                    NpgsqlCommand cmd = new NpgsqlCommand($"SELECT u.\"Id\",u.\"Name\",u.\"Surname\",u.\"Patronymic\",u.\"Login\",u.\"Password\" FROM \"User\" u WHERE u.\"Id\"={id}", con);
                    using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.HasRows)
                        {
                            DataTable t = new DataTable();
                            t.Load(rdr);
                            textBoxName.Text = t.Rows[0].ItemArray[1].ToString();
                            textBoxSurname.Text = t.Rows[0].ItemArray[2].ToString();
                            textBoxPatronymic.Text = t.Rows[0].ItemArray[3].ToString();
                            textBoxEmail.Text = t.Rows[0].ItemArray[4].ToString();
                            textBoxCurPass.Text = t.Rows[0].ItemArray[5].ToString();

                        }
                    }
                    con.Close();
                }
                if (userType==UserType.Student)
                {
                    

                    con.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand($"SELECT * FROM \"Group\" ORDER BY \"id\" ", con);
                    using (NpgsqlDataReader rdr = cmd.ExecuteReader())
                    {
                       
                            DataTable t = new DataTable();
                            t.Load(rdr);
                            comboBoxGroup.DataSource = t;
                            comboBoxGroup.DisplayMember = "Group_name";
                       
                    }
                    con.Close();
                }
                else
                {
                    labelGroup.Visible = false;
                    comboBoxGroup.Visible = false;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (IsNew)
                {
                        int UserId;

                        con.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand($"INSERT INTO \"User\"(\"Login\",\"Password\",\"Name\",\"Surname\",\"Patronymic\")" +
                        $" VALUES('{textBoxEmail.Text}','{textBoxCurPass.Text}','{textBoxName.Text}','{textBoxSurname.Text}','{textBoxPatronymic.Text}')",con);
                        cmd.ExecuteNonQuery();
                        //rdr.Close();
                        
                        NpgsqlCommand cmdSelect = new NpgsqlCommand($"SELECT MAX(\"Id\") FROM \"User\"",con);
                        NpgsqlDataReader rdrSelect = cmdSelect.ExecuteReader();
                        DataTable t = new DataTable();
                        t.Load(rdrSelect);
                        UserId = Convert.ToInt32(t.Rows[0].ItemArray[0].ToString());
                        rdrSelect.Close();
                        
                        
                        if (userType == UserType.Teacher)
                        {
                            NpgsqlCommand cmdTeacherInsert = new NpgsqlCommand($"INSERT INTO \"Teacher\"(\"User_id\") VALUES({UserId})",con);
                            cmdTeacherInsert.ExecuteNonQuery();
                        }
                        if (userType == UserType.Student)
                        {
                            string GroupName = comboBoxGroup.Text;
                             NpgsqlCommand cmdSelectGr = new NpgsqlCommand($"SELECT \"id\" FROM \"Group\" WHERE \"Group_name\"='{GroupName}'", con);
                            NpgsqlDataReader rdrSelectGr = cmdSelectGr.ExecuteReader();
                            t = new DataTable();
                            t.Load(rdrSelectGr);
                            int GroupId = Convert.ToInt32(t.Rows[0].ItemArray[0].ToString());
                            rdrSelectGr.Close();

                            NpgsqlCommand cmdTeacherInsert = new NpgsqlCommand($"INSERT INTO \"Student\"(\"User_id\",\"Group_id\") VALUES({UserId},{GroupId})", con);
                            cmdTeacherInsert.ExecuteNonQuery();

                    }
                        con.Close();
                }
                else
                {
                    con.Open();

                    NpgsqlCommand cmd = new NpgsqlCommand($"UPDATE \"User\" " +
                    $" SET \"Name\"='{textBoxName.Text}'," +
                    $"\"Surname\"='{textBoxSurname.Text}'," +
                    $"\"Patronymic\"='{textBoxPatronymic.Text}'," +
                    $"\"Login\"='{textBoxEmail.Text}'," +
                    $"\"Password\"='{textBoxCurPass.Text}'" +
                    $" WHERE \"Id\"={id}", con);                    

                    NpgsqlDataReader rdr = cmd.ExecuteReader();

                    MessageBox.Show("Редактирование выполнено успешно.");
                    rdr.Close();
                    
                    if (userType == UserType.Student)
                    {
                        string GroupName = comboBoxGroup.Text;
                        NpgsqlCommand cmdSelectGr = new NpgsqlCommand($"SELECT \"id\" FROM \"Group\" WHERE \"Group_name\"='{GroupName}'", con);
                        NpgsqlDataReader rdrSelectGr = cmdSelectGr.ExecuteReader();
                        DataTable t = new DataTable();
                        t.Load(rdrSelectGr);
                        int GroupId = Convert.ToInt32(t.Rows[0].ItemArray[0].ToString());
                        rdrSelectGr.Close();

                        NpgsqlCommand cmdTeacherUpdate = new NpgsqlCommand($"UPDATE \"Student\" SET \"Group_id\"= ({GroupId}) WHERE \"User_id\"={id}", con);
                        cmdTeacherUpdate.ExecuteNonQuery();
                    }
                    con.Close();
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
