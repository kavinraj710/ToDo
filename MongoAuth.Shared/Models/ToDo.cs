using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace MongoAuth.Shared.Models
{
    public class ToDo
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = MongoDB.Bson.ObjectId.GenerateNewId().ToString();

        [BsonElement("Title")]
        public string? Title { get; set; }
        [Required]
        [EmailAddress]
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("Status")]
        public string? Status { get; set; }
        [BsonElement("TaskAddedDate")]
        public DateTime? TaskAddedDate { get; set; } = DateTime.Now;
        
        [BsonElement("Completed")]
        public bool Completed { get; set; } = false;
        
        [BsonElement("TaskCompletedDate")]
        public DateTime? TaskCompletedDate { get; set; } = null;
        [BsonElement("Deadline ")]
        public DateTime? Deadline { get; set; } = null;

    }

}