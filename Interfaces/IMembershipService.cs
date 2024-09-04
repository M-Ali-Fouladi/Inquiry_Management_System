using System.Web.Security;

namespace CustomMembershipEF.Interfaces
{
    public interface IMembershipService
    {
        int MinPasswordLength { get; }
        
        bool ValidateUser(string userName, string password);
        MembershipCreateStatus CreateUser(string UserName, string password, string UserEmailAddress);
        bool ChangePassword(string userName, string oldPassword, string newPassword);

    }
}
