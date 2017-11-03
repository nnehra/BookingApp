using AppointmentBooking.BAL.DoctorService;
using AppointmentBooking.BAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppoinmentBookingApplication.Controllers
{
    public class TimeSlotsController : ApiController
    {
        private readonly IDoctorDetails _doctorDetails;

        public TimeSlotsController(IDoctorDetails doctorDetails)
        {
            this._doctorDetails = doctorDetails;
        }

        [HttpGet]
        public HttpResponseMessage GetAvailableTimeSlots(int id)
        {
            IEnumerable<TimeSlots> time = this._doctorDetails.GetAvailableTimeSlots(id);
            return Request.CreateResponse(HttpStatusCode.OK, time);
        }

    }
}
