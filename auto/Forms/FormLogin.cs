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

            label1.Visible = false;
        }

        public FormLogin(MainMenu main)
        {
            InitializeComponent();

            label1.Visible = false;
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
                InfoUser info = new InfoUser();
                info.setIdUser(user.idUser);
                info.setUserName(name);
                this.Dispose();
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            FormRegistration registration = new FormRegistration();
            registration.Show();
        }
    }
}
