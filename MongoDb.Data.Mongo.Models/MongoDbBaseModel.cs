using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDb.Data.Mongo.Models
{
    public abstract class MongoDbBaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public virtual void SetMissedIdentifiers()
        {
            if (string.IsNullOrEmpty(Id))
            {
                Id = ObjectId.GenerateNewId().ToString();
            }
        }
    }
}