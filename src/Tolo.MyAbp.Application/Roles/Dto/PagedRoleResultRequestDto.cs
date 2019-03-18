using Abp.Application.Services.Dto;

namespace Tolo.MyAbp.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

