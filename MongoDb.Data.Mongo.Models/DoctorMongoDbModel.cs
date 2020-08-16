using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MongoDb.Data.Mongo.Models
{
    public class DoctorMongoDbModel:MongoDbBaseModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public bool IsAvailable { get; set; }
        public string Address { get; set; }
        public int SpecializationId { get; set; }
        public SpecializationMongoDbModel Specialization { get; set; }
        public List<AppointmentMongoDbModel> Appointments { get; set; } = new List<AppointmentMongoDbModel>();
        public override void SetMissedIdentifiers()
        {
            Specialization.SetMissedIdentifiers();
            Appointments.ForEach(x => x.SetMissedIdentifiers());
            base.SetMissedIdentifiers();
        }
    }
}