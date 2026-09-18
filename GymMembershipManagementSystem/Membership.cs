using System;
using System.Collections.Generic;
using System.Text;

namespace GymMembershipManagementSystem
{
    public class Membership
    {
        public int MembershipID { get; set; }

        public int MemberID { get; set; }

        public string MembershipType { get; set; } = "";

        public DateTime StartDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public decimal Fee { get; set; }

        public string PaymentStatus { get; set; } = "";

        public string MembershipStatus { get; set; } = "";
    }
}