using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace auto
{
    class InfoUser
    {
        private static int idUser;
        private static string userName;

        public int getidUser()
        {
            return idUser;
        }

        public void setIdUser(int id)
        {
            idUser = id;
        }

        public string getUserName()
        {
            return userName;
        }

        public void setUserName(string name)
        {
            userName = name;
        }
    }
}
