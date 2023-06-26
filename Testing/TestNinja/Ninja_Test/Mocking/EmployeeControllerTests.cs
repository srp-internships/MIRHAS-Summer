using Moq;
using NUnit.Framework;
using System;
using TestNinja.Mocking;
using TestNinja.Mocking.ActionsOnEmploeeController;

namespace Ninja_Test.Mocking
{
    [TestFixture]
    class EmployeeControllerTests
    {

        [Test]
        private void EmploeeDeleteTest_Id_RemoveEmploeeWithTheSameId()
        {
            var employeeStorage = new Mock<IEmployeeStorage>();
            var controller = new EmployeeController(employeeStorage.Object);
            controller.DeleteEmployee(1);
            employeeStorage.Verify(a => a.DeleteEmploee(1));
        }
    }
}
