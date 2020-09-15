using RestApi.Tests.ResourceCreators;
using BestEmployeePoll.Shared.Resources;

namespace BestEmployeePoll.Test.ResourceCreators
{
    public class EmployeeResourceCreator : RestResourceCreator<EmployeeCreateResource, EmployeeResource>
    {
        public override void SetCreateResource(EmployeeCreateResource createResource)
        {
            base.SetCreateResource(createResource);
            createResource.Manager = null;
        }
    }
}
