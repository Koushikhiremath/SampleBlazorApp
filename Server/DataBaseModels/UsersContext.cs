using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Server.DataBaseModels
{
    public class UsersContext:DbContext
    {
        public UsersContext(DbContextOptions<UsersContext> contextOptions):base(contextOptions)
        {

        }

        public DbSet<Users> users { get; set; }

    }
}
