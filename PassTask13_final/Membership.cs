using System;
using System.Collections.Generic;

namespace PassTask13
{
    /// <summary>
    /// Status enumeration
    /// </summary>
    public enum Status
    {
        activate,
        deactivated        
    }

    /// <summary>
    /// PaymentType enumeration
    /// </summary>
    public enum PaymentType
    {
        monthly,
        annual
    }
    
    /// <summary>
    /// This is Membership class that help to create Membership object
    /// </summary>
    public class Membership
    {
        private string _name;
        private Status _status;
        private Month _month;
        private int _year; 
        private PaymentType _membershipType;
        private int _expiryMonth;  //month duration left of membership 
        private int _expiryYear; //year duration left of membership


        /// <summary>
        /// This is pass by value constructor that will help to construct Membership object 
        /// </summary>
        public Membership(string name, int expiryMonth, int expiryYear, PaymentType membershipType, int year, Month month){
            _name = name;
            _status = Status.activate;
            _expiryMonth = expiryMonth;
            _expiryYear = expiryYear;
            _membershipType = membershipType;
            _year = year;
            _month = month;
        }

        /// <summary>
        /// this is MembershipStatus property which will help us to access the _status to change or retrive value
        /// </summary>
        public Status MembershipStatus{
            get{return _status;}
            set{_status = value;}
        }

        /// <summary>
        /// this is ExpiryMonth property which will help us to access the _expiryMonth to change or retrive value
        /// </summary>
        public int ExpiryMonth{
            get{return _expiryMonth;}
            set{_expiryMonth = value;}
        }

        /// <summary>
        /// this is ExpiryMonth property which will help us to access the _expiryYear to change or retrive value
        /// </summary>
        public int ExpiryYear{
            get{return _expiryYear;}
            set{_expiryYear = value;}
        }

        /// <summary>
        /// readonly property that return _name string
        /// </summary>
        public string MembershipName{
            get{return _name;}
        }

        /// <summary>
        /// readonly property that return _month Month 
        /// </summary>
        public Month MembershipMonth{
            get{return _month;}
        }

        /// <summary>
        /// readonly property that return _year int 
        /// </summary>
        public int MembershipYear{
            get{return _year;}
        }

        /// <summary>
        /// readonly property that return _membershipType PaymentType
        /// </summary>
        public PaymentType MembershipType{
            get{return _membershipType;}
        }

    }
}