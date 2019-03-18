using System.Collections.Generic;
using Tolo.MyAbp.Roles.Dto;

namespace Tolo.MyAbp.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<RoleListDto> Roles { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
