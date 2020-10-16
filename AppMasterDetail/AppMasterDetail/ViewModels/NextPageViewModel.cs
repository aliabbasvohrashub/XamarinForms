using AppMasterDetail.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMasterDetail.ViewModels
{
    public class NextPageViewModel : BaseViewModel
    {
        public ObservableCollection<Employee> employees;
        public Command employeeCommand;
        public NextPageViewModel()
        {
            Title = "nextpage";
            employees = new ObservableCollection<Employee>();
            employeeCommand = new Command(async () => await ExecuteLoadItemsCommand());
        }
        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                employees.Clear(); 
                var items = await EmployeeStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    employees.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
