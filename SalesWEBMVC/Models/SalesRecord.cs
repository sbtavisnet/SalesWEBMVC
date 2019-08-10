using SalesWEBMVC.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SalesWEBMVC.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        public double Amout { get; set; }
        public SalesStatus Status { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public Seller Seller { get; set; }


        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amout, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amout = amout;
            Status = status;
            Seller = seller;
        }


    }
}
