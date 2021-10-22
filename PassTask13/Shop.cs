using System;
using System.Collections.Generic;

namespace PassTask13
{
    public class Shop
    {
        private bool _access;
        private HobbyGroups _hobbyGroups;
        private List<Member> _shopMember;

        public Shop(){
            _shopMember = new List<Member>();
            _access = false;

        }

        public void AddShopMember(Member m){
            _shopMember.Add(m);
        }
        public void DeleteShopMember(Member m){
            _shopMember.Remove(m);
        }

        public List<Member> ShopMember{
            get{return _shopMember;}
        }

        public void AuthnticateAccess(){
        }
    }
}