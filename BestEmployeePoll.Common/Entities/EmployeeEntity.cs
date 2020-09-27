using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Server.Common.Entities;

namespace BestEmployeePoll.Common.Entities
{
    public class EmployeeEntity : Entity
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

        public int Age { get; set; }

        public string Manager { get; set; }

        public List<string> Staff { get; set; }
    }
}
