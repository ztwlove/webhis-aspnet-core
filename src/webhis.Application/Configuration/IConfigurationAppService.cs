using System.Threading.Tasks;
using webhis.Configuration.Dto;

namespace webhis.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
