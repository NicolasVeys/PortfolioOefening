using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Portfolio.Database;
using Portfolio.Domain;
using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;


namespace Portfolio.Controllers
{
    public class ProjectController : Controller
    {
        private readonly PortfolioContext _projectDatabase;
        public ProjectController(PortfolioContext projectDatabase)
        {
            _projectDatabase = projectDatabase;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ProjectCreateViewModel NewProject = new ProjectCreateViewModel();

            IEnumerable<Status> paymentStatusus = await _projectDatabase.statuses.ToListAsync();
            foreach (var Status in paymentStatusus)
            {
                NewProject.Statuses.Add(new SelectListItem() { Text = Status.Title, Value = Status.Id.ToString() });
            }
            IEnumerable<Tag> expenseProducts = await _projectDatabase.Tags.ToListAsync();
            foreach (var Tag in expenseProducts)
            {
                NewProject.Tags.Add(new SelectListItem() { Text = Tag.Title, Value = Tag.Id.ToString() });
            }

            return View(NewProject);
        }
    }
}
