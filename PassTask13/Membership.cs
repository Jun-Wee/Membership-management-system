using System;
using System.Collections.Generic;

namespace PassTask13
{
    public enum Status
    {
        activate,
        deactivated        
    }
    public class Membership
    {
        private Status _status;
        private List<Payment> _paymentList;

        public Membership(){
            _status = Status.deactivated;
            _paymentList = new List<Payment>();
        }

        public void MakePayment(Payment p){
            _paymentList.Add(p);
        }

        public void DeletePayment(Payment p){
            _paymentList.Remove(p);
        }
        
        public Status MembershipStatus{
            get{return _status;}
            set{_status = value;}
        }

        public void Renewal(){
            int count = 0;
            foreach (Payment p in _paymentList)
            {
                if (p.PaymentStatus == false){
                    count+=1;
                }
            }

            // if the monthly payment has 2 or above status are false (didnt pay) 
            if (count >= 2){
                _status = Status.deactivated;
            }
            else{
                _status = Status.activate;
            }
        }
    }
}