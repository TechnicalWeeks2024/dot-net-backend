using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication35.Models;
using WebApplication35.Context;

namespace WebApplication35.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly RegistryContext _ctx;

        public UserController(ILogger<UserController> logger, RegistryContext context)
        {
            _logger = logger;
            _ctx = context;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _ctx.Users.ToArray();
        }
    }
}
