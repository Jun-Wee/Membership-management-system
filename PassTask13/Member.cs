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
        private List<Group> _enrolGroups;
        private string _password;
        private bool _access;

        public Member(string name, int age, string password){
            _name = name;
            _age = age;
            _password = password;
            _access = false;
            _membership = new List<Membership>();
            _renewalMembership = new List<Membership>();
            _enrolGroups = new List<Group>();
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
        public void EditMembership(Membership m, Payment p){ //editMembership is for member to pay fees
            m.MakePayment(p);
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

        public void JoinGroup(Member m, Group g){
            g.AddMembers(m);
        }
        public void LeaveGroup(Member m , Group g){
            g.RemoveMembers(m);
        }

        public void ViewGroupNews(Group g){
            g.DisplayGroupNews();
        }
        public void ViewGeneralNews(Group g){
            g.DisplayGeneralNews();
        }
        
        public void ViewMonthlyEvents(Group g){
            g.DislplayMonthlyEvents();
        }

        public void PostComment(Group g, MonthlyEvents e){
            g.CommentInEvents(e); //the poost comment coding is in group class 
        }

        public void ViewComment(Group g, MonthlyEvents e){
            g.CommentInEvents(e); // the view comment coding is in group class 
        }

        public List<Membership> Membership{
            get{return _membership;}
        }

        public List<Membership> RenewalMembership{
            get{return _renewalMembership;}
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