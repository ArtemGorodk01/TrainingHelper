using Microsoft.AspNetCore.Mvc;
using TrainingHelper.Db;
using TrainingHelper.Db.Models;

namespace TrainingHelper.WebApi.Controllers
{
    [Route("/Test")]
    public class TestController : Controller
    {
        private TrainingHelperDbContext _context;

        public TestController(TrainingHelperDbContext dbContext)
        {
            _context = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        [HttpGet("/Index")]
        public async Task<ActionResult<string>> Index()
        {
            _context.TrainingPlans.Add(new TrainingPlan
            {
                Id = Guid.NewGuid(),
                Description = "",
                Name = "",
            });
            await _context.SaveChangesAsync();

            return "Hello";
        }
    }
}
