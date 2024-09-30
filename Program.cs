namespace Арх._ПЗ;

class Program
{
    static void Main(string[] args)
    {
        UserAccount account1 = new UserAccount("zheniok", "zhenyask@gmail.com", "ZHENYA SKUBIY", "profile1.jpg", "myPassword");
        UserAccount account2 = new UserAccount("kelvin233", "kelvin@gmail.com", "Kelvin", "profile2.jpg", "kelvinPassword");
        UserAccount account3 = new UserAccount("heily_456", "heily456@gmail.com", "Heily", "profile3.jpg", "heilyPassword");

        account1.Create();
        account2.Create();
        account3.Create();

        if (account1.Login("myPassword"))
        {
            Console.WriteLine($"{account1.Handle} succesfully logged in");
            Tweet tweet1 = new Tweet { Text = "Hi there!!!", Author = account1, PublishDateTime = DateTime.Now };
            tweet1.Publish();
        }

        if (account2.Login("kelvinPassword"))
        {
            Console.WriteLine($"{account2.Handle} succesfully logged in");
            Tweet tweet2 = new Tweet { Text = "Good day!", Author = account2, PublishDateTime = DateTime.Now };
            tweet2.Publish();
        }

        if (account3.Login("heilyPassword"))
        {
            Console.WriteLine($"{account3.Handle} succesfully logged in.");
            Tweet tweet3 = new Tweet { Text = "Hahahah", Author = account3, PublishDateTime = DateTime.Now };
            tweet3.Publish();
        }

        List myList = new List { Name = "My Friends" };
        myList.Create();
        myList.AddAccount(account1);
        myList.AddAccount(account2);
        myList.AddAccount(account3);
        
        PrintTimeStamp("");

        
        static void PrintTimeStamp(string info)
    {
        Console.WriteLine($"Author: Yevgeniya Skubiy");
        Console.WriteLine($"Time: {DateTime.Now}");
    }
    }
}
