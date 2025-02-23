using ForumApp.Data;
using ForumApp.Data.Models;
using ForumApp.Models.Post;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ForumApp.Controllers
{
    public class PostController : Controller
    {
        private readonly ForumAppDbContext _data;
        public PostController(ForumAppDbContext data)
        {
            _data=data;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> All()
        {
            var posts = await _data
                .Posts
                .Select(p => new PostViewModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Content = p.Content
                })
                .ToListAsync();
              
            return View(posts);
        }
        
        public async Task<IActionResult> Add()
            => View();
        [HttpPost]
        public async Task<IActionResult> Add(PostViewModel model)
        {
            var post = new Post()
            {
                Title = model.Title,
                Content = model.Content
            };

             _data.Posts.Add(post);
            await _data.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }
        public async Task<IActionResult> Edit(int id)
        {
            var post = await _data.Posts.FindAsync(id);

            if (post != null)
            {
                return View(new PostFormModel()
                {
                    Content = post.Content,
                    Title = post.Title
                });
            }
            return StatusCode(401);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, PostFormModel model)
        {
            var post = await _data.Posts.FindAsync(id);

            post.Title = model.Title;
            post.Content = model.Content;

            await _data.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var post = await _data.Posts.FindAsync(id);

            _data.Posts.Remove(post);
            await _data.SaveChangesAsync();

            return RedirectToAction(nameof(All));
        }
    }
}
