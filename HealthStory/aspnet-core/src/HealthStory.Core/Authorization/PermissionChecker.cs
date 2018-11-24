using Abp.Authorization;
using HealthStory.Authorization.Roles;
using HealthStory.Authorization.Users;

namespace HealthStory.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
