using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Purple_Buzz.DAL;
using Purple_Buzz.ViewModel;

namespace Purple_Buzz.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public WorkController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;   
        }
        public async Task<IActionResult>  Index()
        {
            WorkVM workVM = new WorkVM()
            {
                WorkCategories=await _appDbContext.WorkCategories.Where(c => !c.IsDeleted).ToListAsync(),
                WorkServices=await _appDbContext.WorkServices
                .Include(w=>w.WorkCategory)
                .Include(w=>w.WorkServiceImages)
                .OrderByDescending(w => w.Id)
                .Where(w => !w.IsDeleted)
                .Take(8)
                .ToListAsync(),
            };
            return View(workVM);
        }
    }
}
