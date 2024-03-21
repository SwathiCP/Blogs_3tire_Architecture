//using Forms.Data;
//using Forms.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace Forms.Repository
//{
//    public class Repository: IRepository
//    {
//        private readonly UserDbContext _userDbContext;

//        public Repository(UserDbContext dbContext)
//        {
//            _userDbContext = dbContext;

//        }


//        //Blogs



//        public async Task<IEnumerable<Blogs>>getBlogs()
//        {
//            var blogs = await _userDbContext.Blogs.ToListAsync();
//            return blogs;


//        }

        

//        public async Task<IEnumerable<Blogs>> getBlogsById(int id)
//        {
//            var blogs = await _userDbContext.Blogs.FindAsync(id);
//            return (IEnumerable<Blogs>)blogs;

//        }

      
//        public async Task<ActionResult<Blogs>> DeleteBlogs(int Id)
//        {
//            var blogs = await _userDbContext.Blogs.FindAsync(Id);
//            if (blogs != null)
//            {
//                _userDbContext.Blogs.Remove(blogs);
//                await _userDbContext.SaveChangesAsync();
//                return blogs;
//            }
//            else
//            {
//                // If the blog doesn't exist, return a 404 Not Found response
//                var message = "No blogs with this id";
//                return new BadRequestObjectResult(message);
//            }
//        }

//        public async Task<ActionResult<Blogs>> CreateBlogs(Blogs blogs)
//        {
//            _userDbContext.Blogs.Add(blogs);
//            await _userDbContext.SaveChangesAsync();
//            return blogs;
//        }



//        //Registrations

//        public async Task<IEnumerable<Register>> GetUsers()
//        {
//            var users = await _userDbContext.Registers.ToListAsync();
//            return users;

//        }



//        public async Task<Register> GetUsersById(int id)
//        //{
//            var users = await _userDbContext.Registers.FindAsync(id);

//            return users;
//        }



//        public async Task<ActionResult<Register>> CreateUser(Register register)
//        {
//            _userDbContext.Registers.Add(register);
//            await _userDbContext.SaveChangesAsync();
//            return register;
//        }

       

       
//    }





    

    
//}
