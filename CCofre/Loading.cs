using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CCofre
{
    public partial class Loading : Form
    {
        //Thread nt;
        public Loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;

                //this.Close();
                //nt = new Thread(OpenLogin);
                //nt.SetApartmentState(ApartmentState.MTA);
                //nt.Start();

                Login l = new Login();
                l.Show();

                this.Visible = false;
            }
        }

        //private void OpenLogin(object obj)
        //{
        //    Application.Run(new Login());
        //}
    }
}
