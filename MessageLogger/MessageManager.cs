using System;
using System.Collections.Generic;

namespace MessageLogger
{
    public class MessageManager
    {
        public List<User> Users;

        public MessageManager()
        {
            Users = new List<User>();
        }

        public List<Message> AllMessages()
        {
            List<Message> allMessages = new List<Message>();

            foreach (User user in Users)
            {
                allMessages.AddRange(user.UserMessages);
            }

            return allMessages;
        }

        public List<Message> RecentMessages(int i)
        {
            List<Message> allMessages = AllMessages();

            if (i >= allMessages.Count)
            {
                return allMessages;
            }

            return allMessages.GetRange(allMessages.Count - i, i);
        }
    }
}
