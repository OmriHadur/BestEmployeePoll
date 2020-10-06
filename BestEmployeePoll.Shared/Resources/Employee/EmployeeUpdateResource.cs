using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Core.Server.Shared.Resources;

namespace BestEmployeePoll.Shared.Resources
{
    public class EmployeeUpdateResource : UpdateResource
    {
        [EmailAddress]
        public string Email { get; set; }

        [MinLength(3)]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [MinLength(3)]
        [MaxLength(25)]
        public string LastName { get; set; }

        public int Age { get; set; }

        public string ManagerId { get; set; }
    }
}