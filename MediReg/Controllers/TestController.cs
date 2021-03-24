﻿using System.Collections.Generic;
using Common.Enums;
using API.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using DAL.Entities;

namespace API.Controllers
{
    [Route("api/Test")]
    [AuthorizeRoles(RoleType.Admin)]
    public class TestController : BaseController
    {
        private UserManager<User> UserManager { get; }

        public TestController(UserManager<User> userManager)
        {
            UserManager = userManager;
        }

        /// <summary>
        /// Добавить Админа
        /// </summary>
        [HttpPost]
        [Route("AddAdmin")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public int AddAdmin()
        {
            return 25;
        }
    }
}
