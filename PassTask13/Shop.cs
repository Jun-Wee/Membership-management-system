using System;
using System.Collections.Generic;

namespace PassTask13
{
    public class Shop
    {
        private bool _access;
        private List<HobbyGroups> _hobbygrp;
        private List<Member> _member;

        public Shop(){
            
            _hobbygrp = new List<HobbyGroups>();
            _member = new List<Member>();
            _access = false;

        }

        public void Addhobbygrp(HobbyGroups g){

        } 

        public void Edithobbygrp(HobbyGroups g){

        }
        public void Deletehobbygrp(HobbyGroups g){

        }

        public void Addmember(Member m){

        }
        public void Editmember(Member m){
            
        }
        public void Deletemember(Member m){
            
        }

        public List<HobbyGroups> Hobbygrp{
            get{return _hobbygrp;}
        }

        public List<Member> Member{
            get{return _member;}
        }

        public void Authnticateaccess(){

        }
    }
}