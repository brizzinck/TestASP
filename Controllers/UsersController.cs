using SimpleBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListUsers()
        {
            List<UsersModel> users = new List<UsersModel>
            {
                new UsersModel("Maks", "Diachkov", 17, false),
                new UsersModel("Zheka", "Polichuk", 15, false),
                new UsersModel("Vlad", "Lavrishko", 67, true),
                new UsersModel("Sasha", "Babarytskaya", 54, true)
            };
            return View(users);
        }
    }
}