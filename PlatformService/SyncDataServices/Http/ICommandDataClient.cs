using System.Threading.Tasks;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http 
{
    public interface ICommandDataClient {
        Task SendPlatformToCommandService(PlatformReadDto platfor);
    }
}