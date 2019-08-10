using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWEBMVC.Models
{

    public class Department
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }


        public void AddSeller(Seller seller) {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime datainit, DateTime final) {
            return Sellers.Sum(seller => seller.TotalSales(datainit, final));
        }
    }

}
