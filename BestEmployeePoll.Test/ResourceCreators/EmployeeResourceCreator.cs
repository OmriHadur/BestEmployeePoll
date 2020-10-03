using Core.Server.Tests.ResourceCreators;
using BestEmployeePoll.Shared.Resources;

namespace BestEmployeePoll.Test.ResourceCreators
{
    public class EmployeeResourceCreator : 
        RestResourceCreator<EmployeeCreateResource,EmployeeUpdateResource, EmployeeResource>
    {
        public override void SetCreateResource(EmployeeCreateResource createResource)
        {
            base.SetCreateResource(createResource);
            createResource.Manager = null;
        }
    }
}
