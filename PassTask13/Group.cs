using System;
using System.Collections.Generic;

namespace PassTask13
{
    public class Group
    {
        private string _name;
        private List<Member> _members;
        private List<News> _allGeneralNews;
        private List<News> _allGroupNews;
        private List<MonthlyEvents> _allEvents;

        public Group(string name){
            _name = name;
            _members = new List<Member>();
            _allGeneralNews = new List<News>();
            _allGroupNews = new List<News>();
            _allEvents = new List<MonthlyEvents>();
        }
        
        public void AddNews(News n){
            if (n.Type == NewsType.General)
            {
                _allGeneralNews.Add(n);
            }
            else
            {
                _allGroupNews.Add(n);
            }
        }

        public void RemoveNews(News n){
            if (n.Type == NewsType.General)
            {
                _allGeneralNews.Remove(n);
            }
            else
            {
                _allGroupNews.Remove(n);
            }    
        }
        public void AddEvents(MonthlyEvents e){
            _allEvents.Add(e);
        }
        public void RemoveEvents(MonthlyEvents e){
            _allEvents.Remove(e);
        }

        public void CommentInEvents(MonthlyEvents e){   //cetain event in the group
            Console.WriteLine("Choose 1. Add comment on events \n Choose 2. View comment on events");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x==1){
                //take user input to form the comment object
                Console.WriteLine("Title: ");
                string title = Console.ReadLine();
                
                Console.WriteLine("Content: ");
                string content = Console.ReadLine();

                Console.WriteLine("Date: ");
                string date = Console.ReadLine();

                Comment buffer = new Comment(title,content,date);
                //add the comment object into comment list
                e.AddComment(buffer);
            }
            else{
                Console.WriteLine("Below is all the comment on the events: ");
                foreach (Comment c in e.Comments)
                {
                    c.OutputComment(); //output the tile content and date of comment in commnet list
                }
            }
        }

        public void DisplayGroupNews(){
            Console.WriteLine("Below is the Group News: ");
            foreach (News n in _allGroupNews)
            {
                n.OutputContent();
            }
        }

        public void DisplayGeneralNews(){
            Console.WriteLine("Below is the General News: ");
            foreach (News n in _allGeneralNews)
            {
                n.OutputContent();
            }
        }

        public void DislplayMonthlyEvents(){
            Console.WriteLine("Below is the Group Events: ");
            foreach (MonthlyEvents e in _allEvents)
            {
                Console.WriteLine(e.Content + "\n");
            }
        }

        public void AddMembers(Member m){
            _members.Add(m);
        }   
        public void RemoveMembers(Member m){
            _members.Remove(m);
        }
        public List<Member> Members{
            get{return _members;}
        }

        public List<News> AllGeneralNews{
            get{return _allGeneralNews;}
        }

        public List<News> AllGroupNews{
            get{return _allGroupNews;}
        }

        public List<MonthlyEvents> AllEvents{
            get{return _allEvents;}
        }
    }   
}