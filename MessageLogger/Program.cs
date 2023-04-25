using System;
using System.Collections.Generic;
using MessageLogger;



var Users = new List<User>();
var Messages = new List<Message>();

User user1 = new User("user", "name");

Console.Write("What is your name? ");
user1.Name = Console.ReadLine();

Console.Write("What is your username? (one word, no spaces!) ");
user1.Username = Console.ReadLine();

Console.WriteLine("To log out of your user profile, enter 'log out'. To quit the application, enter 'quit')");
Console.Write("Add a message: ");// prog

var userInput = Console.ReadLine(); // prog

Message message = new Message(userInput); // prog




if (userInput != "quit")
{
    Messages.Add(message);
    user1.AddMessagetoList(message);
    Console.WriteLine(message.CreatedAt.ToString("h:mm tt") + ": " + message.Content);
}
else if (userInput != "log out")
{
    Console.Write("Would you like to log in");
}

while (userInput != "quit")
{
    Console.Write("Add message: ");
   
    userInput = Console.ReadLine();
   
    Message nextMessage = new Message(userInput);
   
    if (userInput != "quit")
    { 
        Messages.Add(nextMessage);
        user1.AddMessagetoList(message);
    }
   
    foreach (var userMessage in Messages)
    {

        Console.WriteLine(userMessage.CreatedAt.ToString("h:mm tt") + ": " + userMessage.Content);
    }
}


Console.WriteLine("Thanks for using Message Logger! During this session, you logged " + user1.UserMessages.Count + " messages");


