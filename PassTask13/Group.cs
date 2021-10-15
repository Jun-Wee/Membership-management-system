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

        public void CommentInEvents(MonthlyEvents e){
            Console.WriteLine("Choose 1. Add comment on events \n Choose 2. View comment on events");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x==1){
                //take user input to form the comment object
                Console.WriteLine("Title: ");
                string title = Console.ReadLine();
                
                Console.WriteLine("Content: ");
                string content = Console.ReadLine();

                Console.WriteLine("Datw: ");
                string date = Console.ReadLine();

                Comment buffer = new Comment(title,content,date);
                //add the comment object into comment list
                e.AddComment(buffer);
            }
        }

        public void DisplayGroupNews(){
            Console.WriteLine("Below is the Group News: \n" + _allGroupNews);
        }
        public void DisplayGeneralNews(){
            Console.WriteLine("Below is the General News: \n" + _allGeneralNews);
        }
        public void DislplayMonthlyEvents(){
            Console.WriteLine("Below is the General News: \n" + _allGeneralNews);
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
    }   
}