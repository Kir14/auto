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
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.firstName = textFirstName.Text;
            user.secondName = textSecondName.Text;
            user.middleName = textMiddleName.Text;
            user.email = textMail.Text;
            user.login = textLogin.Text;
            user.password = textPass.Text;
            user.tel = textTel.Text;
            user.numberDrivingLicense = textCard.Text;
            user.admin = false;

            EntitiesAutomobiles automobiles = new EntitiesAutomobiles();
            automobiles.Users.Add(user);
            automobiles.SaveChanges();
        }
    }
}
