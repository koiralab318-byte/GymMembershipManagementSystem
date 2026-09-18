using System;
using System.Collections.Generic;
using System.Text;

namespace GymMembershipManagementSystem
{
    public class Member
    {
        public int MemberID { get; set; }

        public string Name { get; set; } = "";

        public string Phone { get; set; } = "";

        public string Email { get; set; } = "";

        public DateTime JoinDate { get; set; }
    }
}
