using ProjectSp.Features.User.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSp.Features.User.Data
{
    public class UserDAO
    {
        public UserEntity GetUser(int Id)
        {
            return Locator.GetUserDbContext().StoredUser.Find(Id);
        }

        public void AddUser(UserEntity entity)
        {
            Locator.GetUserDbContext().Entry(entity).State = System.Data.Entity.EntityState.Added;
            Locator.GetUserDbContext().SaveChanges();
        }

        public void RemoveUser(UserEntity entity)
        {
            Locator.GetUserDbContext().Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            Locator.GetUserDbContext().SaveChanges();
        }

        public void UpdateUser(UserEntity entity)
        {
            Locator.GetUserDbContext().Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Locator.GetUserDbContext().SaveChanges();
        }
    }
}