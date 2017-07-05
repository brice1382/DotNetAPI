using ProjectSp.Features.User.Entity;
using ProjectSp.Features.User.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSp.Features.User.Configuration
{
    public class UserMapper : AutoMapper.Profile
    {
        public UserMapper()
        {
            CreateMap<UserModel, UserEntity>();
            CreateMap<UserEntity, UserModel>();
        }
    }
}