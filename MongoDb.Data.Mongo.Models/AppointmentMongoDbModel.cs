using System;

namespace MongoDb.Data.Mongo.Models
{
    public class AppointmentMongoDbModel:MongoDbBaseModel
    {
        public DateTime StartDateTime { get; set; }
        public string Detail { get; set; }
        public bool Status { get; set; }
        public int PatientId { get; set; }
        public PatientMongoDbModel Patient { get; set; }
        public int DoctorId { get; set; }
        public DoctorMongoDbModel Doctor { get; set; }
        public override void SetMissedIdentifiers()
        {
            Patient.SetMissedIdentifiers();
            Doctor.SetMissedIdentifiers();
            base.SetMissedIdentifiers();
        }
    }
}