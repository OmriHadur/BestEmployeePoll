using Microsoft.VisualStudio.TestTools.UnitTesting;
using Core.Server.Tests.ResourceTests;
using BestEmployeePoll.Shared.Resources;
using BestEmployeePoll.Shared.Errors;

namespace BestEmployeePoll.Tests.RourcesTests
{
    [TestClass]
    public class EmployeeResourceTests : 
        ResourceTests<EmployeeCreateResource,EmployeeUpdateResource, EmployeeResource>
    {
        [TestMethod]
        public void ManagerNotFound()
        {
            var managerId = CreatedResource.Id;
            ResourcesHolder.Delete<EmployeeResource>(managerId);

            var response = ResourcesHolder.EditAndCreate<EmployeeCreateResource, EmployeeUpdateResource, EmployeeResource >(u => u.Manager = managerId);

            AssertNotFound(response);
        }

        [TestMethod]
        public void DeleteManagerFail()
        {
            var managerId = CreatedResource.Id;
            GetEmployeeWithManager(managerId);

            var managerDeleteResponse = ResourcesHolder.Delete<EmployeeResource>(managerId);

            AssertBadRequestReason(managerDeleteResponse, BadRequestReasonExtended.ManagerHasStaff);
        }

        [TestMethod]
        public void EmployeeAddedToManagerStaff()
        {
            var managerId = CreatedResource.Id;
            var employee = GetEmployeeWithManager(managerId);

            var manager = ResourcesHolder.Get<EmployeeResource>(managerId).Value;

            Assert.AreEqual(manager.Staff[0], employee.Id);
        }

        [TestMethod]
        public void EmployeeRemoveFromManagerStaff()
        {
            var managerId = CreatedResource.Id;
            var employee = GetEmployeeWithManager(managerId);
            ResourcesHolder.Delete<EmployeeResource>(employee.Id);

            var manager = ResourcesHolder.Get<EmployeeResource>(managerId).Value;

            Assert.IsTrue(manager.Staff.Length == 0);
        }

        private EmployeeResource GetEmployeeWithManager(string managerId)
        {
            return ResourcesHolder.EditAndCreate<EmployeeCreateResource,EmployeeUpdateResource, EmployeeResource>(u => u.Manager = managerId).Value;
        }
    }
}
