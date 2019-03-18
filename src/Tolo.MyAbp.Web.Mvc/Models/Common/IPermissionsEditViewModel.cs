using System.Collections.Generic;
using Tolo.MyAbp.Roles.Dto;

namespace Tolo.MyAbp.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}