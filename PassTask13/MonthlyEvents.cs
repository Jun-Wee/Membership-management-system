using System;
using System.Collections.Generic;

namespace PassTask13
{
    public class MonthlyEvents
    {
        private string _title;
        private string _content;
        private List<Comment> _comments;

        public MonthlyEvents(string title, string content){
            _title = title;
            _content = content;
        }

        public string Content{
            get{return _content;}
        }

        public List<Comment> Comments{
            get{return _comments;}
        }

        public void AddComment(Comment c){
            _comments.Add(c);
        }
        public void RemoveComment(Comment c){
            _comments.Remove(c);
        }
    }
}