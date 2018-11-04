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
    public partial class home : Form
    {
        login ln = new login();
        String current_login = "";
        static String c_str = @"Data Source=DESKTOP-4AVRUE7\NOORSQL;Initial Catalog=mass;Integrated Security=True";
        SqlConnection connect = new SqlConnection(c_str);
        public home()
        {
            InitializeComponent();
            view_list();
        }

        private void add_new_Click(object sender, EventArgs e)
        {
            mumber_p.Visible = true;
            mumber_p.BringToFront();
        }

        private void s_add_money_Click(object sender, EventArgs e)
        {
            add_email.Visible = true;
            add_email.BringToFront();
        }

        private void file_home_Click(object sender, EventArgs e)
        {
            carrier.Visible = false;
            //mass_home_p.Visible = true;
            //mass_home_p.BringToFront();
        }

        private void file_view_Click(object sender, EventArgs e)
        {
            view_list();
        }
        private void view_list()
        {
            try
            {
                int i = 0;
                //connect.Open();
                carrier.Visible = true;
                carrier.BringToFront();
                this.current_login = ControlID.TextData;
                SqlDataAdapter da = new SqlDataAdapter("select * from " + this.current_login + "", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    float f = float.Parse(dt.Rows[i][3].ToString());
                    dt.Rows[i][3] = f.ToString("#.00");
                    f = float.Parse(dt.Rows[i][4].ToString());
                    dt.Rows[i][4] = f.ToString("#.00");
                    f = float.Parse(dt.Rows[i][6].ToString());
                    dt.Rows[i][6] = f.ToString("#.00");
                    i++;
                }
                carrier.DataSource = dt;
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Meal_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
                if (mealer_id.Text == null || meal_count.Text == null)
                    MessageBox.Show("Insert all");
                else
                {
                    connect.Open();
                    String rate = "";
                    SqlCommand cmd = new SqlCommand("update " + current_login + " set meal = meal+1 where id = " + mealer_id.Text.ToString() + " or id = '1'", connect);
                    cmd.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("update " + current_login + " set meal_rate = totalcost/meal where id = '1'", connect);
                    cmd1.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter("select * from " + this.current_login + " where id =1", connect);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach(DataRow dr in dt.Rows)
                    {
                        rate =dr["meal_rate"].ToString();
                    }
                    SqlCommand cmd2 = new SqlCommand("update " + current_login + " set meal_rate = "+rate+", totalcost = meal*"+rate+" where id !=1", connect);
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand("update " + current_login + " set account = advance-totalcost", connect);
                    cmd3.ExecuteNonQuery();
                    view_list();
                    add_p.Visible = false;
                    connect.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void b_add_p_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
                connect.Open();
                MessageBox.Show(current_login);
                string sql = "INSERT INTO [" +current_login + "] VALUES('" + add_name.Text + "','0','0','0','0','0','" + add_mobile.Text + "','')";
                SqlCommand test = new SqlCommand(sql, connect);
                test.ExecuteNonQuery();
                view_list();
                mumber_p.Visible = false;
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void del_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
                connect.Open();
                String s = "delete from " + current_login + " where id = " + taka_id.Text + "";
                SqlCommand del = new SqlCommand(s, connect);
                del.ExecuteNonQuery();
                connect.Close();
                add_p.Visible = false;
                view_list();
            }
            catch (Exception dl)
            {
                MessageBox.Show(dl.ToString());
            }
        }

        private void taka_ok_Click(object sender, EventArgs e)
        {
            if (taka_id.Text == null || taka.Text == null)
                MessageBox.Show("Insert all");
            else
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
                connect.Open();

                string insert_q = "update [" + current_login + "] set advance = advance + "+taka.Text+",account = account+"+taka.Text+" where id = " + taka_id.Text + " or id = 1";
                SqlCommand test = new SqlCommand(insert_q, connect);
                test.ExecuteNonQuery();
                taka_id.Text = "";
                taka.Text = "";
                add_p.Visible = false;
                view_list();
                connect.Close();
            }
        }

        private void b_add_c_Click(object sender, EventArgs e)
        {
            mumber_p.Visible = false;
        }

        private void addCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cost_p.Visible = true;
            cost_p.BringToFront();
        }

        private void cost_b_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
                if (cost_t.Text =="")
                    MessageBox.Show("Insert all");
                else
                {
                    connect.Open();
                    String rate = "";
                    SqlCommand test1 = new SqlCommand("update [" + current_login + "] set totalcost = totalcost + " + cost_t.Text + ",account = account-" + cost_t.Text + " where id = 1", connect);
                    test1.ExecuteNonQuery();
                    SqlCommand cmd1 = new SqlCommand("update [" + current_login + "] set meal_rate = totalcost/meal where id = 1", connect);
                    cmd1.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter("select * from " + this.current_login + " where id=1", connect);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        rate = dr["meal_rate"].ToString();
                    }
                    SqlCommand cmd2 = new SqlCommand("update [" + current_login + "] set meal_rate = " + rate + ", totalcost = meal*" + rate + " where id !=1", connect);
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand("update [" + current_login + "] set account = advance - totalcost", connect);
                    cmd3.ExecuteNonQuery();
                    view_list();
                    cost_p.Visible = false;
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void carrier_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                String s = carrier.SelectedCells[0].Value.ToString();
                SqlDataAdapter da = new SqlDataAdapter("select * from " + current_login + " where id = " + s + "", connect);
                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    taka_id.Text = dr["id"].ToString();
                    mealer_id.Text = taka_id.Text;
                    to.Text = dr["email"].ToString();
                }
                add_p.Visible = true;
                add_p.BringToFront();
            }
            catch(Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_p.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
                connect.Open();
                SqlCommand cmd3 = new SqlCommand("update [" + current_login + "] set email = '" + email.Text + "' where id = " + email_id.Text + "", connect);
                cmd3.ExecuteNonQuery();
                connect.Close();
                email.Text = "";
                email_id.Text = "";
                view_list();
                add_email.Visible = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            email.Text = "";
            email_id.Text = "";
            add_email.Visible = false;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            cost_t.Text = "";
            cost_p.Visible = false;
        }
    }
}
