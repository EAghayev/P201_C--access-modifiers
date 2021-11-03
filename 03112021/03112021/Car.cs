using _03112021.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03112021
{
    class Car
    {
        protected int _year;
        public int Year
        {
            get => _year;
            set
            {
                if (value < 1950)
                    throw new InvalidCarYearException(null);
                else  _year = value;
            }
        }

        private string _brand;
        public string Brand
        {
            get => _brand;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3 || value.Length > 50)
                    throw new InvalidCarBrandException("Brand name 3-den kicik ve 50-den boyuk ola bilmez!");
                _brand = value;
            }
        }
    }

    class Jeep : Car
    {
        public Jeep(int year)
        {
        }
    }
}
