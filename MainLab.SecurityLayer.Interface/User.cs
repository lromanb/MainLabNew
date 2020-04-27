using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLab.SecurityLayer
{
    public class User
    {

        private string Login;
        private string Name;
        private int RoleCod;

        public User(string login, string name, int roleCod)
        {
            Login = login;
            Name = name;
            RoleCod = roleCod;
        }

        public int GetUserRoleCode()
        {
            return this.RoleCod;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
