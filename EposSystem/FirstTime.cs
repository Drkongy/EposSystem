using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace EposSystem
{
    public partial class FirstTime : Form
    {
        
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Coding\Work\EposSystem\EposSystem\EposDB.mdf;Integrated Security=True");

        public FirstTime()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if (TBOrg.Text == "" || TBBranch.Text == "" || TBName.Text == "" || TBEmail.Text == "" || TBCode.Text == "" || TBPassword.Text == "")
            {
                LblError.Text = "Please make sure that all fields are filled!";
            }
            else
            {
                var ls = new System.IO.StreamWriter("C:\\KongolianSystems\\Licences\\License.ID");
                ls.Write(TBOrg.Text);
                ls.Close();

                var d = new System.IO.StreamWriter("C:\\KongolianSystems\\Licences\\inf.ID");
                d.WriteLine(TBOrg.Text);
                d.WriteLine(TBBranch.Text);
                d.WriteLine(TBName.Text);
                d.WriteLine(TBEmail.Text);
                d.Close();

                String Enc;
                Enc = Convert.ToBase64String(Encoding.Unicode.GetBytes(TBPassword.Text));
                System.IO.Directory.CreateDirectory("C:\\KongolianSystems\\Users\\" + TBCode.Text);
                var id = new System.IO.StreamWriter("C:\\KongolianSystems\\Users\\" + TBCode.Text + "\\ID");
                id.WriteLine(TBName.Text);//name
                id.WriteLine("ADMINISTRATOR");//access level
                id.WriteLine(TBCode.Text);// id
                id.WriteLine(Enc);// password
                id.Close();

                var ft = new System.IO.StreamWriter("C:\\KongolianSystems\\firstTime.ID");
                ft.Write("False");
                ft.Close();


                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Users (Name,Email,Admin, Creation) Values (@Name,@Email,@Admin,@Creation)";
                cmd.Parameters.AddWithValue("@Name", TBName.Text);
                cmd.Parameters.AddWithValue("@Email", TBEmail.Text);
                cmd.Parameters.AddWithValue("@Admin", 1);
                cmd.Parameters.AddWithValue("@Creation", DateTime.Now);
                cmd.ExecuteNonQuery();
                conn.Close();

                



                MessageBox.Show("Data Uploaded To DataBase...");
                MessageBox.Show("System Restarting... Press Enter To Continute");

                Application.Restart();
                Environment.Exit(0);

            }
        }

        private void TBCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);  // makes sure only numeral digits can be entered.
        }

        private void TBPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);  // makes sure only numeral digits can be entered.
        }
    }
}
