using System.Threading.Tasks;
using Abp.Application.Services;
using Tolo.MyAbp.Sessions.Dto;

namespace Tolo.MyAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
