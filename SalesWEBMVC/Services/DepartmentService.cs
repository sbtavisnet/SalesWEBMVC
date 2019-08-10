using SalesWEBMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWEBMVC.Services
{
    public class DepartmentService
    {

        private readonly SalesWEBMVCContext _context;
        public DepartmentService(SalesWEBMVCContext context)
        {
            _context = context;
        }


        public async Task<List<Department>> FindAllAync() {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();

        }


    }
}
