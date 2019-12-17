using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudOperation.Models
{
    public class UserDetailContext:DbContext
    {
        public UserDetailContext(DbContextOptions<UserDetailContext> options):base(options)
        {

        }

        public DbSet<UserDetail> UserDetail { get; set; }
    }
}
