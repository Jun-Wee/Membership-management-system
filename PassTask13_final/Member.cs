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
        private List<Group> _enrolGroups;
        private string _password;

        /// <summary>
        /// This is pass by value constructor that will help to initialize Member object
        /// </summary>
        public Member(string name, int age, string password){
            _name = name;
            _age = age;
            _password = password;
            _membership = new List<Membership>();
            _enrolGroups = new List<Group>();
        }

        /// <summary>
        /// function that will add Membership object to respective membership list based on the membership object status
        /// </summary>
        public void AddMembership(Membership m){
            if (m.MembershipStatus == Status.activate)
            {
                _membership.Add(m);
            }  
        }

        /// <summary>
        /// function that help to edit membership name
        /// </summary>
        public void EditMembership(){ 
            Console.Write("Write a new membership name: ");
            string newname = Console.ReadLine();
            _name = newname;
        }

        /// <summary>
        /// function that will delete certain membership object from the membership list based on the object status
        /// </summary>
        public void DeleteMembership(Membership m){
            if (m.MembershipStatus == Status.activate)
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
        public void OutputMembership(){  //this will see all the membership list included the active and deactive 
            Console.WriteLine("=====================" + "\nMembership List: "+ "\n=====================");
            foreach (Membership ms in _membership)
            {
                Console.WriteLine("\nMember name:" + _name);
                Console.WriteLine("Membership name:" + ms.MembershipName);
                Console.WriteLine("Membership status: " + ms.MembershipStatus);
                Console.WriteLine("Membership Expiry Month left: " + ms.ExpiryMonth + " months");
                Console.WriteLine("Membership Expiry Year: " + ms.ExpiryYear + " years");
                Console.WriteLine("Membership Type: " + ms.MembershipType);
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
        /// Function that output member object details
        /// </summary>
        public void OutputMember(){
            Console.WriteLine("\nName: "+ _name);
            Console.WriteLine("Age: "+ _age);
            string x = "";
            for (int i = 0; i < _password.Length; i++)  //change the user password to *
            {
                x += "*";
            }
            Console.WriteLine("Password: "+ x);
        }

        /// <summary>
        /// function that will prompt user membership details to change either membership expirymonth / expiryyear
        /// </summary>
        public void Renewal(){
            Console.WriteLine("Choose Month(1) or Year(2): ");
            int chosen = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which membership name: ");
            string chosen_name = Console.ReadLine();
            string chosen_name_tolower = chosen_name.ToLower();

            Console.WriteLine("Which Year: ");
            int chosen_year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Which Month(type number): ");
            int chosen_month = Convert.ToInt32(Console.ReadLine());
            Month buffer = ChooseMonth(chosen_month);

            foreach (Membership ms in _membership)
            {
                if (chosen == 1)
                {
                    string lowermembershipname = ms.MembershipName.ToLower();
                    if (string.Equals(lowermembershipname,chosen_name_tolower) && ms.MembershipYear == chosen_year && ms.MembershipMonth == buffer)  //choose the specific membership 
                    {
                        ms.ExpiryMonth +=1;
                    }
                }
                else
                {
                    ms.MembershipName.ToLower();
                    if ( ms.MembershipYear == chosen_year && ms.MembershipMonth == buffer)  //choose the specific membership 
                    {
                        ms.ExpiryYear +=1;
                    }
                }
            }
        }

        /// <summary>
        /// function that will output the membership that are in activate status and by user input 
        /// </summary>
        public void ViewMonthlyRenewalList(){
            Console.WriteLine("Please enter the Year: ");
            int chosen_year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Month in number: ");
            
            int chosen_month = Convert.ToInt32(Console.ReadLine());
            Month buffer = ChooseMonth(chosen_month);
            foreach (Membership ms in _membership)
            {
                if (ms.MembershipYear==chosen_year && ms.MembershipMonth == buffer && ms.MembershipStatus == Status.activate) //output only the status with active
                {
                    Console.WriteLine("Member name:" + _name);
                    Console.WriteLine("Membership name:" + ms.MembershipName);
                    Console.WriteLine("Membership status: " + ms.MembershipStatus);
                    Console.WriteLine("Membership Expiry Month left: " + ms.ExpiryMonth + " months");
                    Console.WriteLine("Membership Expiry Year: " + ms.ExpiryYear + " years");
                    Console.WriteLine("Membership Type: " + ms.MembershipType);
                }
            } 
        }

        /// <summary>
        /// function that check and change the membership status by looking at the expirymonth and expiryyear field 
        /// </summary>
        public void CheckMembership(){
            foreach (Membership ms in _membership)
            {
                if ((ms.ExpiryMonth >= 2) || (ms.ExpiryYear >= 1))  
                {
                    ms.MembershipStatus = Status.activate;
                }
                else 
                {
                    ms.MembershipStatus = Status.deactivated;
                }
            }
        }

        /// <summary>
        /// function that will return the corresponding month based on user input
        /// </summary>
        public Month ChooseMonth(int chosen_month){
            Month buffer = Month.All;
            if(chosen_month==1){return buffer = Month.January;}
            if(chosen_month==2){return buffer = Month.February;}
            if(chosen_month==3){return buffer = Month.March;}
            if(chosen_month==4){return buffer = Month.April;}
            if(chosen_month==5){return buffer = Month.May;}
            if(chosen_month==6){return buffer = Month.June;}
            if(chosen_month==7){return buffer = Month.July;}
            if(chosen_month==8){return buffer = Month.August;}
            if(chosen_month==9){return buffer = Month.September;}
            if(chosen_month==10){return buffer = Month.October;}
            if(chosen_month==11){return buffer = Month.November;}
            if(chosen_month==12){return buffer = Month.December;}
            else{return buffer;}
        }

        /// <summary>
        ///  readonly property that return _membership list
        /// </summary>
        public List<Membership> Membership{
            get{return _membership;}
        } 

        /// <summary>
        ///  readonly property that return Name string
        /// </summary>
        public string Name{
            get{return _name;}
        }

    }    
}