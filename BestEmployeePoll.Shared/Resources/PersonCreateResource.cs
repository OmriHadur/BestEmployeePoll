using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using RestApi.Shared.Resources;

namespace BestEmployeePoll.Shared.Resources
{
    public class PersonCreateResource : CreateResource
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string LastName { get; set; }

        public string Manager { get; set; }
    }
}