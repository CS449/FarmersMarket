using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using FarmersMarket.Models.Logic;
using FarmersMarket.Sql;

namespace FarmersMarket.Models.ViewModels
{
    public class MarketViewModel
    {
        public MarketViewModel()
        {
            Owners = DatabaseOperations.GetOwners()
                .AsEnumerable()
                .Select(o => new Owner(o))
                .ToList();
            Vendors = DatabaseOperations.GetVendors()
                .AsEnumerable()
                .Select(o => new Vendor(o))
                .ToList();
        }

        public List<Owner> Owners { get; set; }
        public List<Vendor> Vendors { get; set; }
    }
}