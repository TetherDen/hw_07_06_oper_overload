using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace hw_07_06_operators_overloading
{
    internal class Store
    {
        private double _area;
        public string Name { get; set; }

        public double Area
        {
            get { return _area; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value");
                _area = value;
            }
        }


        public Store (string name, double area)
        {
            Name = name;
            Area = area;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Area: {Area}";
        }

        public static Store operator + (Store obj, double value)
        {
            obj.Area += value;
            return obj ;
        }

        public static Store operator -(Store obj, double value)
        {
            if (value > obj.Area)
            {
                throw new ArgumentOutOfRangeException();
            }
            obj.Area -= value;
            return obj;
        }

        public static bool operator ==(Store obj1, Store obj2)
        {
            return obj1.Area == obj2.Area;
        }

        public static bool operator !=(Store obj1, Store obj2)
        {
            return obj1.Area != obj2.Area;
        }

        public static bool operator <(Store obj1, Store obj2)
        {
            return obj1.Area < obj2.Area;
        }

        public static bool operator >(Store obj1, Store obj2)
        {
            return obj1.Area > obj2.Area;
        }

        public override bool Equals(object? obj)
        {
            return this.Area == ((Store)obj).Area;
        }
    }
}
