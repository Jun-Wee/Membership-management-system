using System;
using System.Collections.Generic;

namespace PassTask13
{
    public class Member
    {
        private string _name;
        private int _age;
        private List<Membership> _membership;
        private List<Membership> _renewalMembership;
        private List<HobbyGroups> _hobbyGroups;
        private string _password;
        private bool _access;

        public Member(string name, int age, string password){
            _name = name;
            _age = age;
            _password = password;
            _access = false;
        }

        public void AddMembership(Membership m){
            if (m.MembershipStatus == Status.activate)
            {
                _renewalMembership.Add(m);
            }
            else
            {
                _membership.Add(m);
            }
            
        }

        public void EditMembership(Membership m){
        }
        public void DeleteMembership(Membership m){
            if (m.MembershipStatus == Status.activate)
            {
                _renewalMembership.Remove(m);
            }
            else
            {
                _membership.Remove(m);
            }
        }

        public List<Membership> Membership{
            get{return _membership;}
        }

        public List<Membership> RenewalMembership{
            get{return _renewalMembership;}
        } 

        public void ViewGroupNews(List<HobbyGroups> g){
            //still cannot control output certain group news
            foreach (HobbyGroups x in _hobbyGroups)
            {
                x.CertainGroupNews();
            }
        }

        public void ViewGeneralNews(){}
        
        public void ViewMonthlyEvents(){}

        public void PostComment(MonthlyEvents e, Comment c){
            e.AddComment(c);
        }

        public void ViewComment(MonthlyEvents e){
            List<Comment> buffer;
            buffer = e.Comments;
            Console.WriteLine(buffer);
        }

        public void AuthenticateAcess(){
            Console.WriteLine("Please input your password: ");
            String readPassword = Console.ReadLine();
            if (readPassword == _password)
            {
                _access = true;
            }
            else
            {
                _access = false;
                Console.WriteLine("You have entered wrong password");
            }
        }

    }    
}