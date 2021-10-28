// using System;
// using System.Collections.Generic;

// namespace PassTask13
// {
//     /// <summary>
//     /// PaymentType enumeration
//     /// </summary>
//     public enum PaymentType
//     {
//         monthly,
//         annual
//     }

//     /// <summary>
//     /// This is Payment class that help to create Payment object
//     /// </summary>
//     public class Payment
//     {
//         private int _id;
//         private double _paymentAmount;
//         private Month _paymentMonth;
//         private bool _paymentStatus;
//         private PaymentType _paymentType;

//         /// <summary>
//         /// This is pass by value constructor that will help initialize the payment object
//         /// </summary>
//         public Payment(int id, double paymentAmount, Month paymentMonth, bool paymentStatus, PaymentType paymentType){
//             _id = id;
//             _paymentAmount = paymentAmount;
//             _paymentMonth = paymentMonth;
//             _paymentStatus = paymentStatus;
//             _paymentType = paymentType;
//         }

//         /// <summary>
//         /// this is PaymentStatus property which will help us to access the _paymentStatus to change or retrive value
//         /// </summary>
//         public bool PaymentStatus{
//             get{return _paymentStatus;}
//             set{_paymentStatus = value;}
//         }

//         /// <summary>
//         /// return _paymentType PaymenyType
//         /// </summary>
//         public PaymentType PaymentType{
//             get{return _paymentType;}
//         }
//     }
// }