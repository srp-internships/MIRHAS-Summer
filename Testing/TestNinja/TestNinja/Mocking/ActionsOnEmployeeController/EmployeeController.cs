using System.Data.Entity;
using TestNinja.Mocking.ActionsOnEmploeeController;

namespace TestNinja.Mocking
{
    public class EmployeeController
    {
        private IEmployeeStorage eStorage;

        public EmployeeController(IEmployeeStorage eStorage)
        {
            this.eStorage = eStorage;
        }

        public ActionResult DeleteEmployee(int id)
        {
            eStorage.DeleteEmploee(id);
            return RedirectToAction("Employees");
        }

        private ActionResult RedirectToAction(string employees)
        {
            return new RedirectResult();
        }
    }

    public class ActionResult { }

    public class RedirectResult : ActionResult { }

    public class EmployeeContext
    {
        public DbSet<Employee> Employees { get; set; }

        public void SaveChanges()
        {
        }
    }

    public class Employee
    {
    }
}