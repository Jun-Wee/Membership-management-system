using System;
using System.Collections.Generic;

namespace PassTask13
{
    /// <summary>
    /// This is Group class that help to create Group object
    /// </summary>
    public class Group
    {
        private string _name;
        private List<Member> _members;
        private List<News> _allGeneralNews;
        private List<News> _allGroupNews;
        private List<MonthlyEvents> _allEvents;

        /// <summary>
        /// This is pass by value constructor it will initialize the Group object
        /// </summary>
        public Group(string name){
            _name = name;
            _members = new List<Member>();
            _allGeneralNews = new List<News>();
            _allGroupNews = new List<News>();
            _allEvents = new List<MonthlyEvents>();
        }

        /// <summary>
        /// function that will help to add News object into respective news list based on its newstype
        /// </summary>
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

        /// <summary>
        /// function the help remove news object from _allGroupNews list based on user input
        /// </summary>
        public void RemoveGroupNews(){   
            int x = 0;   
            foreach (News n in _allGroupNews)
            {
                Console.WriteLine(x+" "+n.Title);
                x++;
            }  
            Console.Write("Choose the number you want to delete: ");
            int user_input = Convert.ToInt32(Console.ReadLine());
            _allGroupNews.RemoveAt(user_input);
        }

        /// <summary>
        /// function the help remove news object from _allGenralNews list based on user input
        /// </summary>
        public void RemoveGeneralNews(){   
            int x = 0;
            foreach (News n in _allGeneralNews)
            {
                Console.WriteLine(x+" "+n.Title);
                x++;
            }
            Console.Write("Choose the number you want to delete: ");
            int user_input = Convert.ToInt32(Console.ReadLine());
            _allGeneralNews.RemoveAt(user_input);
        }

        /// <summary>
        /// function that help to add MonthlyEvents object into _allEvents list
        /// </summary>
        public void AddEvents(MonthlyEvents e){
            _allEvents.Add(e);
        }

        /// <summary>
        /// function that help to remove certain MonthlyEvents object from _allEvents list based on user input
        /// </summary>
        public void RemoveEvents(){
            int x = 0;
            foreach (MonthlyEvents me in _allEvents)
            {
                Console.WriteLine(x +" "+ me.Title);
                x++;
            }
            Console.Write("Choose the number you want to delete: ");
            int user_input =Convert.ToInt32(Console.ReadLine());
            _allEvents.RemoveAt(user_input);
        }

        /// <summary>
        /// function that will prompt user for either add comment or view comment
        /// </summary>
        public void CommentInEvents(MonthlyEvents e){   //cetain event in the group
            Console.WriteLine("Choose 1. Add comment on events"+"\n"+"Choose 2. View comment on events");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x==1){
                //take user input to form the comment object
                Console.Write("Title: ");
                string title = Console.ReadLine();
                
                Console.Write("Content: ");
                string content = Console.ReadLine();

                Console.Write("Date: ");
                string date = Console.ReadLine();

                Comment buffer = new Comment(title,content,date);
                //add the comment object into comment list
                e.AddComment(buffer);
            }
            else{
                foreach (MonthlyEvents me in _allEvents)
                {
                    me.DisplayComment();
                }
                
            }
        }

        /// <summary>
        /// function that will display group news object content in _allGroupsNews list
        /// </summary>
        public void DisplayGroupNews(){
            Console.WriteLine("=====================" + "\nBelow is the Group News: "+ "\n=====================");
            foreach (News n in _allGroupNews)
            {
                n.OutputContent();
            }
        }

        /// <summary>
        /// function that will display general news object content in _allGenaralNews list
        /// </summary>
        public void DisplayGeneralNews(){
            Console.WriteLine("=====================" + "\nBelow is the General News: "+ "\n=====================");
            foreach (News n in _allGeneralNews)
            {
                n.OutputContent();
            }
        }

        /// <summary>
        /// function that will display MonthlyEvents object in _allEvents list
        /// </summary>
        public void DislplayMonthlyEvents(){
            Console.WriteLine("=====================" + "\nBelow is the Group Events: "+ "\n=====================");
            foreach (MonthlyEvents e in _allEvents)
            {
                e.OutputEvents();
            }
        }

        /// <summary>
        /// function that will add Member object into _members list
        /// </summary>
        public void AddMembers(Member m){
            _members.Add(m);
        }   

        /// <summary>
        /// function that will remove certain Member object from _members list
        /// </summary>
        public void RemoveMembers(Member m){
            _members.Remove(m);
        }

        /// <summary>
        /// return _members list
        /// </summary>
        public List<Member> Members{
            get{return _members;}
        }

        /// <summary>
        /// return _allGeneralNews list
        /// </summary>
        public List<News> AllGeneralNews{
            get{return _allGeneralNews;}
        }

        /// <summary>
        ///  return _allGroupNews list
        /// </summary>
        public List<News> AllGroupNews{
            get{return _allGroupNews;}
        }

        /// <summary>
        /// reutrn _allEvents list
        /// </summary>
        public List<MonthlyEvents> AllEvents{
            get{return _allEvents;}
        }

        /// <summary>
        /// this is Name property which will help us to access the _name to change or retrive value
        /// </summary>
        public string Name{
            get{return _name;}
            set{_name = value;}
        }
    }   
}