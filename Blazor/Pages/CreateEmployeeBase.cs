﻿using Blazor.Services;
using Microsoft.AspNetCore.Components;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Pages
{
    public class CreateEmployeeBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IDepartmentService DepartmentService { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();

        public string DepartmentId { get; set; }
        [Parameter]
        public string Id { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Employee = new Employee
            {
                DepartmentId = 1,
                DateOfBrith = DateTime.Now,
                PhotoPath = "images/john.png"
            };
            Departments = (await DepartmentService.GetDepartments()).ToList();
            DepartmentId = Employee.DepartmentId.ToString();
        }
        protected async Task HandleValidSubmit()
        {
            Employee.DepartmentId = int.Parse(DepartmentId);
            var result = await EmployeeService.CreateEmployee(Employee);
            if (result != null)
            {
                NavigationManager.NavigateTo("/");
            }
        }
    }


}
