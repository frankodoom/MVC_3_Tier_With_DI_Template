using Core.Services.Interface;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Service
{
    public class StudentService: GenericService<Student>, IStudentService
    {
        private WebContext _context;
        public StudentService(WebContext context) : base(context)
        {
            _context = context;
        }
    }
}
