using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IS413_GroupProject.Models;
using IS413_GroupProject.Models.ViewModels;

namespace IS413_GroupProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private iTourRepository _repository;

        public int ItemsPerPage = 12;

        private TourDbContext _context;

        public HomeController(ILogger<HomeController> logger, iTourRepository repository, TourDbContext context)
        {
            _logger = logger;
            _repository = repository;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    
        public IActionResult SignUp(int pageNum)
        {
            return View(new TourListViewModel

            {
                Tours = _repository.Tours
                .OrderBy(p => p.AppointmentDate)
                .Where(p => p.Groups == null)
                .Skip((pageNum - 1) * ItemsPerPage)
                .Take(ItemsPerPage),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = ItemsPerPage,
                    TotalNumItems = _repository.Tours.Where(p => p.Groups == null).Count()
                }
            });
        }
        [HttpPost]
        public IActionResult ScheduleInput()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ViewAppointments(int pageNum)
        {
            return View(new TourListViewModel

                Tours = _repository.Tours
                .OrderBy(p => p.AppointmentDate)
                .Where(p => p.Groups != null)
                .Skip((pageNum - 1) * ItemsPerPage)
                .Take(ItemsPerPage),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = ItemsPerPage,
                    TotalNumItems = _repository.Tours.Where(p => p.Groups != null).Count()
                }
            });
        }

        [HttpPost]
        public IActionResult AddGroups(Group group)
        {
            //Here is where we need to create the object with teh model
            if (ModelState.IsValid)
            {
                _context.Group.Add(group);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("SignUp");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


