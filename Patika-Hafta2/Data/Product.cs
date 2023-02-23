using System;

namespace Patika_Hafta1_Odev.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price{ get; set; }

        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string ImagePath { get; set; }

    }
}
