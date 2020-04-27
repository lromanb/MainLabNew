using MainLab.DataAccess;
using MainLab.Logger;
using MainLab.SecurityLayer.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLab.SecurityLayer
{
    public class SecurityLayerImpl : ISecurityLayer
    {
        private User CurrentUser;
        IDataAccess da;
        ILogger logger;

        public SecurityLayerImpl(IDataAccess da, ILogger logger)
        {
            this.da = da;
            this.logger = logger;
        }

        public int GetCurrentUserRoleCode()
        {
            return CurrentUser.GetUserRoleCode();
        }

        public IEnumerable<User> GetUsersList()
        {
            IEnumerable<string> rawUl = da.GetUsersList().OfType<string>();
            List<User> ul = new List<User>();

            foreach (var st in rawUl)
            {
                string[] record = st.Split(new char[] { ':' });
                ul.Add(new User(record[0], record[1], int.Parse(record[2])));
            }

            return ul;
        }

        public void SetCurrentUser(User u)
        {
            CurrentUser = u;
        }
    }
}
