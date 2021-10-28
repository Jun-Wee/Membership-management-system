using System;
using System.Collections.Generic;

namespace PassTask13
{
    /// <summary>
    /// This is Monthlyevents class that help to create MonthlyEvents object
    /// </summary>
    public class MonthlyEvents
    {
        private string _title;
        private string _content;
        private List<Comment> _comments;

        /// <summary>
        /// This is pass by value constructor that help to initialize MonthlyEvents object
        /// </summary>
        public MonthlyEvents(string title, string content){
            _title = title;
            _content = content;
            _comments = new List<Comment>();
        }

        /// <summary>
        /// function that will add comment object into _comments list
        /// </summary>
        public void AddComment(Comment c){
            _comments.Add(c);
        }

        /// <summary>
        /// function that will remove comment object from _comments list
        /// </summary>
        public void RemoveComment(Comment c){
            _comments.Remove(c);
        }

        /// <summary>
        /// function that will display the commmet object's content in _comments list
        /// </summary>
        public void DisplayComment(){
            Console.WriteLine("=====================" + "\nBelow is all the comment on the events: "+ "\n=====================");
            foreach (Comment c in _comments)
            {
                c.OutputComment();
            }
        }

        /// <summary>
        /// function that will output MonthlyEvents object content
        /// </summary>
        public void OutputEvents(){
            Console.WriteLine("\nTitle: "+ _title);
            Console.WriteLine("Content: "+ _content);
        }

        /// <summary>
        /// return _content string
        /// </summary>
        public string Content{
            get{return _content;}
        }

        /// <summary>
        /// return _comments list
        /// </summary>
        public List<Comment> Comments{
            get{return _comments;}
        }

        /// <summary>
        /// return _title string
        /// </summary>
        public string Title{
            get{return _title;}
        }

    }
}