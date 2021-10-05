using SmuzApp.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuzApp.Core.AdminAggregrate
{
    public class Admin : BaseEntity, IAggregateRoot
    {
        public Admin(int adminID, string firstName, string lastName, string roleID, bool activeYN)
        {
            AdminID = adminID;
            FirstName = firstName;
            LastName = lastName;
            RoleID = roleID;
            ActiveYN = activeYN;
        }

        public int AdminID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RoleID { get; set; }
        public bool ActiveYN { get; set; }
    }
}
