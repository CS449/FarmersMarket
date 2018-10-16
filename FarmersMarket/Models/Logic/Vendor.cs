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
            OwnerId = dr.Field<int>("owner_id");
            StoreName = dr.Field<string>("store_name");
        }

        public int VendorId { get; set; }
        public int OwnerId { get; set; }
        public string StoreName { get; set; }
    }
}