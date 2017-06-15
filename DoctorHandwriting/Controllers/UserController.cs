using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DoctorHandwriting.Models;

namespace DoctorHandwriting.Controllers
{
    public class UserController : ApiController
    {
        private UserRepo repo;
        public UserController()
        {
            repo = new UserRepo();
        }

        // GET api/values/5
        [HttpGet]
        public User Get(string id)
        {
            return repo.getUser(id);
        }
        [HttpGet]
        public List<User> Get()
        {
            return repo.getUsers();
        }
        // POST api/values
        [HttpPost]
        public void Post(User value)
        {
            repo.AddUser(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
