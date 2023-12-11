using Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            var response = await _httpClient.GetAsync("http://localhost:8080/api/employee");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var employees = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employee>>(content);
            return employees;
        }

        public async Task<List<Department>> GetDepartmentsAsync()
        {
            var response = await _httpClient.GetAsync("http://localhost:8080/api/department");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            var departments = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Department>>(content);
            return departments;
        }
    }
}
