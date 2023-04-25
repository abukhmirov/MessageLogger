using System;
using System.Collections.Generic;


namespace MessageLogger
{
    public class User
    {
       public string Name;
       public string Username;
        public List<Message> UserMessages;

        public User(string name, string username)
        {
            Name = name;
            Username = username;
            UserMessages = new List<Message>();
        }

        public void AddMessagetoList(Message message)
        {
            
            UserMessages.Add(message);
        }
    }
}
