using BestEmployeePoll.Shared.Resources;
using BestEmployeePoll.Standard.Client.Interfaces;
using RestApi.Client.Clients;

namespace BestEmployeePoll.Standard.Client.Clients
{
    public class PersonControllClient :
        RestClient<PersonCreateResource, PersonResource>,
        IPersonControllClient
    {
        public PersonControllClient()
            :base("api/Person")
        {
        }
    }
}
