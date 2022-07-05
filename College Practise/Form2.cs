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
using System.Configuration;

namespace College_Practise
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["connect"]);
        public string user;

        private void Form2_Load(object sender, EventArgs e)
        {
            Login lgn = new Login();
            //user = lgn.cmbboxUsertype.Text;

            TotalUser();
            cmbboxUsertype.SelectedIndex = 0;

            string sql = "select * from tbluser";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "user");

            grdUsername.DataSource = ds.Tables["user"];
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text != "" || txtboxPassword.Text != "" || txtboxRetypePass.Text != "" || cmbboxUsertype.SelectedIndex != 0)
            {
                if (txtboxPassword.Text == txtboxRetypePass.Text)
                {
                    string sql = "insert into TblUser (username,password,usertype) values(@username,@password,@usertype)";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@username", txtboxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtboxPassword.Text);
                    cmd.Parameters.AddWithValue("@usertype", cmbboxUsertype.Text);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();//insert,delete,update
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                        MessageBox.Show("User Created Succesfully");
                        ClearBoxes();
                        Form2_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Please Check the Password.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Fill all the Data and Submit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void TotalUser()
        {
            string sql = "select COUNT(Userid) from TblUser";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "countuser");

            label1.Text = "Total User:" + " " + ds.Tables["countuser"].Rows[0][0].ToString();
        }

        public int userid = 0;

        private void grdUsername_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.grdUsername.Rows[e.RowIndex];
                    userid = Convert.ToInt32(row.Cells["userid"].Value.ToString());
                    txtboxUsername.Text = row.Cells["username"].Value.ToString();
                    txtboxPassword.Text = row.Cells["password"].Value.ToString();
                    cmbboxUsertype.Text = row.Cells["usertype"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Select Valid index");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "Delete from TblUser where userid=@id and username=@username";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@username", txtboxUsername.Text);
            cmd.Parameters.AddWithValue("@id", userid);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();//insert,delete,update
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
                MessageBox.Show("User Deleted Succesfully");
                ClearBoxes();
                Form2_Load(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (userid != 0)
            {
                if (txtboxPassword.Text == txtboxRetypePass.Text)
                {
                    string sql = "Update TblUser set username=@username,password=@password,usertype=@usertype where userid=@userid";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@username", txtboxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtboxPassword.Text);
                    cmd.Parameters.AddWithValue("@usertype", cmbboxUsertype.Text);
                    cmd.Parameters.AddWithValue("@userid", userid);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();//insert,delete,update
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        con.Close();
                        MessageBox.Show("User Updated Succesfully");
                        ClearBoxes();
                        Form2_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("Please check the password and try again", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select Particular data to edit", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearBoxes()
        {
            txtboxUsername.Clear();
            txtboxPassword.Clear();
            txtboxRetypePass.Clear();
            cmbboxUsertype.SelectedIndex = 0;
            txtboxSearchByUsername.Clear();
            userid = 0;
            txtboxSearchByUsername.Clear();
        }

        private void txtboxSearchByUsername_TextChanged(object sender, EventArgs e)
        {
            string sql = $"select * from tbluser where username like '{txtboxSearchByUsername.Text}%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "sbu");

            grdUsername.DataSource = ds.Tables["sbu"];
        }
    }
}