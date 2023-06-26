using NUnit.Framework;
using TestNinja.Fundamentals;

namespace Ninja_Test
{
    [TestFixture]
    class CustomerController_Test
    {
        [Test]
        public void GetCustomerTest_IdZero_ReturnNotFound()
        {
            CustomerController controller= new CustomerController();
            var result = controller.GetCustomer(0);

            Assert.That(result, Is.TypeOf<NotFound>());
        }

        [Test]  
        public void GetCustomer_IdNonZero_ReturnOk()
        {
            CustomerController controller= new CustomerController();
            var result = controller.GetCustomer(1);

            Assert.That(result, Is.TypeOf<Ok>());
        }
    }
}
