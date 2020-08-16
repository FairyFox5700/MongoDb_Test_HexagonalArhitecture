using System.ComponentModel;

namespace MongoDb.Data.Mongo.Models
{
    public enum Gender
    {
        [Description("Male")]
        Male = 1,

        [Description("Female")]
        Female
    }
}