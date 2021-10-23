using System;
using System.Collections.Generic;

namespace PassTask13
{
    /// <summary>
    /// This is Comment class that help to create Comment object
    /// </summary>
    public class Comment
    {
        private string _title;
        private string _content;
        private string _date;

        /// <summary>
        /// This is pass value constructor that will help to create comment object 
        /// </summary>
        public Comment(string title, string content, string date){
            _title = title;
            _content = content;
            _date = date;
        }

        /// <summary>
        /// function that will output comment object content 
        /// </summary>
        public string OutputComment(){
            return ("Title: " + _title + "\nDate: " + _date + "\nContent: "+_content);
        }
    }
}