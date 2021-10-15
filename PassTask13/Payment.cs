using System;
using System.Collections.Generic;

namespace PassTask13
{
    public enum PaymentType
    {
        monthly,
        annual
    }

    public class Payment
    {
        private int _id;
        private double _paymentAmount;
        private Month _paymentMonth;
        private bool _paymentStatus;
        private PaymentType _paymentType;

        public Payment(int id, double paymentAmount, Month paymentMonth, bool paymentStatus, PaymentType paymentType){
            _id = id;
            _paymentAmount = paymentAmount;
            _paymentMonth = paymentMonth;
            _paymentStatus = paymentStatus;
            _paymentType = paymentType;
        }

        public bool PaymentStatus{
            get{return _paymentStatus;}
        }
    }
}