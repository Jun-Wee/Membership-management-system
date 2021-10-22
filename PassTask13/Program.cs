using System;
using System.Collections.Generic;

namespace PassTask13
{
    class Program
    {
        public static void user_panel(Member m, Membership ms,Group g, Payment p1, Payment p2){
            bool looping = true;
            do
            {
                Console.WriteLine("Choose the program you want to do, master");
                Console.WriteLine("Program 1: Membership_matter" + "\nProgram 2: News" + "\nProgram 3: Events" + "\nPress 99 to Quit");
                int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                Console.WriteLine("1. Edit membership" + "\n2. View Membership");
                    int choose_membership = Convert.ToInt32(Console.ReadLine());
                    if(choose_membership ==1)
                    {
                        m.EditMembership(ms,p2); //simulated as add the p2 into _paymentList
                        ms.Renewal(m,ms);   //renewal will check and change cosplay membership status 
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
                Console.WriteLine("1. View MonthlyEvents" + "\n2. View Comment" + "\n3.Post Comment");
                int choose_events = Convert.ToInt32(Console.ReadLine());
                if (choose_events == 1)
                {
                    m.ViewMonthlyEvents(g); 
                }
                if (choose_events == 2)
                {
                    //havent do
                }
                if (choose_events == 3)
                {
                     //havent do 
                }
                break;

                case 99:
                looping = false;
                Console.WriteLine("Program Ends...");
                break;
            }
            } while (looping==true);
            
        }

        public static void admin_panel(Member m){

        }
        static void Main(string[] args)
        {   
            //default setup 
            Member user = new Member("User",0,"123abc");
            Member admin = new Member("admin",0,"admin");
            Membership cosplay_membership = new Membership("Cosplay Membership");  //default status deactivated
            Payment Jan = new Payment(101,50,Month.January,true,PaymentType.monthly);
            Payment Feb = new Payment(102,50,Month.February,true,PaymentType.monthly);

            Group cosplay = new Group("Cosplay community");
            News general_news = new News(NewsType.General,"Closure","Shop will be close in weekend",Month.January);
            News cosplay_news = new News(NewsType.Specific,"Cosplay News", "Please prepare costume for cosplay event this month",Month.January);
            MonthlyEvents cosplay_event = new MonthlyEvents("Cosplay Event","Shop will held a cosplay event this month");
            Comment Jun_comment = new Comment("Jun Comment", "It is fun", "1/1/2022");

            //default perform
            user.AddMembership(cosplay_membership);
            cosplay_membership.MakePayment(Jan);  //only add Jan into _paymentList

            cosplay.AddEvents(cosplay_event);
            cosplay_event.AddComment(Jun_comment);
            cosplay.AddNews(general_news);
            cosplay.AddNews(cosplay_news);


            //main
            bool access = false;
            do{
                Console.Write("Please enter your password: ");
                string buffer = Console.ReadLine();
                if (buffer=="123abc")
                {
                    access = true;
                    user_panel(user,cosplay_membership,cosplay,Jan,Feb);  //go to member dashboard
                    
                }
                else if (buffer=="admin")
                {
                    access = true;
                    admin_panel(admin); //go to admin dashboard
                }
                else
                {
                    access = false;
                }
            } while (access==false);

        }
    }
}
