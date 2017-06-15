using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoctorHandwriting.Models
{
    /// <summary>
    /// To handle user table
    /// </summary>
    public class UserRepo
    {
        UserContext usrContxt=new UserContext();

        public UserRepo()
        {

        }
        
        public User getUser(string Id)
        {
            return usrContxt.Users.ToList().Find(x => x.UserID == Id);        
        }

        public List<User> getUsers()
        {
            return usrContxt.Users.ToList();
        }

        public void AddUser(User user)
        {
            usrContxt.Users.Add(user);
        }



    }
}