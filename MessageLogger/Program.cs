using System;
using System.Collections.Generic;
using MessageLogger;

var Users = new Dictionary<string, User>();


// create a new user and prompt for their name and username
User user1 = new User("user", "name");

Console.Write("What is your name? ");
user1.Name = Console.ReadLine();

Console.Write("What is your username? (one word, no spaces!) ");
user1.Username = Console.ReadLine();

// add the user to the dictionary of users
Users.Add(user1.Username, user1);

//add first message
Console.WriteLine("To log out of your user profile, enter 'log out'. To quit the application, enter 'quit')");

Console.Write("Add a message: ");
var userInput = Console.ReadLine();

// loop until the user enters "quit"
while (userInput != "quit")
{

    if (userInput != "log out")
    {
        
        Message message = new Message(userInput);
        user1.AddMessagetoList(message);
        
        foreach (var userMessage in user1.UserMessages)
        {
            Console.WriteLine(userMessage.CreatedAt.ToString("h:mm tt") + ": " + userMessage.Content);
        }

    }
    else
    {
        
        Console.Write("Would you like to log in a 'new' or 'existing' user?");
        userInput = Console.ReadLine();

        if (userInput == "new")
        {
            User userNew = new User("user", "name");

            Console.Write("What is your name? ");
            userNew.Name = Console.ReadLine();

            Console.Write("What is your username? (one word, no spaces!) ");
            userNew.Username = Console.ReadLine();

            Users.Add(userNew.Username, userNew);
            user1 = userNew;
        }
        else if (userInput == "existing")
        {
            Console.Write("Enter your username: ");
            userInput = Console.ReadLine();

            if (Users.ContainsKey(userInput))
            {
                user1 = Users[userInput];
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }

    }

    Console.Write("Add a message: ");
    userInput = Console.ReadLine();
}
foreach (var user in Users.Values)
{
    Console.WriteLine(user.Name + " wrote " + user.UserMessages.Count + " messages");
}

