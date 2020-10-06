using Core.Server.Shared.Resources;
using System.Collections.Generic;

namespace BestEmployeePoll.Shared.Resources
{
    public class EmployeeResource : Resource
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int Age { get; set; }
        public string ManagerId { get; set; }
        public string[] Staff { get; set; }
        public bool IsManager { get; set; }
    }
}