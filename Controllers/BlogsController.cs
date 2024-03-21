
using Forms.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forms.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly Business_Layer.BlogsAndRegisterBLL _BLL;

        public BlogsController(Business_Layer.BlogsAndRegisterBLL  _Bll)
        {
            _BLL = _Bll;
        }

        [HttpPost]
        //[Route("poastBlogs")]

        public async Task<ActionResult<Blogs>> CreateBlogs(Blogs blogs)
        {
            return await _BLL.CreateBlogs(blogs);
        }

        [HttpGet]
        //[Route("getBlogs")]

        public async Task<IEnumerable<Blogs>> getBlogs()
        {
            var blogs = await _BLL.getBlogs();
            return blogs;


        }


        [HttpGet("{id}")]
        //[Route("getBlogsById")]

        public async Task<ActionResult<IEnumerable<Blogs>>> getBlogsById(int id)
        {
            var blogs = await _BLL.getBlogsById(id);
            return Ok(blogs);

        }

        [HttpDelete("{id}")]
        //[Route("deleteBlogsById")]

        public async Task<ActionResult<Blogs>> DeleteBlogs(int Id)
        {
            var blogs = await _BLL.DeleteBlogs(Id);
            return Ok(blogs);
        }
    }
}
