using System;
using System.Collections.Generic;

namespace PassTask13
{
    /// <summary>
    /// NewsType enumeration
    /// </summary>
    public enum NewsType
    {
        General,
        Specific
    }
    
    /// <summary>
    /// Month enumeration
    /// </summary>
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
        December,
        All   // means include all the month
    }
    
    /// <summary>
    /// This is News class that help to create News object
    /// </summary>
    public class News
    {
        private string _title;
        private NewsType _newstype; 
        private string _content;
        private Month _month;

        /// <summary>
        /// This is pass by value constructor that will help us to initialize the News object
        /// </summary>
        public News(NewsType newstype, string title ,string content, Month month){
            _newstype= newstype;
            _title = title;
            _content = content;
            _month = month;
        }

        /// <summary>
        /// this is Type property which will help us to access the _newstype to change or retrive value
        /// </summary>
        public NewsType Type{
            get{return _newstype;}
            set{_newstype = value;}
        }

        /// <summary>
        /// function that will help us to output the News object
        /// </summary>
        public void OutputContent(){
            Console.WriteLine("Month: " + _month);
            Console.WriteLine("Title: " + _title);
            Console.WriteLine("News Type: " + _newstype);
            Console.WriteLine("Content: " + _content + "\n");
        }

        /// <summary>
        /// function that will change News object month based on user input
        /// </summary>
        public void ChangeMonth(int i){
            if(i==1){_month = Month.January;}
            if(i==2){_month = Month.February;}
            if(i==3){_month = Month.March;}
            if(i==4){_month = Month.April;}
            if(i==5){_month = Month.May;}
            if(i==6){_month = Month.June;}
            if(i==7){_month = Month.July;}
            if(i==8){_month = Month.August;}
            if(i==9){_month = Month.September;}
            if(i==10){_month = Month.October;}
            if(i==11){_month = Month.November;}
            if(i==12){_month = Month.December;}
        }

        /// <summary>
        /// function that change News object newstype based on user input
        /// </summary>
        public void ChangeType(int i){
            if(i==1){_newstype = NewsType.General;}
            if(i==2){_newstype = NewsType.Specific;}
        }

        /// <summary>
        /// return _title string
        /// </summary>
        /// <value></value>
        public string Title{
            get{return _title;}
        } 
    }   
}