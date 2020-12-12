using System;
using System.Collections.Generic;

namespace ToString.Fody.App
{
    [ToString]
    public class Sample
    {
        public string Title { get; set; }

        [IgnoreDuringToString]
        public Guid SecretKey { get; set; }

        public ICollection<Item> Items { get; set; }
    }

    [ToString]
    public class Item
    {
        public string Description { get; set; }

        public DateTime? EndDate { get; set; }

        public decimal UnitPrice { get; set; }

        public int Quantity { get; set; }
    }
}
