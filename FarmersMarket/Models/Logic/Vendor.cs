using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FarmersMarket.Models.Logic
{
    public class Vendor
    {
        public Vendor() { }
        public Vendor(DataRow dr)
        {
            VendorId = dr.Field<int>("vendor_id");
            LocationId = dr.Field<int>("location_id");
            StoreName = dr.Field<string>("store_name");
            FirstName = dr.Field<string>("first_name");
            LastName = dr.Field<string>("last_name");
        }

        public int VendorId { get; set; }
        public int LocationId { get; set; }
        public string StoreName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}