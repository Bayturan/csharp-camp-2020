using Business.Concrete;
using Entities.Concrete;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello wo");

        Person person1 = new Person() {
            FirstName = "Ali",
            LastName = "Vea",
            NationalIdentity = 1213
        };

        PttManager pttManager = new PttManager(new ForeignerManager());
        pttManager.GiveMask(person1);
        Console.ReadLine();


    }

    static void SelamVer() {

    }

    
}