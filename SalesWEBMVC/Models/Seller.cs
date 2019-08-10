using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace SalesWEBMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        
        [Required(ErrorMessage = "{0} requerido !!! ")]
        [StringLength(60, MinimumLength = 3,
                ErrorMessage = "{0}  deve ter entre  {2} e {1} caracteres !!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} requerido !!! ")]
        [EmailAddress(ErrorMessage = "{0} requerido !!!")]
        [DataType(DataType.EmailAddress)]        
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} requerido !!! ")]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} requerido !!! ")]
        [Range(100.00, 50000.0, ErrorMessage = "{0} deve estar entre {1} e {2}" )]
        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double BaseSalary { get; set; }

        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller() { }

        public Seller(int id, string nome, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Nome = nome;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr) {
            Sales.Add(sr);

        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final)
                .Sum(sr => sr.Amout);
        }
    }
}
