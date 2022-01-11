using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Local.Helpers
{
    public static class ApiHelper
    {
        private static readonly string BaseUri = Constants.Api.Url;

        public static async Task<string> Get(string name, string accessToken = null)
        {
            using (var client = new HttpClient())
            {
                if (accessToken != null)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var responseData = await client.GetAsync(BaseUri + name);

                if (responseData.IsSuccessStatusCode)
                {
                    var results = await responseData.Content.ReadAsByteArrayAsync();
                    return Encoding.UTF8.GetString(results);
                }
            }

            throw new Exception("Could not fetch the data.");
        }

        public static async Task<string> Post(string name, string contentData, string accessToken = null)
        {
            using (var client = new HttpClient())
            {
                if (accessToken != null)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var content = new StringContent(contentData, Encoding.UTF8, "application/json");
                var responseData = await client.PostAsync(BaseUri + name, content);

                if (responseData.IsSuccessStatusCode)
                {
                    var results = await responseData.Content.ReadAsByteArrayAsync();
                    return Encoding.UTF8.GetString(results);
                }
            }

            throw new Exception("Could not update the data.");
        }

        public static async Task<string> Put(string name, string contentData, string accessToken = null)
        {
            using (var client = new HttpClient())
            {
                if (accessToken != null)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var content = new StringContent(contentData, Encoding.UTF8, "application/json");

                var responseData = await client.PutAsync(BaseUri + name, content);

                if (responseData.IsSuccessStatusCode)
                {
                    var results = await responseData.Content.ReadAsByteArrayAsync();
                    return Encoding.UTF8.GetString(results);
                }
                else
                {
                    return responseData.StatusCode.ToString();
                }
            }
        }

        #region unauthorized
        //public static async Task<string> Put(string name, string contentData)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        var content = new StringContent(contentData, Encoding.UTF8, "application/json");

        //        var responseData = await client.PutAsync(BaseUri + name, content);

        //        if (responseData.IsSuccessStatusCode)
        //        {
        //            var results = await responseData.Content.ReadAsByteArrayAsync();
        //            return Encoding.UTF8.GetString(results);
        //        }
        //        else
        //        {
        //            return responseData.StatusCode.ToString();
        //        }
        //    }
        //}

        public static async Task<string> Delete(string name, string accessToken = null)
        {
            using (var client = new HttpClient())
            {
                if (accessToken != null)
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                var responseData = await client.DeleteAsync(BaseUri + name);

                if (responseData.IsSuccessStatusCode)
                {
                    var results = await responseData.Content.ReadAsByteArrayAsync();
                    return Encoding.UTF8.GetString(results);
                }
                else
                {
                    return responseData.StatusCode.ToString();
                }
            }
        }
        #endregion unauthorized

        public static async Task<string> Put(string name, string contentData, ClaimsPrincipal user)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.FindFirst("access_token").Value);

                var content = new StringContent(contentData, Encoding.UTF8, "application/json");

                var responseData = await client.PutAsync(BaseUri + name, content);

                if (responseData.IsSuccessStatusCode)
                {
                    var results = await responseData.Content.ReadAsByteArrayAsync();
                    return Encoding.UTF8.GetString(results);
                }
            }

            throw new Exception("Could not update the data.");
        }

        public static async Task<string> Delete(string name, ClaimsPrincipal user)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.FindFirst("access_token").Value);

                var responseData = await client.DeleteAsync(BaseUri + name);

                if (responseData.IsSuccessStatusCode)
                {
                    var results = await responseData.Content.ReadAsByteArrayAsync();
                    return Encoding.UTF8.GetString(results);
                }
            }

            throw new Exception("Could not delete the data.");
        }

        public static async Task<HttpResponseMessage> GetResponse(string requestUri, ClaimsPrincipal user)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUri);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.FindFirst("access_token").Value);
                return await client.GetAsync(requestUri);
            }
        }

        public static async Task<HttpResponseMessage> PostResponse(string requestUri, string contentData, ClaimsPrincipal user)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUri);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.FindFirst("access_token").Value);
                var content = new StringContent(contentData, Encoding.UTF8, "application/json");
                return await client.PostAsync(requestUri, content);
            }
        }

        public static async Task<HttpResponseMessage> PutResponse(string requestUri, string contentData, ClaimsPrincipal user)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUri);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.FindFirst("access_token").Value);
                var content = new StringContent(contentData, Encoding.UTF8, "application/json");
                return await client.PutAsync(requestUri, content);
            }
        }

        public static async Task<HttpResponseMessage> DeleteResponse(string requestUri, ClaimsPrincipal user)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUri);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", user.FindFirst("access_token").Value);
                return await client.DeleteAsync(requestUri);
            }
        }
    }
}
