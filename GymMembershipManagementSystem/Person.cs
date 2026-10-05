using System;
using System.Collections.Generic;
using System.Text;

namespace GymMembershipManagementSystem
{
    public abstract class Person
    {
        public int MemberID { get; set; }

        public string Name { get; set; } = "";

        public abstract string GetDetails();
    }
}