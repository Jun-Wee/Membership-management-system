using System;
using System.Collections.Generic;

namespace PassTask13
{
    class Program
    {
        /// <summary>
        ///  This is a function that simulate user module
        /// </summary>
        public static void user_panel(Member m, Membership ms,Group g, Payment Feb, MonthlyEvents me){
            bool looping = true;
            do
            {
                Console.WriteLine("Choose the program you want to do, user");
                Console.WriteLine("Program 1: Membership_matter" + "\nProgram 2: News" + "\nProgram 3: Events" + "\nPress 99 to Quit");
                int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                Console.WriteLine("1. Edit membership" + "\n2. View Membership");
                    int choose_membership = Convert.ToInt32(Console.ReadLine());
                    if(choose_membership ==1)
                    {
                        m.EditMembership(ms,Feb); // make payment for certain month that are in false status to true status 
                        ms.Renewal(m,ms);   //renewal will check and change cosplay membership status from deactivated to activated
                    }
                    if (choose_membership == 2)
                    {
                        m.OutputMembership();
                    }
                break;
                
                case 2:
                Console.WriteLine("1. View Group News" + "\n2. View General News");
                    int choose_news = Convert.ToInt32(Console.ReadLine());
                    if (choose_news==1){
                        m.ViewGroupNews(g);
                    }
                    else{
                        m.ViewGeneralNews(g);
                    }
                break;

                case 3:
                Console.WriteLine("1.View MonthlyEvents" + "\n2.Comment");
                int choose_events = Convert.ToInt32(Console.ReadLine());
                if (choose_events == 1)
                {
                    m.ViewMonthlyEvents(g); 
                }
                if (choose_events == 2)
                {
                    m.CommentMatter(g,me); //send in user's certain group and certain event
                }
                break;

                case 99:
                looping = false;
                Console.WriteLine("Program Ends...");
                break;
            }
            } while (looping==true);
            
        }

        /// <summary>
        /// This is a function that simulate admin module
        /// </summary>
        public static void admin_panel(Member m, Group g){
            bool looping = true;
            do
            {
                Console.WriteLine("Choose the program you want to do, master");
                Console.WriteLine("Program 1: Manage hobby group" + "\nProgram 2: Manage members" + "\nProgram 3: Manage News" + "\nProgram 4: Manage hobby events" + "\nPress 99 to Quit");
                int num = Convert.ToInt32(Console.ReadLine());
                
                //default setup
                Shop hobbyshop = new Shop();
                HobbyGroups allhobbygroups = new HobbyGroups("Event_type");

            switch (num)
            {
                case 1:
                Console.WriteLine("1. Add Hobby group" + "\n2. Delete Hobby group" + "\n3. Edit Hobby Group");
                    int manage_hobby_gp = Convert.ToInt32(Console.ReadLine());
                    if (manage_hobby_gp==1){
                        Console.Write("Hobbygroup name: ");
                        string name = Console.ReadLine();
                        Group new_group = new Group(name);
                        allhobbygroups.AddHobbyGroups(new_group);

                    }
                    if (manage_hobby_gp == 2){
                        Console.Write("Write the hobbygroup name to delete: ");
                        string deletegroup = Console.ReadLine();
                        allhobbygroups.RemoveHobbyGroups(deletegroup);
                    }
                    if (manage_hobby_gp == 3){
                        Console.Write("Write the hobbygroup name to edit: ");
                        string editgroup = Console.ReadLine();
                        allhobbygroups.EditHobbyGroups(editgroup);
                    }
                break;

                case 2:
                Console.WriteLine("1. Register member" + "\n2. Delete member" + "\n3. View member");
                    int manage_member = Convert.ToInt32(Console.ReadLine());
                    if(manage_member ==1)
                    {
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Password Set: ");
                        string password = Console.ReadLine();
                        Member new_member = new Member(name,age,password);
                        hobbyshop.AddShopMember(new_member);
                    }
                    if (manage_member == 2)
                    {
                        Console.Write("Write the member name to delete: ");
                        string deletemember = Console.ReadLine();
                        hobbyshop.DeleteShopMember(deletemember);
                    }
                    if (manage_member ==3)
                    {
                       foreach (Member mem in hobbyshop.ShopMember)
                       {
                           Console.WriteLine(mem.Name);
                       }
                    }
                break;

                case 3:
                Console.WriteLine("1.Add News" + "\n2.Delete News");
                    int manage_news = Convert.ToInt32(Console.ReadLine());
                    if (manage_news==1)
                    {
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("News type: " + "1.NewsType.General 2.NewsType.Specific");
                        int newstype = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Content: ");
                        string content = Console.ReadLine();
                        Console.Write("Month(type the number to represent the month): ");
                        int month = Convert.ToInt32(Console.ReadLine());
                        
                        News latest_news = new News(NewsType.General,title,content,Month.January);
                        latest_news.ChangeMonth(month);
                        latest_news.ChangeType(newstype);
                        
                        g.AddNews(latest_news);  //add news into cosplay group
                    }
                    if (manage_news == 2)
                    {
                        Console.Write("Write the News title to delete: ");
                        string deletenews = Console.ReadLine();
                        g.RemoveNews(deletenews);
                    }
                    
                break;

                case 4:
                Console.WriteLine("1.Add Hobby events" +"\n2.Delete Hobby events");
                    int managehobbyevents = Convert.ToInt32(Console.ReadLine());
                    if (managehobbyevents == 1){
                         Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Content: ");
                        string content = Console.ReadLine();
                        
                        MonthlyEvents newevents = new MonthlyEvents(title,content);
                        g.AddEvents(newevents);
                    }
                    if (managehobbyevents == 2){
                        Console.Write("Write the Hobbyevents title to delete: ");
                        string deletehobbyevents = Console.ReadLine();
                        g.RemoveEvents(deletehobbyevents);
                    }
                break;

                case 99:
                looping = false;
                Console.WriteLine("Program Ends...");
                break;
            }
            } while (looping==true);
        }
        
        /// <summary>
        /// This is a method that will initialize all the default setup for console application
        /// </summary>
        public static void Defaultsetup(){
            //default setup 
            Member user = new Member("User",0,"123abc");
            Member admin = new Member("admin",0,"admin");
            Membership cosplay_membership = new Membership("Cosplay Membership");  //default status deactivated
            Payment Jan = new Payment(101,50,Month.January,true,PaymentType.monthly);
            Payment Feb = new Payment(102,50,Month.February,false,PaymentType.monthly);
            Payment March = new Payment(103,50,Month.March,false,PaymentType.monthly); 
            
            Group cosplay = new Group("Cosplay community");
            News general_news = new News(NewsType.General,"Closure","Shop will be close in weekend",Month.January);
            News cosplay_news = new News(NewsType.Specific,"Cosplay News", "Please prepare costume for cosplay event this month",Month.January);
            MonthlyEvents cosplay_event = new MonthlyEvents("Cosplay Event","Shop will held a cosplay event this month");
            Comment Jun_comment = new Comment("Jun Comment", "It is fun", "1/1/2022");

            //default perform
            user.AddMembership(cosplay_membership);
            cosplay_membership.MakePayment(Jan);  // add Jan into _paymentList
            cosplay_membership.MakePayment(Feb); // add Feb into _paymentList
            cosplay_membership.MakePayment(March);// add March into _paymentList

            cosplay.AddEvents(cosplay_event);
            cosplay_event.AddComment(Jun_comment);
            cosplay.AddNews(general_news);
            cosplay.AddNews(cosplay_news);


            //login module
            bool access = false;
            do{
                Console.Write("Please enter your password: ");
                string buffer = Console.ReadLine();
                if (buffer=="123abc")
                {
                    access = true;
                    user_panel(user,cosplay_membership,cosplay,Feb,cosplay_event);  //go to member dashboard
                    
                }
                else if (buffer=="admin")
                {
                    access = true;
                    admin_panel(user,cosplay); //go to admin dashboard
                }
                else
                {
                    access = false;
                }
            } while (access==false);
        }

        /// <summary>
        /// Main function
        /// </summary>
        static void Main(string[] args)
        {   
            Defaultsetup();
        }
    }
}
