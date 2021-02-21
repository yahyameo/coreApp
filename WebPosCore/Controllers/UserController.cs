using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using WebPOSApi.Models;

namespace WebPOSApi.Controllers
{
    [Authorize]
    public class UserController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet]
        public dynamic Signin()
        {
            var baseUrl = Request.GetRequestContext();
            Token token = new Token();
            using (var client = new HttpClient())
            {
                var form = new Dictionary<string, string>
               {
                   {"grant_type", "password"},
                   {"username", "salman@madina.com"},
                   {"password", "0304877783800"},
               };
                var url = "http://" + baseUrl.Url.Request.RequestUri.Authority;
                var tokenResponse = client.PostAsync(url+"/oauth/token", new FormUrlEncodedContent(form)).Result;
                var _token = tokenResponse.Content.ReadAsStringAsync().Result;
                token = tokenResponse.Content.ReadAsAsync<Token>(new[] { new JsonMediaTypeFormatter() }).Result;
                if (string.IsNullOrEmpty(token.Error))
                {
                    Console.WriteLine("Token issued is: {0}", token.AccessToken);
                    Console.WriteLine("Token Type: {0}", token.TokenType);
                }
                else
                {
                    Console.WriteLine("Error : {0}", token.Error);
                }
                return token;
            }
        }
        [AllowAnonymous]
        [HttpPost]
        public Response AuthenticateUser(UserVM model)
        {
            return UserVM.AuthenticateUser(model);
        }
        [HttpGet]
        public UserRole GetUserRoles(int roleId)
        {
            return UserVM.GetUserRoles(roleId);
        }
        [HttpPost]
        public dynamic StartDay(StartDayVM startDayVM)
        {
            return UserVM.StartDay(startDayVM);
        }
        [HttpPost]
        public dynamic EndDay(StartDayVM startDayVM)
        {
            return UserVM.EndDay(startDayVM);
        }
        [HttpGet]
        public dynamic GetStartDayHistory(int branchId, DateTime fromDate, DateTime toDate)
        {
            return UserVM.GetStartDayHistory(branchId, fromDate, toDate);
        }
    }
}
