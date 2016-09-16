using Abp.Authorization;
using TaskSystem.Authorization.Roles;
using TaskSystem.MultiTenancy;
using TaskSystem.Users;

namespace TaskSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
