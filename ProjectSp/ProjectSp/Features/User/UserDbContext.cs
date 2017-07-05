using ProjectSp.Features.User.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectSp.Features.User
{
    public class UserDbContext : DbContext
    {
        public UserDbContext() : base("SpireConnect")
        {
            Database.SetInitializer<UserDbContext>(new
                CreateDatabaseIfNotExists<UserDbContext>());
        }

        public virtual DbSet<UserEntity> StoredUser { get; set; }
    }
}