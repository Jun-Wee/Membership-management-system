using System;
using System.Collections.Generic;

namespace PassTask13
{
    class Program
    {
        /// <summary>
        ///  This is a function that simulate user module
        /// </summary>
        public static void user_panel(Member m, Membership ms,Group g, MonthlyEvents me){
            bool looping = true;
            do
            {
                Console.WriteLine("\nChoose the program you want to do, user");
                Console.WriteLine("Program 1: Membership_matter" + "\nProgram 2: News" + "\nProgram 3: Events" + "\nPress 99 to Quit");
                int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                Console.WriteLine("1. Edit membership" + "\n2. View Membership");
                    int choose_membership = Convert.ToInt32(Console.ReadLine());
                    if(choose_membership ==1)
                    {
                       m.EditMembership();
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
                Console.WriteLine("Back to Main Page...\n");
                break;
            }
            } while (looping==true);
            
        }

        /// <summary>
        /// This is a function that simulate admin module
        /// </summary>
        public static void admin_panel(Member m, Group g, Membership ms, Membership ms2,Shop hobbyshop,HobbyGroups allhobbygroups){
            bool looping = true;
            do
            {
                Console.WriteLine("\nChoose the program you want to do, master");
                Console.WriteLine("Program 1: Manage hobby group" + "\nProgram 2: Manage members" + "\nProgram 3: Manage News" + "\nProgram 4: Manage hobby events" + "\nPress 99 to Quit");
                int num = Convert.ToInt32(Console.ReadLine());
                
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
                        allhobbygroups.RemoveHobbyGroups();
                    }
                    if (manage_hobby_gp == 3){
                        allhobbygroups.EditHobbyGroups();
                    }
                break;

                case 2:
                Console.WriteLine("1. Register member" + "\n2. Delete member" + "\n3. View member" + "\n4. View Renewal member list" + "\n5. Process Member subscription");
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
                        hobbyshop.DeleteShopMember();
                    }

                    if (manage_member ==3)
                    {
                      Console.WriteLine("=====================" + "\nMember: "+ "\n=====================");
                       foreach (Member mem in hobbyshop.ShopMember)
                       {
                           mem.OutputMember();
                       }
                    }

                    if (manage_member ==4)
                    {
                       foreach (Member mm in hobbyshop.ShopMember)
                       {
                           Console.WriteLine("Now membership count: "+mm.Membership.Count);
                           mm.CheckMembership();
                           mm.ViewMonthlyRenewalList();
                       }
                    }

                    if (manage_member ==5)
                    {
                       foreach (Member mm in hobbyshop.ShopMember) 
                      {
                        mm.Renewal();
                        mm.CheckMembership();

                      }
                    }
                break;

                case 3:
                Console.WriteLine("1.Add News" + "\n2.Delete General News" + "\n3.Delete Group News");
                    int manage_news = Convert.ToInt32(Console.ReadLine());
                    if (manage_news==1)
                    {
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("News type: " + "1.NewsType.General 2.NewsType.Specific: ");
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
                        
                        g.RemoveGeneralNews();
                    }
                    if (manage_news == 3)
                    {
                        Console.Write("Write the News title to delete: ");
                        
                        g.RemoveGroupNews();
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
                        g.RemoveEvents();
                    }
                break;

                case 99:
                looping = false;
                Console.WriteLine("Back to Main Page...\n");
                break;
            }
            } while (looping==true);
        }

        /// <summary>
        /// This is the Main function that will responsible for default setup and login page loop
        /// </summary>
        static void Main(string[] args)
        {   
            //default setup
            Shop hobbyshop = new Shop();
            HobbyGroups allhobbygroups = new HobbyGroups("Event_type");
            Member user = new Member("User",0,"123abc");
            Member admin = new Member("admin",0,"admin");
            Membership cosplay_membership =new Membership("CosplayMembership",2,0,PaymentType.monthly,2021,Month.January); //no expire, status default deactivate
            Membership cosplay_membership2 =new Membership("CosplayMembership",1,0,PaymentType.monthly,2021,Month.February); //expire need another one month pay, status default deactivate



            Group cosplay = new Group("Cosplay community");
            News general_news = new News(NewsType.General,"Closure","Shop will be close in weekend",Month.January);
            News cosplay_news = new News(NewsType.Specific,"Cosplay News", "Please prepare costume for cosplay event this month",Month.January);
            MonthlyEvents cosplay_event = new MonthlyEvents("Cosplay Event","Shop will held a cosplay event this month");
            Comment Jun_comment = new Comment("Jun Comment", "It is fun", "1/1/2022");

            //default perform
            hobbyshop.AddShopMember(user);
            user.AddMembership(cosplay_membership);
            user.AddMembership(cosplay_membership2);
            user.CheckMembership();  //check the membership whether should it be inside the list or not

            cosplay.AddEvents(cosplay_event);
            cosplay_event.AddComment(Jun_comment);
            cosplay.AddNews(general_news);
            cosplay.AddNews(cosplay_news);


            //Main page
            bool access = false;
            do{
                Console.WriteLine("=====================" + "\nWelcome to Hobby Shop" + "\n=====================");
                Console.WriteLine("Please select the module: " + "\n1.Admin" + "\n2.Member"+ "\n3.Quit");
                int choosenumber = Convert.ToInt32(Console.ReadLine());
                if (choosenumber == 1)
                {
                    Console.Write("Please enter your admin password: ");
                    string buffer1 = Console.ReadLine();
                    if (buffer1=="admin")
                    {
                        admin_panel(user,cosplay,cosplay_membership,cosplay_membership2,hobbyshop,allhobbygroups); //go to admin dashboard
                    }
                    else
                    {
                        Console.WriteLine("You have entered wrong password.\n");
                    }
                }
                else if(choosenumber == 2)
                {
                    Console.Write("Please enter your user password: ");
                    string buffer2 = Console.ReadLine();
                    if (buffer2=="123abc")
                    {  
                        user_panel(user,cosplay_membership,cosplay,cosplay_event);  //go to member dashboard
                    }
                    else
                    {   
                        Console.WriteLine("You have entered wrong password.\n");
                    }
                }
                else
                {
                    access = true;
                    Console.WriteLine("Program Ends...");

                }
            } while (access==false);

        }
    }
}
