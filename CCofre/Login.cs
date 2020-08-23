using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CCofre
{
    public partial class Login : Form
    {
        //Thread nt;
        public Login()
        {
            this.WindowState = FormWindowState.Normal;
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            lblMsg.Text = "";

            if (string.IsNullOrEmpty(txtLogin.Text.Trim()))
            {
                lblMsg.Text = "Informe o login!";
                return;
            }

            if (string.IsNullOrEmpty(txtSenha.Text.Trim()))
            {
                lblMsg.Text = "Digite sua senha!";
                return;
            }

            ValidarUsuario(txtLogin.Text, txtSenha.Text);
        }
        protected void ValidarUsuario(string login, string senha)
        {
            if (login.Trim() != "wolney")
            { 
                lblMsg.Text = "Login incorreto!"; 
                return; 
            }

            if (senha.Trim() != "1234")
            {
                lblMsg.Text = "Senha inválida!";
                return;
            }

            // Usuário logou
            //this.Close();
            //nt = new Thread(OpenMain);
            //nt.SetApartmentState(ApartmentState.MTA);
            //nt.Start();

            this.Visible = false;

            Main m = new Main();
            m.Show();
        }

        //private void OpenMain(object obj)
        //{
        //    Application.Run(new Main());
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
