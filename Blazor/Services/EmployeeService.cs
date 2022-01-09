﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Blazor.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient httpClient;


        public EmployeeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            return await httpClient.GetFromJsonAsync<Employee[]>("api/employees");
        }
        public async Task<Employee> GetEmployee(int id)
        {
            return await httpClient.GetFromJsonAsync<Employee>($"api/employees/{id}");
        }

        public async Task<HttpResponseMessage> UpdateEmployee(Employee updateEmployee)
        {
            return await httpClient.PutAsJsonAsync<Employee>($"api/employees/{updateEmployee.EmployeeId}", updateEmployee);

        }

        public async Task<HttpResponseMessage> CreateEmployee(Employee NewEmployee)
        {
            return await httpClient.PostAsJsonAsync<Employee>("api/employees", NewEmployee);
        }

        public async Task DeleteEmployee(int id)
        {
            await httpClient.DeleteAsync($"api/employees/{id}");
        }
    }
}

