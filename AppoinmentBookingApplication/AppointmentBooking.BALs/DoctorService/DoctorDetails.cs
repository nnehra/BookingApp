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
            using (StreamReader sr = new StreamReader("~/Content/Data.json"))
            {
                docList = JsonConvert.DeserializeObject<IEnumerable<Doctor>>(sr.ReadToEnd());
            }
            return docList;
        }

        public Doctor GetDoctorDetailsById(int doctorId)
        {
            IEnumerable<Doctor> docList;
            using (StreamReader sr = new StreamReader("~/App_Data/Data.json"))
            {
                docList = JsonConvert.DeserializeObject<IEnumerable<Doctor>>(sr.ReadToEnd());
            }
            Doctor doc= docList.Where(x => x.DoctorId == doctorId).FirstOrDefault();
            return doc;
        }
        public IEnumerable<TimeSlots> GetAvailableTimeSlots(int doctorId)
        {
            throw new NotImplementedException();
        }
    }
}
