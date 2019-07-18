using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    struct Car_Inventory
    {
        private string _make;
        private int _year;
        private int _mileage;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }
    }
}
