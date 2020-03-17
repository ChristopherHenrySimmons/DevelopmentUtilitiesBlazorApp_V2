using BlazorApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    interface IUserService
    {
        public Task<User> LoginAsync(User user);
    }
}
