using System;
using System.Collections.Generic;


namespace MessageLogger
{
    public class Message
    {
        public string Content;
        public DateTime CreatedAt;

        public Message(string content)
        {
            Content = content;

            CreatedAt = DateTime.Now;
        }

       
    }
}
