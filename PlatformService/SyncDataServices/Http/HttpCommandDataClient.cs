using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using PlatformService.Dtos;

namespace PlatformService.SyncDataServices.Http
{
    public class HttpCommandDataClient : ICommandDataClient
    {
        private readonly HttpClient _httpClient;

        public IConfiguration _configuration { get; }

        public HttpCommandDataClient(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task SendPlatformToCommandService(PlatformReadDto platform)
        {
            var httpContent = new StringContent(
                JsonSerializer.Serialize(platform), 
                Encoding.UTF8, 
                "application/json");
            
            var response = await _httpClient.PostAsync($"{_configuration["CommandService"]}", httpContent);

            if (response.IsSuccessStatusCode) {
                Console.WriteLine("--> Platform send to Command Service was OK");
            } else {
                Console.WriteLine("--> Platform send to Command Service was not OK");
            }
        }
    }
}