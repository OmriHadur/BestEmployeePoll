using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;
using RestApi.Common.Entities;

namespace BestEmployeePoll.Common.Entities
{
    public class PersonEntity : Entity
    {
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25)]
        public string LastName { get; set; }

        [BsonId]
        public string Manager { get; set; }

        public string[] Employees { get; set; }
    }
}
