using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EposSystem
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private bool _firstTime = false;

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            LblLoadingMsgs.Text = "Initializing...";
            try
            {
                System.IO.Directory.CreateDirectory("C:\\KongolianSystems\\Licences");

                var ft = new System.IO.StreamReader("C:\\KongolianSystems\\firstTime.ID");
                string txtFirstTime = ft.ReadToEnd();
                ft.Close();

                var ls = new System.IO.StreamReader("C:\\KongolianSystems\\Licences\\License.ID");
                string txtLicense = ls.ReadToEnd();
                ls.Close();

                LblLoadingMsgs.Text = txtFirstTime;
                lblLisence.Text = "Licensed To: " + txtLicense;

                if (txtFirstTime == "True"){ _firstTime = true; }
                



            }
            catch (Exception ex)
            {
                if (ex is FileNotFoundException || ex is DirectoryNotFoundException)
                {
                    DirectoryInfo di = new DirectoryInfo(@"C:\KongolianSystems\Licences");
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete(true);

                    }
                    System.IO.Directory.CreateDirectory("C:\\KongolianSystems\\Licences");

                    var ft = new System.IO.StreamWriter("C:\\KongolianSystems\\firstTime.ID");
                    ft.Write("True");
                    ft.Close();

                    var ls = new System.IO.StreamWriter("C:\\KongolianSystems\\Licences\\License.ID");
                    ls.Write("NULL");
                    ls.Close();

                    Application.Restart();
                    Environment.Exit(0);


                }

                throw;

            }
        }
        private int totalLoadTime = 0;
        private void Timer_Tick(object sender, EventArgs e)
        {
           
            if (totalLoadTime == 0)
            {
                LblLoadingMsgs.Text = "Initializing System...";
            } else if (totalLoadTime == 1)
            {
                LblLoadingMsgs.Text = "Loading Users...";
            } else if (totalLoadTime == 2)
            {
                LblLoadingMsgs.Text = "Starting DataBase....";
            }
            else if (totalLoadTime == 3)
            {
                LblLoadingMsgs.Text = "Loading Users...";
            }
            else if (totalLoadTime == 4)
            {
                LblLoadingMsgs.Text = "Finalizing GUI...";
            }
            else if (totalLoadTime == 5)
            {
                LblLoadingMsgs.Text = "...";
                if(_firstTime == true)
                {
                    FirstTime scrnlogin = new FirstTime();
                    this.Hide();
                    scrnlogin.Show();
                }
                else
                {
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
                

            }

            totalLoadTime++;
        }
    }
}
