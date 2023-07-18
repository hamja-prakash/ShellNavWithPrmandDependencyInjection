using MAUI_ShellNavigationWithParameterandDI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MAUI_ShellNavigationWithParameterandDI.Services
{
    public class StudentService : IStudentService
    {
        public async Task<List<Student>> GetAllStudents()
        {
            var StudentList = new List<Student>();
            using(var httpclient  = new HttpClient())
            {
                var response = await httpclient.GetAsync("https://gorest.co.in/public/v2/users");
                if(response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    StudentList = JsonConvert.DeserializeObject<List<Student>>(content);
                }
            }
            return StudentList;
        }
    }
}
