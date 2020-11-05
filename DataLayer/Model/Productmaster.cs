using System;
using System.Collections.Generic;

namespace DataLayer.Model
{
    public partial class Productmaster
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string Uom { get; set; }
        public int? ManufacturerId { get; set; }
    }
}
