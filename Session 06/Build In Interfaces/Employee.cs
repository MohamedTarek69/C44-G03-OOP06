using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_06.Build_In_Interfaces
{
    internal class Employee : ICloneable , IComparable<Employee>
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        #endregion

        #region Constructors

        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }

        public Employee()
        {
            
        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return $"Id = {Id}, Name = {Name}, Salary = {Salary:c}";
        }

        public object Clone()
        {
            return new Employee(this);
            //return new Employee
            //{
            //    Id = this.Id,
            //    Name = this.Name,
            //    Salary = this.Salary
            //};
        }

        public int CompareTo(Employee? other)
        {
            // Emp01.CompareTo(other)
            // 1 => This.Salary > other.Salary
            // -1 => This.Salary < other.Salary
            // 0 => This.Salary == other.Salary
            //if (this.Salary > other?.Salary)
            //{
            //    return 1;
            //}
            //else if (this.Salary < other?.Salary)
            //{
            //    return -1;
            //}
            //else
            //{
            //    return 0;
            //}

            return this.Salary.CompareTo(other?.Salary);

        }

        //public int CompareTo(object? obj)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion
    }
}
