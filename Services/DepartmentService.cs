using Ex1.Data;
using Ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Ex1.Services
{
    public class DepartmentService
    {
        private readonly Ex1Context _context;

        public DepartmentService(Ex1Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
