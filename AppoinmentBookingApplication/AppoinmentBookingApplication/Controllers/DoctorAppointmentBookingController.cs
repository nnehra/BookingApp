using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppointmentBooking.BAL.DoctorService;

namespace AppoinmentBookingApplication.Controllers
{
    public class DoctorAppointmentBookingController : ApiController
    {
        private readonly IDoctorDetails _doctorDetails;

        public DoctorAppointmentBookingController(IDoctorDetails doctorDetails)
        {
            this._doctorDetails = doctorDetails;
        }

        public HttpResponseMessage Get()
        {
            var doctor = this._doctorDetails.GetDoctorDetails();
            return Request.CreateResponse(HttpStatusCode.OK, doctor);
        }

        public HttpResponseMessage Get(int id)
        {
            var doctor = this._doctorDetails.GetDoctorDetailsById(id);
            return Request.CreateResponse(HttpStatusCode.OK, doctor);
        }
    }
}
