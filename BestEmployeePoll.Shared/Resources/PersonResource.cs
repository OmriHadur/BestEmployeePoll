using RestApi.Shared.Resources;

namespace BestEmployeePoll.Shared.Resources
{
    public class PersonResource : Resource
    {
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public PersonResource Manager { get; set; }
        public PersonResource[] Employees { get; set; }
    }
}