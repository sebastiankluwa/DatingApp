using Local.DTOs;
using Local.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local.Managers
{
    public interface IUsersManager
    {
        Task<MemberDto> GetUserByUsername(string username);
    }

    public class UsersManager : IUsersManager
    {
        private readonly IContainer _container;

        public UsersManager(IContainer container)
        {
            _container = container;
        }

        public async Task<MemberDto> GetUserByUsername(string username)
        {
            var url = Constants.Api.DefaultRoutePaths.Users + "/" + username;
            var jsonResult = await ApiHelper.Get(url, _container.AccountManager.User.Token);
            var memberDto = JsonConvert.DeserializeObject<MemberDto>(jsonResult);

            return memberDto;
        }
    }
}
