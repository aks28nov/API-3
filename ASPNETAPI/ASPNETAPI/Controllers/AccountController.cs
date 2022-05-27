using ASPNETAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ASPNETAPI.Controllers
{
    public class AccountController : ApiController
    {
        public static List<User> userList = new List<User>()
        {
            new User {name="Herry", age="43"},
            new User {name="James", age="54"}
        };
        // GET api/users
        public List<User> GetUserList()
        {

            return userList;
        }

        // GET api/values/5
        public string GetUser(int id)
        {
            return "value";
        }

        // POST api/values
        public void RegiterUser([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
