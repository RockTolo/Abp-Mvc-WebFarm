using System.Threading.Tasks;
using Tolo.MyAbp.Configuration.Dto;

namespace Tolo.MyAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
