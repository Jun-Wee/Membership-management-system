using System;
using System.Collections.Generic;

namespace PassTask13
{
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
    public class HobbyGroups
    {
        private string _name;
        private Month _month;
        private List<Member> _members; 
        private List<News> _allnews;
        private List<MonthlyEvents> _allevents;

        public HobbyGroups(string name, Month month){
            _name = name;
            _month = month;
        }

        public void CertainGroupNews(){}
        public void CertainMonthEvents(){}
    }
}