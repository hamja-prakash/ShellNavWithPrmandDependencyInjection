using MAUI_ShellNavigationWithParameterandDI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_ShellNavigationWithParameterandDI.Services
{
    public interface IStudentService
    {
       Task<List<Student>> GetAllStudents();
    }
}
