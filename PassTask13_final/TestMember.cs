using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace PassTask13
{
    [TestFixture()]
    public class TestMember
    {
        [Test()]
        public void TestAddMembership(){
            //setup
            Member Junwee = new Member("Junwee",18,"abc123");
            Membership tabletop_membership = new Membership("tabletop",2,0,PaymentType.monthly,2021,Month.February);
            Membership cosplay_membership = new Membership("cosplay",0,1,PaymentType.annual,2021,Month.January);
            
            //perform
            Junwee.AddMembership(tabletop_membership);
            Junwee.AddMembership(cosplay_membership);

            //check
            Assert.AreEqual(Junwee.Membership.Count,2);  
            
        }   


        [Test()]
        public void TestDeleteMembership(){
            //setup
            Member Junwee = new Member("Junwee",18,"abc123");
            Membership tabletop_membership = new Membership("tabletop",2,0,PaymentType.monthly,2021,Month.February);
            Membership cosplay_membership = new Membership("cosplay",0,1,PaymentType.annual,2021,Month.January);

            //perform
            Junwee.AddMembership(tabletop_membership);
            Junwee.AddMembership(cosplay_membership);

            //check
            Assert.AreEqual(Junwee.Membership.Count,2);

            Junwee.DeleteMembership(tabletop_membership);

            Assert.AreEqual(Junwee.Membership.Count,1);
        }
    }
    
}