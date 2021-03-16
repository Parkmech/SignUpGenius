using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using IS413_GroupProject.Infrastructure;
using IS413_GroupProject.Models;

namespace IS413_GroupProject.Pages.Home
{
    public class AppointmentModel : PageModel
    {

        private iTourRepository repository;

        // Constructor

        public AppointmentModel (iTourRepository repo, Appointments appointmentsService)
        {
            repository = repo;
            Appointment = appointmentsService;
        }

        // Properties

        public Appointments Appointment { get; set; }

        public string ReturnUrl { get; set; }



        public void OnGet(string returnUrl)
        {
            ReturnUrl = ReturnUrl ?? "/";
        }

        public IActionResult OnPost(long Id, string returnUrl)
        {
            Tour tour = repository.Tours.FirstOrDefault(t => t.TourId == Id);

            Appointment.AddItem(tour);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(long Id, string returnUrl)
        {
            Appointment.RemoveLine(Appointment.Lines.First(al => al.Tour.TourId == Id).Tour);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
