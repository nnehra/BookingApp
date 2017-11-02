using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppoinmentBookingApplication.Models
{
    public class DoctorDetails
    {
        public int DoctorId { get; set; }

        public string Name { get; set; }

        public string Speciality { get; set; }

        public List<string> TimeSlot { get; set; }
    }
}