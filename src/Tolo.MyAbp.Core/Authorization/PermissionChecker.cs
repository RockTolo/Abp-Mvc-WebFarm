using Abp.Authorization;
using Tolo.MyAbp.Authorization.Roles;
using Tolo.MyAbp.Authorization.Users;

namespace Tolo.MyAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
