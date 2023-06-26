
namespace TestNinja.Mocking.ActionsOnEmploeeController
{
    public interface IEmployeeStorage
    {
        void DeleteEmploee(int id);
    }

    public class EmployeeStorage : IEmployeeStorage
    {
        private readonly EmployeeContext _db;

        public EmployeeStorage()
        {
            _db = new EmployeeContext();
        }

        public void DeleteEmploee(int id)
        {
            var employee = _db.Employees.Find(id);
            _db.Employees.Remove(employee);
            _db.SaveChanges();
        }
    }
}
