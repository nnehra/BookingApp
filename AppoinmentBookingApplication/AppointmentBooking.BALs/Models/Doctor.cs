using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppointmentBooking.BAL.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }

        public string Name { get; set; }

        public string Specialization { get; set; }

        public List<TimeSlots> TimeSlot { get; set; }
    }
}