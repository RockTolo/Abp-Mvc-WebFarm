using Abp.AutoMapper;
using Tolo.MyAbp.Sessions.Dto;

namespace Tolo.MyAbp.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
