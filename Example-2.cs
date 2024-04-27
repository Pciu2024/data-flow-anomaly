using System;
using System.Collections.Generic;

public class AuthenticationSystem
{
    private Dictionary<string, string> userCredentials; // Stores username-password pairs

    public AuthenticationSystem()
    {
        userCredentials = new Dictionary<string, string>();
        // Adding some sample user credentials
        userCredentials.Add("user1", "password1");
        userCredentials.Add("user2", "password2");
    }

    public bool AuthenticateUser(string username, string password)
    {
        if (userCredentials.ContainsKey(username))
        {
            // Incorrect validation check - password check is missing
            Console.WriteLine($"User {username} exists in the system.");
            return true;
        }
        else
        {
            Console.WriteLine($"User {username} does not exist in the system.");
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        AuthenticationSystem authSystem = new AuthenticationSystem();

        Console.WriteLine("Attempting to authenticate user1...");
        authSystem.AuthenticateUser("user1", "password1");

        Console.WriteLine("\nAttempting to authenticate user3...");
        authSystem.AuthenticateUser("user3", "password3");
    }
}
