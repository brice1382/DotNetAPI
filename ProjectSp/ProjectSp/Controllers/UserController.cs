using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Mvc;
using ProjectSp.Features.User;
using ProjectSp.Features.User.Model;

namespace ProjectSp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
        // GET: api/User
        [System.Web.Mvc.AllowAnonymous]
        public List<UserModel> GetAll()
        {
            var db = new UserDbContext();
            var result = db.StoredUser.Select(x => new UserModel
            {
                Id = x.Id,
                Username = x.Username,
                PasswordHash = x.PasswordHash,
                Email = x.Email,
                IsActive = x.IsActive
            }).ToList();
            return result;
        }
        
        // GET: api/User/5
        public JsonResult<UserModel> Get(int Id)
        {
            var userSvc = Locator.GetUserService();
            return Json(userSvc.GetUser(Id));
        }
        
        // Checks to see if a user is active
        // GET: api/User/GetActive
        [System.Web.Mvc.Route("GetActive")]
        public JsonResult<UserModel> GetActive(string Username)
        {
            var db = new UserDbContext();
            var result = db.StoredUser.Select(x => new UserModel
            {
                IsActive = true
            }).SingleOrDefault();
            return Json(result);
        }
        
        // POST: api/User
        public void Post([FromBody]UserModel value)
        {
            Locator.GetUserService().AddUser(value);
        }
        
        // PUT: api/Users/13
        public void Put([FromBody]UserModel value)
        {
            Locator.GetUserService().UpdateUser(value);
        }
        
        // DELETE: api/Users/13
        public void Delete([FromBody]UserModel value)
        {
            Locator.GetUserService().RemoveUser(value);
        }
    }
}