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
        private string _name;
        private Status _status;
        private List<Payment> _paymentList;

        public Membership( string name){
            _name = name;
            _status = Status.deactivated;
            _paymentList = new List<Payment>();
        }

        public void MakePayment(Payment p){
            _paymentList.Add(p);
        }

        public void DeletePayment(Payment p){
            _paymentList.Remove(p);
        }

        public void Renewal(Member m, Membership ms){
            
            m.DeleteMembership(ms);

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
                m.AddMembership(ms);
            }
            else{
                _status = Status.activate;
                m.AddMembership(ms);
            }
        }

        public Status MembershipStatus{
            get{return _status;}
            set{_status = value;}
        }

        public string MembershipName{
            get{return _name;}
        }
    }
}