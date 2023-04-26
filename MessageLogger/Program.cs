using System;
using System.Collections.Generic;
using MessageLogger;

var Users = new Dictionary<string, User>();

User user1 = new User("user", "name");

Console.Write("What is your name? ");
user1.Name = Console.ReadLine();

Console.Write("What is your username? (one word, no spaces!) ");
user1.Username = Console.ReadLine();

Users.Add(user1.Username, user1);

Console.WriteLine("To log out of your user profile, enter 'log out'. To quit the application, enter 'quit')");

Console.Write("Add a message: ");
var userInput = Console.ReadLine();

while (userInput != "quit")
{
    if (userInput != "log out")
    {
        // Add message to current user
        Message message = new Message(userInput);
        user1.AddMessagetoList(message);
        //Console.WriteLine(message.CreatedAt.ToString("h:mm tt") + ": " + message.Content);
        foreach (var userMessage in user1.UserMessages)
        {
            Console.WriteLine(userMessage.CreatedAt.ToString("h:mm tt") + ": " + userMessage.Content);
        }

    }
    else
    {
        // Log out and log in as a new or existing user
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

        // Display all messages of the current user
        //Console.WriteLine("Messages for " + user1.Name + " (" + user1.Username + "):");
        //foreach (var userMessage in user1.UserMessages)
        //{
        //    Console.WriteLine(userMessage.CreatedAt.ToString("h:mm tt") + ": " + userMessage.Content);
        //}
    }

    Console.Write("Add a message: ");
    userInput = Console.ReadLine();
}
foreach (var user in Users.Values)
{
    Console.WriteLine(user.Name + " wrote " + user.UserMessages.Count + " messages");
}

//Console.WriteLine("Thanks for using Message Logger!" + user1.UserMessages.Count + " messages");
