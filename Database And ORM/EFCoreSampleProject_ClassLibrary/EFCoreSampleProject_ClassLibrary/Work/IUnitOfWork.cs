namespace EFCoreSampleProject_ClassLibrary.Interfaces.Work
{
    public interface IUnitOfWork
    {
        IStudentRepository Students { get; set; }
        void SaveChanges();
    }
}
