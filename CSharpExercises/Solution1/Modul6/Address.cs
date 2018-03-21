using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Modul6
{
    public class Address
    {
        

        private readonly string _streetName;
        private readonly int _streetNumber;

        private string _zipCode;

        public string ZipCode
        {
            get => _zipCode;
            set
            {
                if (IsZipCode(value))
                {
                    _zipCode = value;
                }
            }
        }

        private readonly string _city;

        public Address(string streetName, int streetNumber, string zipCode, string city)
        {
            _streetName = streetName;
            _streetNumber = streetNumber;
            ZipCode = zipCode;
            _city = city;
        }

        public override string ToString()
        {
            List<Tuple<string, int>> list = new List<Tuple<string, int>>
                {
                    new Tuple<string, int>("", 10),
                    new Tuple<string, int>("", 30)
                };

            var list2 = new List<string>();
            list2.Add("Street");
            list2.Add(_streetName);
            new TableDisplayer(list).CreateRow(list2);

            return new TableDisplayer(list).CreateTable($"Street,{_streetName}\nStreetNumber,{_streetNumber}\nCity,{_city}\nZipCode,{ZipCode}".Split("\n").ToList());
        }

        private static bool IsZipCode(string zipCode)
        {
            if (zipCode.Length != 6)
            {
                return false;
            }

            if (zipCode.IndexOf(' ') != 3)
            {
                return false;
            }

            foreach (var character in zipCode)
            {
                if (character == ' ') continue;

                if (character < '0' || character > '9')
                    return false;
            }

            return true;
        }

        public string GetFullAddress()
        {
            return $"Fullstreet,{_streetName} {_streetNumber}";
        }

    }
}