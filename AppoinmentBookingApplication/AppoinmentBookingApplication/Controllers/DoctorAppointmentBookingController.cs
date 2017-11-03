using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppointmentBooking.BAL.DoctorService;
using AppointmentBooking.BAL.Models;

namespace AppoinmentBookingApplication.Controllers
{
    public class DoctorAppointmentBookingController : ApiController
    {
        private readonly IDoctorDetails _doctorDetails;

        public DoctorAppointmentBookingController(IDoctorDetails doctorDetails)
        {
            this._doctorDetails = doctorDetails;
        }

        public HttpResponseMessage GetDoctorDetails()
        {
            IEnumerable<Doctor> doctorList = this._doctorDetails.GetDoctorDetails();
            return Request.CreateResponse(HttpStatusCode.OK, doctorList);
        }

        [Route("DoctorDetails")]
        public HttpResponseMessage GetDoctorDetails(int id)
        {
            Doctor doc = this._doctorDetails.GetDoctorDetailsById(id);
            return Request.CreateResponse(HttpStatusCode.OK, doc);
        }

        [Route("AvailableTimeSlots")]
        public HttpResponseMessage GetAvailableTimeSlots(int id)
        {
            IEnumerable<TimeSlots> time = this._doctorDetails.GetAvailableTimeSlots(id);
            return Request.CreateResponse(HttpStatusCode.OK, time);
        }
    }
}
