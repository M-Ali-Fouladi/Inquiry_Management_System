using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace CustomMembershipEF.Interfaces
{
    interface IRegister
    {
        MembershipCreateStatus CreateUser(string UserName, string Name, string Family, string password, string UserEmailAddress);
    }
}
