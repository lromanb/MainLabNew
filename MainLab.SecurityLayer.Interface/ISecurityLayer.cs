using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLab.SecurityLayer.Interface
{
    public interface ISecurityLayer
    {
        
        IEnumerable<User> GetUsersList();
        int GetCurrentUserRoleCode();
        void SetCurrentUser(User u);
    }
}
