using AppMasterDetail.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppMasterDetail.ViewModels
{
    public class ListViewDemoViewModel : BaseViewModel
    {
        private List<Employee> employees;
        public string strProp { get; set; }

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

        public ListViewDemoViewModel()
        {
            strProp = "hi";
            BindEmp();
        }

        private void BindEmp()
        {
            employees = new List<Employee> {
                new Employee{ FirstName="first 1" , LastName="lastname 1", Department = "dept 1"},
                new Employee{ FirstName="first 2" , LastName="lastname 2", Department = "dept 2"},
                new Employee{ FirstName="first 3" , LastName="lastname 3", Department = "dept 3"},
                new Employee{ FirstName="first 4" , LastName="lastname 4", Department = "dept 4"},
                new Employee{ FirstName="first 5" , LastName="lastname 5", Department = "dept 5"}
            };
        }
    }
}
