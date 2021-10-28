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
    /// This is Membership class that help to create Membership object
    /// </summary>
    public class Membership
    {
        private string _name;
        private Status _status;
        private List<Payment> _paymentList;

        /// <summary>
        /// This is pass by value constructor that will help to construct Membership object 
        /// </summary>
        public Membership( string name){
            _name = name;
            _status = Status.deactivated;
            _paymentList = new List<Payment>();
        }

        /// <summary>
        /// function that will change payment status to true and it add into _paymentList 
        /// </summary>
        public void MakePayment(Payment p){
            p.PaymentStatus = true; //make the payment status true before add into list
            _paymentList.Add(p);
        }

        /// <summary>
        /// function that will delete certain payment object from the _paymentList list
        /// </summary>
        public void DeletePayment(Payment p){
            _paymentList.Remove(p);
        }

        /// <summary>
        /// function that will need Member object and Membership object to change the membership status and add into respective membership list
        /// </summary>
        public void Renewal(Member m, Membership ms){

           m.DeleteMembership(ms);
           int count = 0;
            foreach (Payment p in _paymentList)
            {
                if (p.PaymentType == PaymentType.monthly)  //only check the payment with monthly payment type 
                {
                    if (p.PaymentStatus == false){  
                        count+=1;
                    }
                }
            }   
            if (count >= 2){ // if the monthly payment has 2 or above status are false (didnt pay) 
                _status = Status.deactivated;
                m.AddMembership(ms);
            }
            else{  //if the monthly payment below 2 status are true (paid) and also include the payment with annualy payment type
            _status = Status.activate;
            m.AddMembership(ms);
            }
            
        }

        /// <summary>
        /// this is MembershipStatus property which will help us to access the _status to change or retrive value
        /// </summary>
        public Status MembershipStatus{
            get{return _status;}
            set{_status = value;}
        }

        /// <summary>
        /// return _name string
        /// </summary>
        public string MembershipName{
            get{return _name;}
        }

    }
}