using System;
using System.Collections.Generic;
using System.Text;
namespace GymMembershipManagementSystem
{
    public class Member : Person
    {
        public string Phone { get; set; } = "";

        public string Email { get; set; } = "";

        public DateTime JoinDate { get; set; }

        public override string GetDetails()
        {
            return $"{MemberID} - {Name} - {Phone}";
        }
    }
}