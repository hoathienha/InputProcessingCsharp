using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8
{
    class Customer
    {
        private string _name;
        private string _address;
        private int _phoneNum;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public int PhoneNum
        {
            get { return _phoneNum; }
            set { _phoneNum = value; }
        }
    }

    class Car
    {
        private string _make;
        private string _model;
        private int _year;

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
    }

    class ServiceRequest
    {
        private decimal _partsCharge;
        private decimal _laborCharge;

        public decimal PartsCharge
        {
            get { return _partsCharge; }
            set { _partsCharge = value; }
        }
        public decimal LaborCharge
        {
            get { return _laborCharge; }
            set { _laborCharge = value; }
        }

        public decimal GetTotal()
        {
             return _partsCharge + _laborCharge;
        }


    }
}
