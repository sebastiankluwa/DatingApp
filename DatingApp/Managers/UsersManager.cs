using Local.DTOs;
using Local.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using API.Controllers;
using API.DTOs;
using Microsoft.AspNetCore.Http;
using MemberDto = Local.DTOs.MemberDto;
using MemberUpdateDto = API.DTOs.MemberUpdateDto;

namespace Local.Managers
{
    public interface IUsersManager
    {
        Task<MemberDto> GetUserByUsername(string username);
        Task<List<MemberDto>> GetUsers(UserParams userParams);
        Task<bool> UpdateUser(MemberUpdateDto memberUpdate);
        Task<PhotoDto> AddPhoto(string location);
        Task SetMainPhoto(int photoId);
        Task DeletePhoto(int photoId);
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

            var approvedPhotos = memberDto.Photos.Where(x => x.IsApproved).ToList();
            memberDto.Photos = approvedPhotos;

            return memberDto;
        }

        public async Task<List<MemberDto>> GetUsers(UserParams userParams)
        {
            var url = Constants.Api.DefaultRoutePaths.Users + "?gender=" + userParams.Gender + "&minAge=" + userParams.MinAge + "&maxAge=" + userParams.MaxAge 
                + "&OrderBy=" + userParams.OrderBy + "&pageSize=" + userParams.PageSize + "&pageNumber=" + userParams.PageNumber;

            var jsonResult = await ApiHelper.Get(url, _container.AccountManager.User.Token);
            var memberDtos = JsonConvert.DeserializeObject<List<MemberDto>>(jsonResult);

            return memberDtos;
        }

        public async Task<bool> UpdateUser(MemberUpdateDto memberUpdate)
        {
            var url = Constants.Api.DefaultRoutePaths.Users;

            var json = JsonConvert.SerializeObject(memberUpdate);

            var jsonResult = await ApiHelper.Put(url, json, _container.AccountManager.User.Token);

            if (!string.IsNullOrEmpty(jsonResult))
                return false;

            return true;
        }

        public async Task<PhotoDto> AddPhoto(string location)
        {
            //var url = Constants.Api.DefaultRoutePaths.AddPhoto + "?location=" + location;
            var locationQuery = HttpUtility.UrlEncode(location);

            var path = Constants.Api.DefaultRoutePaths.AddPhoto + "/" + locationQuery;

            var jsonResult = await ApiHelper.Post(path, "", _container.AccountManager.User.Token);

            var photoDto = JsonConvert.DeserializeObject<PhotoDto>(jsonResult);

            return photoDto;
        }

        public async Task SetMainPhoto(int photoId)
        {
            var url = Constants.Api.DefaultRoutePaths.SetMainPhoto;

            var jsonResult = await ApiHelper.Put(url + "/" + photoId, "", _container.AccountManager.User.Token);
        }

        public async Task DeletePhoto(int photoId)
        {
            var url = Constants.Api.DefaultRoutePaths.DeletePhoto;

            var jsonResult = await ApiHelper.Delete(url + "/" + photoId, _container.AccountManager.User.Token);
        }
    }

}
