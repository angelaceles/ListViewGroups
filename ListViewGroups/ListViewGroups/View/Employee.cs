using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewGroups
{
    public class Employee
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public Employee() { }
    }
    public class GroupModel : ObservableCollection<Employee>
    {
        public string LongIdentity { get; set; }
        public string ShortIdentity { get; set; }
    }
}
