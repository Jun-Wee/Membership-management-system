using System;
using System.Collections.Generic;

namespace PassTask13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             Member Junwee = new Member("Junwee",18,"abc123");
            Membership tabletop_membership = new Membership("tabletop");
            Membership cosplay_membership = new Membership("cosplay");
            
            Junwee.AddMembership(tabletop_membership);
            Junwee.AddMembership(cosplay_membership);
            Console.WriteLine(Junwee.Membership.Count);
        }
    }
}
