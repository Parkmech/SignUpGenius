using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IS413_GroupProject.Models;

namespace IS413_GroupProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private iTourRepository _repository;

        public HomeController(ILogger<HomeController> logger, iTourRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.Tours);
        }

        public IActionResult SignUp()
        {
            return View();
        }
        //public IActionResult SignUp(int pageNum)

        //{
        //    return View(new TimeSlotListViewModel.Where()
        //    {
        //        TimeSlot = _repository.TimeSlot.Where(p => date == null || p.date == Date)
                    //.OrderBy(p => p.Time)
                    //.Skip((pageNum - 1) * ItemsPerPage)
                    //.Take(ItemsPerPage),

                    //PagingInfo = new PagingInfoClass
                    //{
                    //  CurrentPage = pageNum,
                    //  ItemsPerPage = ItemsPerPage,
                    //  TotalNumItems = date == null ? _repository.TimeSlot.Count() : _respository.TimeSlot.Where(x => x.Date == date).Count()
        //    }) ;
        //}

        public IActionResult ScheduleInput()
        {
            return View();
        }

        public IActionResult ViewAppointments()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}


