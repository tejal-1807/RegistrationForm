using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace registrationform
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-4FDHBTK\\SQLEXPRESS;Initial Catalog=userrrgcs;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[register]
           ([firstname]
           ,[lastname]
           ,[address]
           ,[gender]
           ,[email]
           ,[phone]
           ,[username]
           ,[password])
     VALUES
           ('" + txtFname.Text + "', '" + txtLname.Text + "', '" + txtAdd.Text + "', '" + cmbGender.SelectedItem.ToString() + "', '" + txtEmail.Text + "', '" + txtPhone.Text + "', '" + txtUser.Text + "', '" + txtPass.Text + "')", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Register Successfully");


        }
    }
}