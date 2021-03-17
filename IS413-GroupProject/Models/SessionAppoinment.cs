using System;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using IS413_GroupProject.Infrastructure;

namespace IS413_GroupProject.Models
{
    public class SessionAppoinment : Appointments
    {
         
        // This model is used to maintain items that are stored in a cart during a session by
        // converting to json and storing in the session variable

        public static Appointments GetAppointment(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
                .HttpContext.Session;
            SessionAppoinment appointment = session?.GetJson<SessionAppoinment>("Appointment")
                ?? new SessionAppoinment();
            appointment.Session = session;
            return appointment;
        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Tour tour)
        {
            base.AddItem(tour);
            Session.SetJson("Appointment", this);
        }

        public override void RemoveLine(Tour tour)
        {
            base.RemoveLine(tour);
            Session.SetJson("Appointment", this);
        }

        public override void Clear()
        {
            base.Clear();
            Session.Remove("Appointment");
        }
    }
}

