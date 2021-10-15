using System;
using System.Collections.Generic;

namespace PassTask13
{
    public enum NewsType
    {
        General,
        Specific
    }

    public class News
    {
        private string _title;
        private NewsType _newstype; 
        private string _content;
        private Month _month;

        public News(NewsType newstype, string title ,string content, Month month){
            _newstype= newstype;
            _title = title;
            _content = content;
            _month = month;
        }

        public void SpecificContent(){
            Console.WriteLine("Month: " + _month);
            Console.WriteLine("Title: " + _title);
            Console.WriteLine("News Type: " + _newstype);
            Console.WriteLine("Content: " + _content);
        }

        public void GeneralContent(){
            // can be combine to one function....
        }

    }   
}