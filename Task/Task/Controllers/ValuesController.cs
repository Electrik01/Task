using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.EF;
using Task.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        UsersContext db;
        public ValuesController(UsersContext context)
        {
            db = context;
        }
        [HttpGet]
        [Authorize]
        public IEnumerable<User> Get()
        {
            
            return db.Users.ToList();
        }
     

        [HttpGet("{id}")]
        public User Get(int id)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == id);
         
            return user;
        }

        [HttpPost]
        public ActionResult Post(User user)
        {
            if (db.Users.ToList().Find(u => u.Login == user.Login) != null)
                ModelState.AddModelError("Login", "Пользователь с таким логином уже существует.");
            if (ModelState.IsValid)
            {

                db.Users.Add(user);
                db.SaveChanges();
                return Ok();
            }
            return BadRequest(ModelState);
        }


    }
}
