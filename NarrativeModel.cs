using System;
using System.Collections.Generic;

abstract class Account
{
    public string Handle { get; set; }
    public string Email { get; set; }
    private string password; 
    public string Name { get; set; }
    public string ProfilePicture { get; set; }

    public Account(string handle, string email, string name, string profilePicture, string password)
    {
        Handle = handle;
        Email = email;
        Name = name;
        ProfilePicture = profilePicture;
        this.password = password;
    }

    public abstract void Create(); 

    public void Edit() {  }
    public void Delete() {  }
    
    public bool Login(string inputPassword)
    {
        return inputPassword == password;
    }
}


class UserAccount : Account
{
    public UserAccount(string handle, string email, string name, string profilePicture, string password)
        : base(handle, email, name, profilePicture, password) { }

    public override void Create()
    {
        Console.WriteLine($"Account {Handle} has been created.");
    }
}

class Tweet
{
    public string? Text { get; set; }
    public string? Media { get; set; }
    public Account? Author { get; set; }
    public DateTime PublishDateTime { get; set; }

    public void Publish()
    {
        Console.WriteLine($"{Author.Handle} tweeted: {Text}");
    }
}

class List
{
    public string? Name { get; set; }
    public List<Account> Accounts { get; set; } = new List<Account>();

    public void Create() { }
    public void AddAccount(Account account) { Accounts.Add(account); }
}

