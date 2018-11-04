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
    public partial class login : Form
    {
        String current_login = "";
        static String c_str = @"Data Source=DESKTOP-4AVRUE7\NOORSQL;Initial Catalog=mass;Integrated Security=True";
        SqlConnection connect = new SqlConnection(c_str);
        public login()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            this.Hide();
            create cr = new create();
            cr.Show();
        }

        private void in_login_Click(object sender, EventArgs e)
        {
            try
            {
                ControlID.TextData = in_name.Text;
                login_method(in_name.Text.ToString(), in_password.Text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void login_method(String n, String p)
        {
            try
            {
                string query = "select name, password from mass_manager " +
                    "where (name = '" + n + "') and (password='" + p + "')";
                connect.Open();
                SqlCommand mycommand = new SqlCommand(query, connect);
                int t = mycommand.ExecuteNonQuery();
                //connect.Close();
                if (t < 0)
                {
                    home h = new home();
                    this.Hide();
                    h.Show();
                }
                else
                    MessageBox.Show("invalid");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public String log()
        {
            MessageBox.Show(this.current_login);
            return this.current_login;
        }
    }
    public static class ControlID
    {
        public static string TextData { get; set; }
    }
}
