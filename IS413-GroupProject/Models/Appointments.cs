using System;
using System.Collections.Generic;
using System.Linq;
namespace IS413_GroupProject.Models
{
    public class Appointments
    {

        //Store each piece of information together

        public List<AppointmentLine> Lines { get; set; } = new List<AppointmentLine>();

        public virtual void AddItem(Tour tour)
        {
            AppointmentLine line = Lines.Where(t => t.Tour.TourId == tour.TourId).FirstOrDefault();

            // Checking if anything is currently stored in the cart

            if (line == null)
            {
                Lines.Add(new AppointmentLine
                {
                    Tour = tour,
                });
            }
        }

        // Remove a single line
        public virtual void RemoveLine(Tour tour) => Lines.RemoveAll(t => t.Tour.TourId == tour.TourId);

        //Clear entire appointment list
        public virtual void Clear() => Lines.Clear();


        public class AppointmentLine
        {
            public int AppointmentLineId { get; set; }
            public Tour Tour { get; set; }
        }
    }
}
