﻿using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brainzzler.Services
{
    public class UserIdenityProvider : IUserIdenityProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserIdenityProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Вижда в базата данни кой е потребителя и връща ид-то му
        /// </summary>
        /// <returns>User.Id -> string format</returns>
        public virtual string GetCurrentUserId()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            return userId;
        }
    }
}
