using System;
using System.Collections.Generic;

namespace PassTask13
{
    public class HobbyGroups
    {
        private List<Group> _hobbyGroups;
        private string _type;

        public HobbyGroups(string type){
            _type = type;
            _hobbyGroups = new List<Group>();
        }

        public void AddHobbyGroups(Group g){
            _hobbyGroups.Add(g);
        }

        public void EditHobbyGroups(HobbyGroups g){
            Console.WriteLine("Change the type of the Hobby Groups: ");
            string buffer = Console.ReadLine();
            g._type = buffer;
        }

        public void RemoveHobbyGroups(Group g){
            _hobbyGroups.Remove(g);
        }
    }
}