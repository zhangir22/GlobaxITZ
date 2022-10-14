using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GlobaxIT.Models;
using GlobaxIT.Models.Model;
using Newtonsoft.Json;

namespace GlobaxIT.Controllers
{
    public class HomeController : Controller
    {
        
        private List<User> GetUsers()
        {
            IList<UserModel> lst = null;
            using (StreamReader str = new StreamReader("~/users/users.json"))
            {
                lst = JsonConvert.DeserializeObject<IList<UserModel>>(str.ReadToEnd());
            }
            List<User> users = new List<User>();
            foreach(var item in lst)
            {
                users.Add(new User
                {
                    name = item.name,
                    email = item.email,
                    phone = item.phone,
                    address = item.address,
                    position_name = item.position_name,
                    department = item.department,
                    hire_date = item.hire_date,
                }) ;
            }
            return users;
        }
        
        public ActionResult Index()
        {
            return View(GetUsers());
        }
    }
}
