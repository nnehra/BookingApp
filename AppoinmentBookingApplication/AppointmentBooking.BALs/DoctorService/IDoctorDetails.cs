using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppointmentBooking.BAL.Models;

namespace AppointmentBooking.BAL.DoctorService
{
    public interface IDoctorDetails
    {
        IEnumerable<Doctor> GetDoctorDetails();

        Doctor GetDoctorDetailsById(int doctorId);

        IEnumerable<TimeSlots> GetAvailableTimeSlots(int doctorId);
    }
}
