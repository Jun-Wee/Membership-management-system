using System;
using System.Collections.Generic;

namespace PassTask13
{
    /// <summary>
    /// This is Shop class that help to create shop object
    /// </summary>
    public class Shop
    {
        private HobbyGroups _hobbyGroups;
        private List<Member> _shopMember;

        /// <summary>
        /// This is default constructor it will initialize the shop object
        /// </summary>
        public Shop(){
            _shopMember = new List<Member>();
        }

        /// <summary>
        /// function that will add member object into _shopmember list
        /// </summary>
        public void AddShopMember(Member m){
            _shopMember.Add(m);
        }
        
        /// <summary>
        /// function that will help delete certain member object from _shopmember list based on user input 
        /// </summary>
        public void DeleteShopMember(){
            int x = 0;
            foreach (Member ms in _shopMember)
            {
                Console.WriteLine(x + " " + ms.Name);
                x++;
            }
            Console.Write("Choose the number you want to delete: ");
            int user_input = Convert.ToInt32(Console.ReadLine());
            _shopMember.RemoveAt(user_input);
        }

        /// <summary>
        /// return _shopMember list
        /// </summary>
        public List<Member> ShopMember{
            get{return _shopMember;}
        }
    }
}