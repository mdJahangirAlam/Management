using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace mass
{
    public partial class create : Form
    {
        login log_in = new login();
        static String c_str = @"Data Source=DESKTOP-4AVRUE7\NOORSQL;Initial Catalog=mass;Integrated Security=True";
        SqlConnection connect = new SqlConnection(c_str);
        public create()
        {
            InitializeComponent();
        }

        private void create_m_Click(object sender, EventArgs e)
        {
            if (m_name.Text == null || c_password == null)
            {
                MessageBox.Show("Insert all Information");
            }
            else
            {
                try
                {
                    ControlID.TextData = m_name.Text;
                    String query = "create table  " + m_name.Text + " (id int not null identity primary key," +
                        "name varchar(20) not null,meal float,totalcost float,meal_rate float,advance float,account float,mobile int)";
                    String insert_query = "insert into mass_manager (name,password,starting_month)" +
                        " values ('" + m_name.Text + "','" + c_password.Text + "','" + month.Text + "')";
                    string sql = "INSERT INTO " + m_name.Text + " (name,meal,totalcost,meal_rate,advance,account,mobile) " +
                                    "VALUES('manager','0','0','0','0','0','0')";
                    connect.Open();
                    SqlCommand insert_c = new SqlCommand(insert_query, connect);
                    insert_c.ExecuteNonQuery();
                    SqlCommand mycommand = new SqlCommand(query, connect);
                    int t = mycommand.ExecuteNonQuery();
                    connect.Close();
                    if (t < 0)
                    {
                        connect.Open();
                        SqlCommand mm = new SqlCommand(sql, connect);
                        mm.ExecuteNonQuery();
                        this.Hide();
                        log_in.login_method(m_name.Text.ToString(), c_password.Text.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
