using System;
using System.Collections.Generic;

namespace PassTask13
{
    /// <summary>
    /// This is Member class that help to create Member object
    /// </summary>
    public class Member
    {
        private string _name;
        private int _age;
        private List<Membership> _membership;
        private List<Membership> _renewalMembership;
        private List<Group> _enrolGroups;
        private string _password;
        private bool _access;

        /// <summary>
        /// This is pass by value constructor that will help to initialize Member object
        /// </summary>
        public Member(string name, int age, string password){
            _name = name;
            _age = age;
            _password = password;
            _access = false;
            _membership = new List<Membership>();
            _renewalMembership = new List<Membership>();
            _enrolGroups = new List<Group>();
        }

        /// <summary>
        /// function that will add Membership object to respective membership list based on the membership object status
        /// </summary>
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

        /// <summary>
        /// function that will need Membership object and payment object to make payment
        /// </summary>
        public void EditMembership(Membership m, Payment p){ //editMembership is for member to pay fees
            m.MakePayment(p);
        }

        /// <summary>
        /// function that will delete certain membership object from the membership list based on the object status
        /// </summary>
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

        /// <summary>
        /// function that need Member object and Group object to add member itself to certain group
        /// </summary>
        public void JoinGroup(Member m, Group g){
            g.AddMembers(m);
        }

        /// <summary>
        /// function that need Member object and Group object to remove member itself from certain group
        /// </summary>
        public void LeaveGroup(Member m , Group g){
            g.RemoveMembers(m);
        }

        /// <summary>
        /// function to output the membership list
        /// </summary>
        public void OutputMembership(){
            Console.WriteLine("All Membership List: ");
            foreach (Membership ms in _membership)
            {
                Console.WriteLine("Name: " + ms.MembershipName);
                Console.WriteLine("Status: " + ms.MembershipStatus);
            }
            Console.WriteLine("Renwal Membership List: ");
            foreach (Membership ms in _renewalMembership)
            {
                Console.WriteLine("Name: " + ms.MembershipName);
                Console.WriteLine("Status: "+ms.MembershipStatus);
            }
        }

        /// <summary>
        /// function that call group object to display group news
        /// </summary>
        public void ViewGroupNews(Group g){
            g.DisplayGroupNews();
        }

        /// <summary>
        /// function that call group object to display general news
        /// </summary>
        public void ViewGeneralNews(Group g){
            g.DisplayGeneralNews();
        }
        
        /// <summary>
        /// function that call group object to display monthly events
        /// </summary>
        public void ViewMonthlyEvents(Group g){
            g.DislplayMonthlyEvents();
        }

        /// <summary>
        /// function that need group object and monthlyevents object to execute add comment or view comment
        /// </summary>
        public void CommentMatter(Group g, MonthlyEvents e){
            g.CommentInEvents(e); // the Add and view comment coding is in group class 
        }

        /// <summary>
        ///  readonly property that return _membership list
        /// </summary>
        public List<Membership> Membership{
            get{return _membership;}
        }

        /// <summary>
        ///  readonly property that return _renewalMembership list
        /// </summary>
        public List<Membership> RenewalMembership{
            get{return _renewalMembership;}
        } 

        /// <summary>
        ///  readonly property that return Name string
        /// </summary>
        public string Name{
            get{return _name;}
        }

    }    
}