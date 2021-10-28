using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace PassTask13
{
    [TestFixture()]
    public class TestHobbyGroups
    {
        [Test()]
        public void TestAddMembers(){
            //setup
            Group Boardgamers_community = new Group("Boardgamers");
            Member Jun = new Member("Junwee",18,"123abc");
            Member Joe = new Member("Jojo", 18,"hello");
            //perform
            Boardgamers_community.AddMembers(Jun);
            Boardgamers_community.AddMembers(Joe);
            //check
            Assert.AreEqual(Boardgamers_community.Members.Count,2);            
        }

        [Test()]
        public void TestRemoveMembers(){
            //setup
            Group Boardgamers_community = new Group("Boardgamers");
            Member Jun = new Member("Junwee",18,"123abc");
            Member Joe = new Member("Jojo", 18,"hello");
            //perform
            Boardgamers_community.AddMembers(Jun);
            Boardgamers_community.AddMembers(Joe);
            Assert.AreEqual(Boardgamers_community.Members.Count,2); 
            Boardgamers_community.RemoveMembers(Joe);
            //check
            Assert.AreEqual(Boardgamers_community.Members.Count,1);
        }

        [Test()]
        public void TestAddNews(){
            //setup
            Group Boardgamers_community = new Group("Boardgamers");
            News monopoly_competition = new News(NewsType.Specific,"Monopoly Competition","Next Month will have Monopoly Competition. It is open to all boardgamers members",Month.November);
            News shop_closure = new News(NewsType.General,"Shop Closure on this Weekend","Hobby shop will be close on Sunday",Month.October);
            //perform
            Boardgamers_community.AddNews(monopoly_competition);
            Boardgamers_community.AddNews(shop_closure);
            //check
            Assert.AreEqual(Boardgamers_community.AllGroupNews.Count,1);
            Assert.AreEqual(Boardgamers_community.AllGeneralNews.Count,1);
        }

        [Test()]
        public void TestAddEvents(){
            //setup
            Group Boardgamers_community = new Group("Boardgamers");
            MonthlyEvents beach = new MonthlyEvents("Hang-out Session","Go beach party");
            //perform
            Boardgamers_community.AddEvents(beach);
            //check
            Assert.AreEqual(Boardgamers_community.AllEvents.Count,1);
        }
    }
}