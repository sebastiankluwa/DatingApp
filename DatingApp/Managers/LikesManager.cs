using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.DTOs;
using Local.DTOs;
using Local.DTOs.Messages;
using Local.Helpers;
using Newtonsoft.Json;

namespace Local.Managers
{
    public interface ILikesManager
    {
        void AddLike(string username);
        Task<List<LikeDto>> GetUserLikes(int userId, string predicate);
    }

    public class LikesManager : ILikesManager
    {
        private readonly IContainer _container;

        public LikesManager(IContainer container)
        {
            _container = container;
        }

        public async void AddLike(string username)
        {
            var url = Constants.Api.DefaultRoutePaths.Likes + "/" + username;
            try
            {
                var jsonResult = await ApiHelper.Post(url, "", _container.AccountManager.User.Token);

            }
            catch (Exception e)
            {
            }
        }

        public async Task<List<LikeDto>> GetUserLikes(int userId, string predicate)
        {
            var url = Constants.Api.DefaultRoutePaths.Likes + "?userid=" + userId + "&predicate=" + predicate;
            var jsonResult = await ApiHelper.Get(url, _container.AccountManager.User.Token);
            var messages = JsonConvert.DeserializeObject<List<LikeDto>>(jsonResult);

            return messages;
        }
    }
}
