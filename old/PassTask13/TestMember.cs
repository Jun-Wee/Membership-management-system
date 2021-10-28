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
            Membership tabletop_membership = new Membership("tabletop");
            Membership cosplay_membership = new Membership("cosplay");
            
            //perform
            Junwee.AddMembership(tabletop_membership);
            Junwee.AddMembership(cosplay_membership);

            //check
            Assert.AreEqual(Junwee.Membership.Count,2);     //membership will have 2 because by default all the membership object are in deactivated status, which will be inside the membership list
            Assert.AreEqual(Junwee.RenewalMembership.Count,0);
            
        }   

        [Test()]
        public void TestEditMmebership(){
            //setup
            Member Junwee = new Member("Junwee",18,"abc123");
            Membership cosplay_membership = new Membership("cosplay"); //status = deactivated by default
            
            //perform
            Junwee.AddMembership(cosplay_membership);  

            Assert.AreEqual(Junwee.Membership.Count,1);

                Payment Jan = new Payment(101,50,Month.January,true,PaymentType.monthly);
                Payment Feb = new Payment(102,50,Month.February,true,PaymentType.monthly);
                    cosplay_membership.MakePayment(Jan);
                    cosplay_membership.MakePayment(Feb);
            
            cosplay_membership.Renewal(Junwee,cosplay_membership);  //status of membership change to activated when the renewal detect the payment for Jan and Feb are in true status
            
            //check
            Assert.AreEqual(Junwee.RenewalMembership.Count,1);
        }

        [Test()]
        public void TestDeleteMembership(){
            //setup
            Member Junwee = new Member("Junwee",18,"abc123");
            Membership tabletop_membership = new Membership("tabletop");
            Membership cosplay_membership = new Membership("cosplay");

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