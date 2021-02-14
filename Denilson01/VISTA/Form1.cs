using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Denilson01.DOMINIO;
using Denilson01.NEGOCIO;

namespace Denilson01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.User = txtUser.Text;
            log.Password = txtPassword.Text;

            ClsLogin cls = new ClsLogin();

            int variableevalucion = cls.acceso(log);

            if (variableevalucion == 1)
            {

                MessageBox.Show("WELCOME");

            }
            else
            {
                MessageBox.Show("FALSE");
            }

        }

    }
    
}
