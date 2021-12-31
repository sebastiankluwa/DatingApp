using Local;
using Local.DTOs;
using Local.Helpers;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.App
{
    public interface IAccountManager
    {
        UserDto User { get; set; }

        Task<bool> Login(LoginDto loginDto);
        Task<bool> Register(RegisterDto registerDto);
        void LogOut();
    }

    public class AccountManager : IAccountManager
    {
        public UserDto User { get; set; }

        private HubConnection _connection;

        public async Task<bool> Login(LoginDto loginDto)
        {
            try
            {
                var json = JsonConvert.SerializeObject(loginDto);

                var jsonResult = await ApiHelper.Post(Constants.Api.DefaultRoutePaths.Login, json);

                var userDto = JsonConvert.DeserializeObject<UserDto>(jsonResult);

                this.User = userDto;

                connectToPresenceHub();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Register(RegisterDto registerDto)
        {
            try
            {
                var json = JsonConvert.SerializeObject(registerDto);

                var jsonResult = await ApiHelper.Post(Constants.Api.DefaultRoutePaths.Register, json);
                var userDto = JsonConvert.DeserializeObject<UserDto>(jsonResult);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public void LogOut()
        {
            this.User = null;
            disconnectFromPresenceHub();
        }

        private async void connectToPresenceHub()
        {
            _connection = new HubConnectionBuilder()
            .WithUrl(new Uri(Constants.Api.HubUrl + Constants.Api.HubRoutePaths.PresenceHub), opt =>
            {
                opt.AccessTokenProvider = () => Task.FromResult(User.Token);
            })
            .WithAutomaticReconnect()
            .Build();

            try
            {
                await _connection.StartAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void disconnectFromPresenceHub()
        {
            _connection.StopAsync();
        }
    }
}
