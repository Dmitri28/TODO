using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
 

    var Marry = new Person
    {
        Name = "Jack",
        Age = 17
    };
    var Jack = new Person
    {
        Name = "Kate",
        Age = 21
    };




    public sealed  class DBLayer : DbContext
    {
        public DbSet<Person> Persons { get; set; }
       public DBLayer()
        {
        Database.EnsureCreated();
        }
        protected override  void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=user.db");


        }
    }
    public class Person
    {
        public string Name;
        public uint Age;
    }
    
    public class ExampleModel : PageModel
    {
        public Person Person { get; private set; } = new();
    public void OnGet()
    {
        DBLayer dblayer = new DBLayer();
        dblayer.Persons.FirstOrDefault();

    }

        public void OnPost(string name, uint age)
        {
            Person = new Person()
            {
                Name = name,
                Age = age,
            };
        }
    }



