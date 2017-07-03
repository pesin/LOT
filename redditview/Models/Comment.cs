using System;

namespace redditview.Models
{
    public class Comment
    {
        public DateTimeOffset Date { get; set; }
        public string Text {get;set;}
        public long Score { get; set; }
    }
}