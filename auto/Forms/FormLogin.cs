using auto.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto.Forms
{
    public partial class FormLogin : Form
    {
        MainMenu menu;

        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(MainMenu main)
        {
            InitializeComponent();

            menu = main;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            EntitiesAutomobiles automobiles = new EntitiesAutomobiles();

            Users user = automobiles.Users.Where(x => x.login == textLogin.Text && x.password == textPass.Text).FirstOrDefault();
            if(user!=null)
            {
                string name = user.firstName + " " + user.secondName;
                menu.Login(name, user.idUser);
                this.Dispose();
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            FormRegistration registration = new FormRegistration();
            registration.Show();
        }
    }
}
