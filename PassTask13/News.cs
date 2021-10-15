using System;
using System.Collections.Generic;

namespace PassTask13
{
    public enum NewsType
    {
        General,
        Specific
    }

    public enum Month
    {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December   
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

        public NewsType Type{
            get{return _newstype;}
        }

        public void OutputContent(){
            Console.WriteLine("Month: " + _month);
            Console.WriteLine("Title: " + _title);
            Console.WriteLine("News Type: " + _newstype);
            Console.WriteLine("Content: " + _content);
        }
    }   
}