using System;
using System.Collections.Generic;

namespace PassTask13
{
    public class Comment
    {
        private string _title;
        private string _content;
        private string _date;

        public Comment(string title, string content, string date){
            _title = title;
            _content = content;
            _date = date;
        }
    }
}