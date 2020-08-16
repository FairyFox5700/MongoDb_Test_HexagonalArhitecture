using System;

namespace MongoDb.Data.Mongo.Models
{
    public class AttendanceMongoDbModel:MongoDbBaseModel
    {
        public string ClinicRemarks { get; set; }
        public string Diagnosis { get; set; }
        public string SecondDiagnosis { get; set; }
        public string ThirdDiagnosis { get; set; }
        public string Therapy { get; set; }
        public DateTime Date { get; set; }
        public int PatientId { get; set; }
        public PatientMongoDbModel Patient { get; set; }
        public override void SetMissedIdentifiers()
        {
            Patient.SetMissedIdentifiers();
            base.SetMissedIdentifiers();
        }
    }
}