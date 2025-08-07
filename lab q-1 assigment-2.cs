using System;
class userprofile
{
     private String Username;
     private String Password;
     private  String Email;
    public void SetUsername(String name)
    {
        Username = name;
    }
    public String GetUsername()
    {
        return Username;
    }
    public void SetPassword(String password)
    {
        if (password.Length>= 6)
        {
            Password = password;
        }
        else
        {
            Console.WriteLine("password must be at least 6 character:");
        }
    }
    public String GetPassword()
    {
        return Password;
    }
    public void SetEmail(String email)
    {
        if(email.Contains("@"))
        {
            Email = email;
        }
        else
        {
            Console.WriteLine("Invalid email:");
        }
    }
    public String GetEmail()
    {
        return Email;
    }
    public void DisplayProfile()
    {
        Console.WriteLine("Username:" + Username);
        Console.WriteLine("Email:" + Email);
    }

}
class program
{
    static void Main(String[]args)
    {
        userprofile user1 = new userprofile();
        user1.SetUsername("himani");
        user1.SetPassword("muP12");
        user1.SetEmail("hiamni@gamil.com");
        user1.DisplayProfile();
        Console.WriteLine();

    }
}


       