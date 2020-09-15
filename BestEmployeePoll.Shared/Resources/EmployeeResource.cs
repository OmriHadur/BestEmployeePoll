using RestApi.Shared.Resources;
using System.Collections.Generic;

namespace BestEmployeePoll.Shared.Resources
{
    public class EmployeeResource : Resource
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Manager { get; set; }
        public string[] Staff { get; set; }
        public bool IsManager { get; set; }
    }
}