using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FarmersMarket.Models.Logic
{
    public class Owner
    {
        public Owner() { }
        public Owner(DataRow dr)
        {
            OwnerId = dr.Field<int>("owner_id");
            FirstName = dr.Field<string>("first_name");
            LastName = dr.Field<string>("last_name");
            Email = dr.Field<string>("email");
            Phone = dr.Field<string>("phone");
        }

        public int OwnerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}