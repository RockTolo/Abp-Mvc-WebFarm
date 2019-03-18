using System.Collections.Generic;
using Tolo.MyAbp.Roles.Dto;
using Tolo.MyAbp.Users.Dto;

namespace Tolo.MyAbp.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
