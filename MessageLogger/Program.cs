using System;
using System.Collections.Generic;
using MessageLogger;


var Messages = new List<Message>();

Console.Write("Add a message (or 'quit' to exit): ");
var userInput = Console.ReadLine();
Message message = new Message(userInput);

if (userInput != "quit")
{
    Messages.Add(message);
    Console.WriteLine(message.CreatedAt.ToString("h:mm tt") + ": " + message.Content);
}

while (userInput != "quit")
{
    Console.Write("Add message: ");
   
    userInput = Console.ReadLine();
   
    Message nextMessage = new Message(userInput);
   
    if (userInput != "quit")
    { 
        Messages.Add(nextMessage);
    }
   
    foreach (var userMessage in Messages)
    {

        Console.WriteLine(userMessage.CreatedAt.ToString("h:mm tt") + ": " + userMessage.Content);
    }
}


Console.WriteLine("Thanks for using Message Logger! During this session, you logged " + Messages.Count + " messages");


