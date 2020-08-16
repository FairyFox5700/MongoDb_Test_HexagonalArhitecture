using System;
using System.Collections.Generic;

namespace MongoDb.Data.Mongo.Models
{
    public class PatientMongoDbModel:MongoDbBaseModel
    {
        public string Token { get; set; }
        public string Name { get; set; }
        public Gender Gender{ get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public byte CityId { get; set; }
        public CityMongoDbModel City { get; set; }
        public DateTime DateTime { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }

        public int Age
        {
            get
            {
                var now = DateTime.Today;
                var age = now.Year - BirthDate.Year;
                if (BirthDate > now.AddYears(-age)) age--;
                return age;
            }

        }
        public List<AppointmentMongoDbModel> Appointments { get; set; } = new List<AppointmentMongoDbModel>();
        public List<AttendanceMongoDbModel> Attendances { get; set; } = new List<AttendanceMongoDbModel>();


        public override void SetMissedIdentifiers()
        {
            City.SetMissedIdentifiers();
            base.SetMissedIdentifiers();
        }
    }
}