
using WebApplication1.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        

        private readonly AppDBContext _dbContext;
        // IUser InjectDep = null;

        /*
                public UserController(IUser Iu)
                {
                    this.InjectDep = Iu;
                   // _dbContext = new AppContext();
                }
        */
        public UserController(AppDBContext dbContext)
        {
            this._dbContext = dbContext;
            // _dbContext = new AppContext();
        }

        [HttpGet]
        public IEnumerable<Users> getall()
        {
            return _dbContext.users.ToList();
         /*   List<Posts> List = new List<Posts>();

            Posts a = new Posts();

            a.body = "ssdddssssss";
            a.id = 1234;
            a.title = "Hello";



            Posts b = new Posts();

            a.body = "Assdalto";
            a.id = 4444;
            a.title = "word";


            List.Add(a);

            List.Add(b);



            Users p = new Users();

            p.id = 0598178584;

            p.name = "Kayal";
            p.email = "moha@gg";

            p.phone = "09312";
            p.date = "2010";

            p.GetSetPost = List;
            //  _dbContext.users.Add(new Users() { id = 1000, name = "ali", email = "ali@gmail.com", phone = "0098", date = "2021/09/23" ,});
            _dbContext.users.Add(p);
            _dbContext.SaveChanges();
         */
            // return us;
        }


        [HttpGet("{id}")]
        public Users get(int id)
        {
            //  return _dbContext.users.SingleOrDefault(item => item.id == id);
            return _dbContext.users.SingleOrDefault(item => item.id==id);
            // return InjectDep.get(id);
            //  return us.SingleOrDefault(item => item.id == id);
        }

        [HttpPost]
        public void addUser([FromBody] Users u)
        {
            _dbContext.users.Add(u);
            _dbContext.SaveChanges();
            //InjectDep.addUser(u);
            //us.Add(u);
        }
       

        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            //   InjectDep.DeleteUser(id);
            /*  var delus = us.SingleOrDefault(item => item.id .equals (id));
              if (delus != null)
                  us.Remove(delus);

            */
            var delus = _dbContext.users.SingleOrDefault(item => item.id==id);
            if (delus != null)
            {
                _dbContext.users.Remove(delus);
                _dbContext.SaveChanges();
            }
               


        }

        /*
         * 
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id,[FromBody] Users USRRR)
        {
            var ouser = us.SingleOrDefault(x => x.id == id);
            if (ouser == null)
            {
                return NotFound("No Found");
            }
            ouser.name = USRRR.name;
            ouser.email = USRRR.email;
            ouser.phone = USRRR.phone;
            ouser.date = USRRR.date;
            //   us.Add(ouser);
            /*
               if (us.Count == 0)
               {
                   return NotFound("No List found");
               }
               return Ok(us);
            */
            //  retun Ok(us); 
            //return Ok(us);
        
        }
    
    }


  


