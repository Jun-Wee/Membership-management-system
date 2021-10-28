using System;
using System.Collections.Generic;

namespace PassTask13
{
    /// <summary>
    /// This is HobbyyGroups that help to create HobbyGroups object
    /// </summary>
    public class HobbyGroups
    {
        private List<Group> _hobbyGroups;
        private string _type;

        /// <summary>
        /// This is pass by value constructor will initialize the HobbyGroups object
        /// </summary>
        public HobbyGroups(string type){
            _type = type;
            _hobbyGroups = new List<Group>();
        }

        /// <summary>
        /// function that will add group object into _hobbyGroups list
        /// </summary>
        public void AddHobbyGroups(Group g){
                _hobbyGroups.Add(g);
        }

        /// <summary>
        /// function that will help edit HobbyGroups name based on user input
        /// </summary>
        public void EditHobbyGroups(string editgroup){
            Console.WriteLine("Change the name of the Group: ");
            string changename = Console.ReadLine();

            foreach (Group group in _hobbyGroups)
            {
                if (group.Name == editgroup)
                {
                    group.Name = changename;
                }
            }
        }

        /// <summary>
        /// function that will help remove certain group object from  _hobbyGroups based on user input
        /// </summary>
        public void RemoveHobbyGroups(string deletegroup){
            foreach (Group g in _hobbyGroups)
            {
                if (g.Name == deletegroup)
                {
                    _hobbyGroups.Remove(g);
                }
            }
        }
    }
}