using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using AutoMapper;
using ProjectSp.Features.User;
using ProjectSp.Features.User.Service;
using ProjectSp.Features.User.Configuration;

namespace ProjectSp.Features.User
{
    public static class Locator
    {
        private static UserDbContext _userDbContext = null;
        public static UserDbContext GetUserDbContext()
        {
            if (Locator._userDbContext == null)
            {
                Locator._userDbContext = new UserDbContext();
            }
            return Locator._userDbContext;
        }

        private static IMapper _mapperConfig;
        public static void ConfigureMapper()
        {
            _mapperConfig = new MapperConfiguration( cfg =>
            {
                cfg.AddProfile<UserMapper>();
            }).CreateMapper();
        }

        public static IMapper Mapper
        {
            get
            {
                if (_mapperConfig == null) ConfigureMapper();
                return _mapperConfig;
            }
        }

        public static UserService GetUserService()
        {
            return new UserService();
        }
    }
}