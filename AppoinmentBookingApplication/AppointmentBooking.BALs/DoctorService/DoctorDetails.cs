using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AppointmentBooking.BAL.Models;
using Newtonsoft.Json;

namespace AppointmentBooking.BAL.DoctorService
{
    public class DoctorDetails : IDoctorDetails
    {

        public IEnumerable<Doctor> GetDoctorDetails()
        {
            IEnumerable<Doctor> docList;
            using (StreamReader sr = new StreamReader(@"C://Users/Neha_Nehra/Documents/visual studio 2015/Projects/AppoinmentBookingApplication/AppointmentBooking.BALs/Content/Data.json"))
            {
                docList = JsonConvert.DeserializeObject<IEnumerable<Doctor>>(sr.ReadToEnd());
            }
            return docList;
        }

        public Doctor GetDoctorDetailsById(int doctorId)
        {
            if (doctorId <= 0)
            {
                throw new ArgumentNullException();
            }
            IEnumerable<Doctor> docList;
            using (StreamReader sr = new StreamReader(@"C://Users/Neha_Nehra/Documents/visual studio 2015/Projects/AppoinmentBookingApplication/AppointmentBooking.BALs/Content/Data.json"))
            {
                docList = JsonConvert.DeserializeObject<IEnumerable<Doctor>>(sr.ReadToEnd());
            }
            Doctor doc= docList.Where(x => x.DoctorId == doctorId).FirstOrDefault();
            return doc;
        }
        public IEnumerable<TimeSlots> GetAvailableTimeSlots(int doctorId)
        {
            if (doctorId <= 0)
            {
                throw new ArgumentNullException();
            }
            IEnumerable<TimeSlots> timeSlots;
            using (StreamReader sr = new StreamReader(@"C://Users/Neha_Nehra/Documents/visual studio 2015/Projects/AppoinmentBookingApplication/AppointmentBooking.BALs/Content/Data.json"))
            {
                timeSlots = JsonConvert.DeserializeObject<IEnumerable<Doctor>>(sr.ReadToEnd()).Where(x => x.DoctorId == doctorId).FirstOrDefault().TimeSlot;
            }
            return timeSlots;
        }
    }
}
