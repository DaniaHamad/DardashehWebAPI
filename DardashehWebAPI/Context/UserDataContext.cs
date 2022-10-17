using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DardashehWebAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DardashehWebAPI.Data
{
    public class UserDataContext : IdentityDbContext
    { 
        public UserDataContext (DbContextOptions<UserDataContext> options)
            : base(options)
        {
        }

        //public DbSet<User> tblUsers { get; set; } = default!;
    }
}
