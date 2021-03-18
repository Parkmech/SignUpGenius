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

        public int ItemsPerPage = 10;

        private TourDbContext _context;

        private static DateTime ApptDate { get; set; }

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
    
        [HttpGet]
        public IActionResult SignUp(int pageNum)
        {
            return View(

            new TourListViewModel

            {
                Tours = _repository.Tours
                .OrderBy(p => p.AppointmentDate)
                .Where(p => p.Available == true)
                .Skip((pageNum - 1) * ItemsPerPage)
                .Take(ItemsPerPage),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = ItemsPerPage,
                    TotalNumItems = _repository.Tours.Where(p => p.Available == true).Count()
                }
            });
        }

        [HttpPost]
        public IActionResult DateCardSummary(DateTime AppointmentDate, int TourId)
        {
            ViewData["Date"] = AppointmentDate;
            ViewBag.tourId = TourId;

            return View("ScheduleInput");
        }

        [HttpPost]
        public IActionResult ScheduleInput(Group group)
        {

            //Here is where we need to create the object with the model
            if (ModelState.IsValid)
            {
                _context.Groups.Add(group);
                _context.Tours.Where(x => x.TourId == group.TourId).FirstOrDefault().Available = false;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            { 
                ViewData["Date"] = _context.Tours.Where(x => x.TourId == group.TourId).FirstOrDefault().AppointmentDate;
                ViewBag.tourId = group.TourId; 

                return View("ScheduleInput", group);
            }
        }


        [HttpGet]
        public IActionResult ViewAppointments(int pageNum)
        {
            return View(new TourListViewModel
            {
                Tours = _repository.Tours
                .OrderBy(p => p.AppointmentDate)
                .Where(p => p.Available != true)
                .Skip((pageNum - 1) * ItemsPerPage)
                .Take(ItemsPerPage),

                Groups = _repository.Groups,

                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = ItemsPerPage,
                    TotalNumItems = _repository.Tours.Where(p => p.Available != true).Count()
                }
            });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


