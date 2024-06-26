using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31_CSharp
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; }
        public int Population { get; set; }
        public string PhoneCode { get; }

        int countDistrictsMax = 4;
        int countDistricts = 0;

        public string[] Districts { get; set; }
        public City(string name, string country, int population, string phonecode)
        {
            Name = name;
            Country = country;
            Population = population;
            PhoneCode = phonecode;
            Districts = new string[countDistrictsMax];
        }

        public void AddDistrict(string district)
        {
            if(countDistricts < countDistrictsMax)
                Districts[countDistricts++] = district;
        }

        public void Info()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Country: {Country}");
            Console.WriteLine($"Population: {Population}");
            Console.WriteLine($"Phone code: {PhoneCode}");
            Console.WriteLine("Districts:");
            for (int i = 0; i < countDistricts; i++)
            {
                Console.WriteLine(Districts[i]);
            }
        }

    }
}
