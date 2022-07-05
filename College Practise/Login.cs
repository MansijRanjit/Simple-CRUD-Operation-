using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College_Practise
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["connect"]);

        private void Login_Load(object sender, EventArgs e)
        {
            cmbboxUsertype.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtboxUsername.Text != "" && txtboxPassword.Text != "" && cmbboxUsertype.SelectedIndex != 0)
            {
                string sql = $"select * from tbluser where usertype='{cmbboxUsertype.Text}' and username='{txtboxUsername.Text}' and password='{txtboxPassword.Text}'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "login");

                if (Convert.ToInt32(ds.Tables["login"].Rows.Count) >= 1)
                {
                    Form2 frm2 = new Form2();
                    frm2.Show();
                    txtboxUsername.Text = "";
                    txtboxPassword.Text = "";
                    cmbboxUsertype.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Login Data not Found", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter All the data and login", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}