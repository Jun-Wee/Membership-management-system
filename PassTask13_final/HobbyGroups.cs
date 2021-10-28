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
        public void EditHobbyGroups(){
            int x = 0;
            foreach (Group g in _hobbyGroups)
            {
                Console.WriteLine(x + " " + g.Name);
                x++;
            }
            Console.Write("Choose the number you want to edit: ");
            int user_input = Convert.ToInt32(Console.ReadLine());
            Group buffer = _hobbyGroups[user_input];

            Console.WriteLine("Write the new name for the Group: ");
            string changename = Console.ReadLine();
            buffer.Name = changename;
        }

        /// <summary>
        /// function that will help remove certain group object from  _hobbyGroups based on user input
        /// </summary>
        public void RemoveHobbyGroups(){
             int x = 0;
            foreach (Group g in _hobbyGroups)
            {
                Console.WriteLine(x + " " + g.Name);
                x++;
            }
            Console.Write("Choose the number you want to delete: ");
            int user_input = Convert.ToInt32(Console.ReadLine());
            _hobbyGroups.RemoveAt(user_input);
        }
    }
}