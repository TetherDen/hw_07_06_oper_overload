using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_07_06_operators_overloading
{
    internal class Journal
    {
        public string Name { get; set; }
        public string Description { get; set; }

        private int _employeesNumber;
        public int EmployeesNumber
        {
            get {  return _employeesNumber; }
            set 
            {
                if(value < 0) 
                { 
                    throw new ArgumentOutOfRangeException(); 
                }
                _employeesNumber = value;
            }
        }

        public Journal(string name, string description, int employeesNumber)
        {
            Name = name;
            Description = description;
            EmployeesNumber = employeesNumber;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nDescription: {Description}\nEmployees number: {EmployeesNumber}\n";
        }

        public static Journal operator +(Journal obj, int value)
        {
            obj.EmployeesNumber += value;
            return obj;
        }

        public static Journal operator -(Journal obj, int value)
        {
            if (value > obj.EmployeesNumber)
            {
                throw new ArgumentOutOfRangeException();
            }
            obj.EmployeesNumber -= value;
            return obj;
        }

        public static bool operator ==(Journal obj1, Journal obj2)
        {
            return obj1.EmployeesNumber == obj2.EmployeesNumber;
        }
        public static bool operator !=(Journal obj1, Journal obj2)
        {
            return obj1.EmployeesNumber != obj2.EmployeesNumber;
        }

        public static bool operator <(Journal obj1, Journal obj2)
        {
            return obj1.EmployeesNumber < obj2.EmployeesNumber;
        }

        public static bool operator >(Journal obj1, Journal obj2)
        {
            return obj1.EmployeesNumber > obj2.EmployeesNumber;
        }

        public override bool Equals(object? obj)
        {
            return this.EmployeesNumber == ((Journal)obj).EmployeesNumber;
        }
    }
}
