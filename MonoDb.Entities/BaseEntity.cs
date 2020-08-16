using System.Reflection;

namespace MonoDb.Models
{
    public  abstract class BaseEntity<TKey>
    {
        public  TKey Id { get; set; }
    }  
}