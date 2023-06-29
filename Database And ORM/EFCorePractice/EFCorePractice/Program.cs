using EFCorePractice.Data;
using EFCorePractice.Models;
using Microsoft.EntityFrameworkCore;

public class Program
{
    static void Main(string[] args)
    {
        var context = new DataContext();
        var author = context.Authors.Single(a => a.Id == 1);

        context.Courses.Where(c => c.Author.Id == author.Id).Load();

        foreach (var item in collection)
        {

        }
    }

    void AddSomeData(DataContext context)
    {
        context.Authors.Add(new Author
        {
            Id = 1,
            Name = "Name",

        });
    }
}