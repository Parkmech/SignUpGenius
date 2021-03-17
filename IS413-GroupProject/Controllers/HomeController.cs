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

        public HomeController(ILogger<HomeController> logger, iTourRepository repository)
        {
            _logger = logger;
            _repository = repository;
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
                .Skip((pageNum - 1) * ItemsPerPage)
                .Take(ItemsPerPage),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = ItemsPerPage,
                    TotalNumItems = 84
                }
            });
        }

        public IActionResult ScheduleInput()
        {
            return View();
        }

        public IActionResult ViewAppointments(int pageNum)
        {
            return View(new TourListViewModel
            {
                Tours = _repository.Tours
                .OrderBy(p => p.AppointmentDate)
                .Skip((pageNum - 1) * ItemsPerPage)
                .Take(ItemsPerPage),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = ItemsPerPage,
                    TotalNumItems = 84
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


