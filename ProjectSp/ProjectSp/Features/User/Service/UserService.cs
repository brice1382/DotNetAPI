using ProjectSp.Features.User.Data;
using ProjectSp.Features.User.Entity;
using ProjectSp.Features.User.Model;
using ProjectSp.Features.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSp.Features.User.Service
{
    public class UserService
    {
        public UserDAO _userDao = null;

        public UserModel GetUser(int Id)
        {
            var Users = _userDao.GetUser(Id);
            return Locator.Mapper.Map<UserModel>(Users);
        }

        public UserService()
        {
            this._userDao = new UserDAO();
        }

        public string AddUser(UserModel model)
        {
            UserEntity newUser = Locator.Mapper.Map<UserEntity>(model);
            this._userDao.AddUser(newUser);

            return true.ToString();
        }

        public void UpdateUser(UserModel model)
        {
            UserEntity newUser = Locator.Mapper.Map<UserEntity>(model);
            this._userDao.UpdateUser(newUser);
        }

        public void RemoveUser(UserModel model)
        {
            UserEntity DlUser = Locator.Mapper.Map<UserEntity>(model);
            this._userDao.RemoveUser(DlUser);
        }
    }
}