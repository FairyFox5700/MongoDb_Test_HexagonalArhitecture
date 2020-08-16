namespace MongoDb.Data.Mongo.Models
{
    public class CityMongoDbModel:MongoDbBaseModel
    {
        public string Name { get; set; }
        public  string PostalCode { get; set; }
    }
}